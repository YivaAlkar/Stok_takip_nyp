using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace stokSatis_Akay.UI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430054;User ID=26_132430054;Password=İnif123.;";

        private void ReportForm_Load(object sender, EventArgs e)
        {
            KpiKartlariniDoldur();
            TabloyuDoldur();
            GrafikleriDoldur();
        }

        private void KpiKartlariniDoldur()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    using (MySqlCommand komutCiro = new MySqlCommand("SELECT SUM(toplamTutar) FROM satis", baglanti))
                    {
                        object sonucCiro = komutCiro.ExecuteScalar();
                        lblToplamCiro.Text = (sonucCiro != null && sonucCiro != DBNull.Value)
                            ? Convert.ToDecimal(sonucCiro).ToString("C2")
                            : "0,00 ₺";
                    }

                    using (MySqlCommand komutSatisSayisi = new MySqlCommand("SELECT COUNT(*) FROM satis", baglanti))
                    {
                        object sonucSatis = komutSatisSayisi.ExecuteScalar();
                        if (sonucSatis != null && sonucSatis != DBNull.Value)
                            lblToplamSatis.Text = sonucSatis + " Adet Satış";
                    }

                    using (MySqlCommand komutStok = new MySqlCommand("SELECT COUNT(*) FROM urunler WHERE stokMiktari <= minStokLimit", baglanti))
                    {
                        object sonucStok = komutStok.ExecuteScalar();
                        if (sonucStok != null && sonucStok != DBNull.Value)
                        {
                            int kritikSayi = Convert.ToInt32(sonucStok);
                            lblKritikStok.Text = kritikSayi + " Ürün Kritik";
                            lblKritikStok.ForeColor = kritikSayi > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                        }
                    }

                    using (MySqlCommand komutMusteri = new MySqlCommand("SELECT COUNT(*) FROM musteriler", baglanti))
                    {
                        object sonucMusteri = komutMusteri.ExecuteScalar();
                        if (sonucMusteri != null && sonucMusteri != DBNull.Value)
                            lblEnIyiMusteri.Text = sonucMusteri + " Kayıtlı Müşteri";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kart Verisi Hatası: " + ex.Message);
                }
            }
        }

        private void GrafikleriDoldur()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    using (MySqlCommand komutPasta = new MySqlCommand("SELECT urunAdi, stokMiktari FROM urunler", baglanti))
                    using (MySqlDataReader okunanPasta = komutPasta.ExecuteReader())
                    {
                        chartUrunler.Series[0].Points.Clear();
                        chartUrunler.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                        chartUrunler.Series[0]["PieLabelStyle"] = "Disabled";
                        chartUrunler.Series[0].LegendText = "#VALX";
                        chartUrunler.Series[0].ToolTip = "#VALX: #VALY Adet";

                        while (okunanPasta.Read())
                        {
                            chartUrunler.Series[0].Points.AddXY(
                                okunanPasta["urunAdi"].ToString(),
                                Convert.ToInt32(okunanPasta["stokMiktari"]));
                        }
                    }

                    using (MySqlCommand komutKar = new MySqlCommand(
                        "SELECT urunAdi, (satisFiyati - alisFiyati) as UrunKari FROM urunler ORDER BY UrunKari DESC LIMIT 7",
                        baglanti))
                    using (MySqlDataReader okunanKar = komutKar.ExecuteReader())
                    {
                        chartCiro.Series[0].Points.Clear();
                        chartCiro.Series[0].Name = "UrunKari";
                        chartCiro.Series[0].LegendText = "Ürün Başına Kâr (TL)";
                        chartCiro.Series[0].Color = System.Drawing.Color.ForestGreen;

                        chartCiro.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                        chartCiro.ChartAreas[0].AxisX.Interval = 1;

                        while (okunanKar.Read())
                        {
                            chartCiro.Series[0].Points.AddXY(
                                okunanKar["urunAdi"].ToString(),
                                okunanKar["UrunKari"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grafik Hatası: " + ex.Message);
                }
            }
        }

        private void TabloyuDoldur()
        {
            dataGridView1.Rows.Clear();

            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    using (MySqlCommand komut = new MySqlCommand(@"SELECT s.satisTarihi, m.adSoyad, s.toplamTutar, GROUP_CONCAT(CONCAT(u.urunAdi, ' x', sd.miktar) SEPARATOR ', ') AS urunler FROM satis s JOIN musteriler m ON m.musteri_id = s.musteriId LEFT JOIN satisDetay sd ON sd.satisId = s.Id LEFT JOIN urunler u ON u.Id = sd.urunId GROUP BY s.Id, s.satisTarihi, m.adSoyad, s.toplamTutar ORDER BY s.satisTarihi DESC", baglanti)) 
                    using (MySqlDataReader okunan = komut.ExecuteReader())
                    {
                        while (okunan.Read())
                        {
                            DateTime hamTarih = Convert.ToDateTime(okunan["satisTarihi"]);
                            string temizTarih = hamTarih.ToString("dd.MM.yyyy");

                            string musteriAdi = okunan["adSoyad"].ToString();
                            string tutar = Convert.ToDecimal(okunan["toplamTutar"]).ToString("N2");
                            string urunler = okunan["urunler"] == DBNull.Value ? "" : okunan["urunler"].ToString();

                            dataGridView1.Rows.Add(temizTarih, musteriAdi, tutar, urunler);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tablo Hatası: " + ex.Message);
                }
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            KpiKartlariniDoldur();
            GrafikleriDoldur();
            TabloyuDoldur();

            Cursor = Cursors.Default;

            MessageBox.Show("Rapor verileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblKritikStok_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
