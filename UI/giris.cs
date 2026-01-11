using stokSatis_Akay.UI;
using StokSatisTakipSistemi.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace stokSatis_Akay
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            pnlGiris.BackColor = Color.FromArgb(150, 255, 255, 255);
            pnlKayit.BackColor = Color.FromArgb(150, 255, 255, 255);

            CenterPanel(pnlGiris);
            CenterPanel(pnlKayit);

            pnlGiris.Visible = true;
            pnlKayit.Visible = false;

            SetRoundedCorners(pnlGiris, 20);
            SetRoundedCorners(pnlKayit, 20);

            sifreTxt.PasswordChar = '\0';
            txtYeniSifre.PasswordChar = '\0';

            SetPlaceholder(kullaniciTxt, "Kullanıcı Adı");
            SetPlaceholder(sifreTxt, "Şifre");
            SetPlaceholder(txtYeniAd, "Kullanıcı Adı");
            SetPlaceholder(txtYeniSifre, "Şifre");
            SetComboPlaceholder(cmbYeniRol, "Rol Seçiniz");
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            string ad = kullaniciTxt.Text;
            string sifre = sifreTxt.Text;

            KullaniciManager kullaniciManager = new KullaniciManager();
            var kullanici = kullaniciManager.GirisKontrol(ad, sifre);

            if (kullanici != null)
            {
                MessageBox.Show($"Hoş geldiniz {kullanici.KullaniciAdi}");

                MainForm anaForm = new MainForm(kullanici.Rol);
                anaForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void btnKayitGit_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            pnlKayit.Visible = true;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            pnlKayit.Visible = false;
            pnlGiris.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Length < 4)
            {
                MessageBox.Show("Şifre en az 4 karakter olmalıdır!");
                return;
            }

            if (string.IsNullOrEmpty(txtYeniAd.Text) ||
                string.IsNullOrEmpty(txtYeniSifre.Text) ||
                cmbYeniRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            KullaniciManager manager = new KullaniciManager();
            bool sonuc = manager.KayitEkle(txtYeniAd.Text, txtYeniSifre.Text, cmbYeniRol.SelectedItem.ToString());

            if (!sonuc) return;

            MessageBox.Show("Kullanıcı başarıyla kaydedildi! Şimdi giriş yapabilirsiniz.");

            pnlKayit.Visible = false;
            pnlGiris.Visible = true;

            txtYeniAd.Clear();
            txtYeniSifre.Clear();
        }

        private void CenterPanel(Panel pnl)
        {
            pnl.Left = (ClientSize.Width - pnl.Width) / 2;
            pnl.Top = (ClientSize.Height - pnl.Height) / 2;
        }

        private void SetRoundedCorners(Panel pnl, int cornerRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            pnl.Region = new Region(path);
        }

        private void SetPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = Color.Gray;

            txt.Enter += (s, e) =>
            {
                if (txt.Text != placeholderText) return;
                txt.Text = "";
                txt.ForeColor = Color.Black;
                if (txt.Name.Contains("Sifre")) txt.PasswordChar = '*';
            };

            txt.Leave += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(txt.Text)) return;
                txt.Text = placeholderText;
                txt.ForeColor = Color.Gray;
                if (txt.Name.Contains("Sifre")) txt.PasswordChar = '\0';
            };
        }

        private void SetComboPlaceholder(ComboBox cmb, string placeholderText)
        {
            cmb.Text = placeholderText;
            cmb.ForeColor = Color.Gray;

            cmb.Enter += (s, e) =>
            {
                if (cmb.Text != placeholderText) return;
                cmb.Text = "";
                cmb.ForeColor = Color.Black;
            };

            cmb.Leave += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(cmb.Text)) return;
                cmb.Text = placeholderText;
                cmb.ForeColor = Color.Gray;
            };
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void kullaniciLbl_Click(object sender, EventArgs e) { }
        private void txtYeniSifre_TextChanged(object sender, EventArgs e) { }
        private void txtYeniAd_TextChanged(object sender, EventArgs e) { }
        private void pnlKayit_Paint(object sender, PaintEventArgs e) { }
    }
}
