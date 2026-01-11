using System;
using System.Drawing;
using System.Windows.Forms;
using StokSatisTakipSistemi.BLL;

namespace stokSatis_Akay.UI
{
    public partial class MainForm : Form
    {
        private string kullaniciRolu;

        public MainForm(string kullaniciAdi, string rol)
        {
            InitializeComponent();
        }

        public MainForm(string rol)
        {
            InitializeComponent();
            kullaniciRolu = rol;
            ArayuzuYetkilendir();
        }

        private void ArayuzuYetkilendir()
        {
            switch (kullaniciRolu)
            {
                case "Yönetici":
                    break;

                case "Satış Personeli":
                    ürünBtn.Visible = false;
                    raporBtn.Visible = false;
                    break;

                case "Depo Görevlisi":
                    satısBtn.Visible = false;
                    raporBtn.Visible = false;
                    break;

                default:
                    MessageBox.Show("Yetkisiz Giriş!");
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ürünBtn.Visible = false;
            satısBtn.Visible = false;
            raporBtn.Visible = false;

            switch (kullaniciRolu)
            {
                case "Yönetici":
                    ürünBtn.Visible = true;
                    satısBtn.Visible = true;
                    raporBtn.Visible = true;
                    break;

                case "Satış Personeli":
                    satısBtn.Visible = true;
                    ürünBtn.Visible = true;
                    break;

                case "Depo Görevlisi":
                    ürünBtn.Visible = true;
                    break;
            }

            try
            {
                urunManager um = new urunManager();
                var urunler = um.TumUrunleriGetir();
                lblToplamUrun.Text = (urunler?.Count ?? 0).ToString();

                CustomerManager cm = new CustomerManager();
                var musteriler = cm.MusterileriGetir();
                lblToplamMusteri.Text = (musteriler?.Rows.Count ?? 0).ToString();

                if (kullaniciRolu != "Depo Görevlisi")
                {
                    SatisManager sm = new SatisManager();
                    lblToplamSatis.Text = (sm.TumSatislariGetir()?.Count ?? 0).ToString();
                }
                else
                {
                    lblToplamSatis.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }

            timer1.Start();
        }

        public void DashboardVerileriniYenile()
        {
            urunManager um = new urunManager();
            int satisAdeti = um.SatisSayisiniGetir();
            lblToplamSatis.Text = satisAdeti.ToString();
        }

        private void FormuGetir(Form altForm)
        {
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            altForm.Show();
        }

        private void raporBtn_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.ShowDialog();
        }

        private void ürünBtn_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm(kullaniciRolu);
            frm.Show();
        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            CustomerForm musteriFormu = new CustomerForm();
            musteriFormu.Show();
        }

        private void satısBtn_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm(kullaniciRolu);
            frm.ShowDialog();
            DashboardVerileriniYenile();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy dddd HH:mm:ss");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblUrunBaslik_Click(object sender, EventArgs e) { }

        private void lblToplamMusteri_Click(object sender, EventArgs e)
        {

        }
    }
}
