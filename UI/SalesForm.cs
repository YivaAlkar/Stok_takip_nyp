using MySql.Data.MySqlClient;
using StokSatisTakipSistemi.BLL;
using StokSatisTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace stokSatis_Akay.UI
{
    public partial class SalesForm : Form
    {
        private string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430054;User ID=26_132430054;Password=İnif123.;";
        private string _rol;
        decimal genelToplam = 0;

        public SalesForm(string rol)
        {
            InitializeComponent();
            _rol = rol;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager();
            DataTable dt = customerManager.MusterileriGetir();

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbMusteriler.DataSource = dt;
                cmbMusteriler.DisplayMember = "adSoyad";
                cmbMusteriler.ValueMember = "musteri_id";
            }

            urunManager manager = new urunManager();
            var urunler = manager.TumUrunleriGetir();

            cmbUrunler.DataSource = urunler;
            cmbUrunler.DisplayMember = "urunAdi";
            cmbUrunler.ValueMember = "Id";

            FormuSifirla();

        }

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {
            Urun seciliUrun = (Urun)cmbUrunler.SelectedItem;
            int adet = int.Parse(txtAdet.Text);

            decimal araToplam = adet * seciliUrun.SatisFiyati;
            genelToplam += araToplam;

            lblToplamTutar.Text = $"Toplam Tutar: {genelToplam:N2} TL";
        }

        public bool MusteriAlimGuncelle(int musteriId, decimal miktar)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                string sorgu = @"UPDATE musteriler 
                             SET toplam_alim = IFNULL(toplam_alim, 0) + @miktar 
                             WHERE musteri_id = @id";

                using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@miktar", miktar);
                    komut.Parameters.AddWithValue("@id", musteriId);

                    baglanti.Open();
                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }

        private void btnSatisiOnayla_Click(object sender, EventArgs e)
        {
            if (dgvSepet.Rows.Count == 0 || (dgvSepet.Rows.Count == 1 && dgvSepet.Rows[0].IsNewRow))
            {
                MessageBox.Show("Sepet boş!");
                return;
            }

            if (cmbMusteriler.SelectedValue == null)
            {
                MessageBox.Show("Müşteri seçiniz!");
                return;
            }

            int musteriId = Convert.ToInt32(cmbMusteriler.SelectedValue);

            urunManager um = new urunManager();

            int satisId;
            try
            {
                satisId = um.SatisKaydet(musteriId, genelToplam);
                if (satisId <= 0)
                {
                    MessageBox.Show("Satış kaydı oluşturulamadı!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış kaydetme hatası: " + ex.Message);
                return;
            }

            bool hataOlduMu = false;

            foreach (DataGridViewRow row in dgvSepet.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    int urunId = Convert.ToInt32(row.Cells[0].Value);
                    int adet = Convert.ToInt32(row.Cells[2].Value);
                    decimal birimFiyat = Convert.ToDecimal(row.Cells[3].Value);

                    bool stokSonuc = um.StokDus(urunId, adet);
                    if (!stokSonuc) hataOlduMu = true;

                    bool detaySonuc = um.SatisDetayKaydet(satisId, urunId, adet, birimFiyat);
                    if (!detaySonuc) hataOlduMu = true;
                }
                catch
                {
                    hataOlduMu = true;
                }
            }

            if (hataOlduMu)
            {
                MessageBox.Show("Satış kaydedildi ama bazı kalemlerde hata oluştu! Stok/Detay kontrol et.");
                return;
            }

            MusteriAlimGuncelle(musteriId, genelToplam);

            MessageBox.Show("Satış başarıyla tamamlandı ve kaydedildi.");

            dgvSepet.Rows.Clear();
            genelToplam = 0;
            lblToplamTutar.Text = $"Toplam Tutar: {genelToplam:N2} TL";

            FormuSifirla();

            urunManager manager = new urunManager();
            cmbUrunler.DataSource = null;
            cmbUrunler.DataSource = manager.TumUrunleriGetir();
            cmbUrunler.DisplayMember = "urunAdi";
            cmbUrunler.ValueMember = "Id";

        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (!int.TryParse(txtAdet.Text, out int adet) || adet <= 0)
            {
                MessageBox.Show("Geçerli bir adet girin.");
                return;
            }

            Urun seciliUrun = (Urun)cmbUrunler.SelectedItem;

            if (seciliUrun.StokMiktari < adet)
            {
                MessageBox.Show("Yetersiz stok!");
                return;
            }

            decimal araToplam = adet * seciliUrun.SatisFiyati;

            dgvSepet.Rows.Add(
                seciliUrun.Id,
                seciliUrun.UrunAdi,
                adet,
                seciliUrun.SatisFiyati,
                araToplam
            );

            genelToplam += araToplam;
            lblToplamTutar.Text = $"{genelToplam:N2} TL";
        }

        private void FormuSifirla()
        {
            dgvSepet.Rows.Clear();
            genelToplam = 0;
            lblToplamTutar.Text = $"Toplam Tutar: {genelToplam:N2} TL";
            txtAdet.Clear();

            if (cmbMusteriler.DataSource != null && cmbMusteriler.Items.Count > 0)
                cmbMusteriler.SelectedIndex = 0;

            if (cmbUrunler.DataSource != null && cmbUrunler.Items.Count > 0)
                cmbUrunler.SelectedIndex = 0;

            cmbMusteriler.Focus();
        }

        private void dgvSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
