using MySql.Data.MySqlClient;
using StokSatisTakipSistemi.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace stokSatis_Akay.UI
{
    public partial class CustomerForm : Form
    {
        string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430054;User ID=26_132430054;Password=İnif123.;";
        string sorgu = "SELECT musteri_id, adSoyad, telefon FROM musteriler";

        public CustomerForm()
        {
            InitializeComponent();
        }

        public DataTable MusterileriGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            using (MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool MusteriEkle(string ad, string tel)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            using (MySqlCommand komut = new MySqlCommand("INSERT INTO musteriler (adSoyad, telefon) VALUES (@ad, @tel)", baglanti))
            {
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@tel", tel);

                baglanti.Open();
                return komut.ExecuteNonQuery() > 0;
            }
        }

        public bool MusteriGuncelle(int id, string ad, string tel)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            using (MySqlCommand komut = new MySqlCommand("UPDATE musteriler SET adSoyad=@ad, telefon=@tel WHERE musteri_id=@id", baglanti))
            {
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@tel", tel);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                return komut.ExecuteNonQuery() > 0;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dgvMusteriler.AutoGenerateColumns = false;
            MusteriListesiniGuncelle();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            CustomerManager manager = new CustomerManager();
            string ad = txtMusteriAd.Text;
            string tel = txtTelefon.Text;

            if (manager.MusteriEkle(ad, tel))
            {
                MessageBox.Show("Müşteri kaydedildi!");
                MusteriListesiniGuncelle();
            }

            AlanlariTemizle();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriId.Text)) return;

            CustomerManager manager = new CustomerManager();
            int id = int.Parse(txtMusteriId.Text);
            string ad = txtMusteriAd.Text;
            string tel = txtTelefon.Text;

            if (manager.MusteriGuncelle(id, ad, tel))
            {
                MessageBox.Show("Güncellendi!");
                MusteriListesiniGuncelle();
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriId.Text))
            {
                MessageBox.Show("Lütfen silinecek müşteriyi tablodan seçin!");
                return;
            }

            DialogResult onay = MessageBox.Show(
                "Bu müşteriyi silmek istediğinize emin misiniz?",
                "Kayıt Silme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (onay != DialogResult.Yes) return;

            CustomerManager manager = new CustomerManager();
            int id = int.Parse(txtMusteriId.Text);

            if (manager.MusteriSil(id))
            {
                MessageBox.Show("Müşteri başarıyla silindi.");
                MusteriListesiniGuncelle();
                AlanlariTemizle();
            }
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager manager = new CustomerManager();
                DataTable dt = manager.MusterileriGetir();
                dgvMusteriler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            CustomerManager manager = new CustomerManager();
            DataTable dt = manager.MusterileriGetir();

            if (dt == null) return;

            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("adSoyad LIKE '%{0}%'", txtMusteriAra.Text);
            dgvMusteriler.DataSource = dv;
        }

        private void btnAlanlariTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void AlanlariTemizle()
        {
            txtMusteriId.Clear();
            txtMusteriAd.Clear();
            txtTelefon.Clear();
            txtMusteriAra.Clear();
        }

        private void MusteriListesiniGuncelle()
        {
            try
            {
                CustomerManager manager = new CustomerManager();
                DataTable dt = manager.MusterileriGetir();

                if (dt == null)
                {
                    MessageBox.Show("Müşteri listesi veritabanından alınamadı!");
                    return;
                }

                dgvMusteriler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında hata: " + ex.Message);
            }
        }

        private void dgvMusteriler_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;

            object idVal = dgvMusteriler.CurrentRow.Cells["musteri_id"].Value;
            object adVal = dgvMusteriler.CurrentRow.Cells["adSoyad"].Value;
            object telVal = dgvMusteriler.CurrentRow.Cells["telefon"].Value;

            txtMusteriId.Text = idVal?.ToString();
            txtMusteriAd.Text = adVal?.ToString();
            txtTelefon.Text = telVal?.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtTelefon_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
