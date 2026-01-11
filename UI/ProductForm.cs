using StokSatisTakipSistemi.BLL;
using StokSatisTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace stokSatis_Akay.UI
{
    public partial class ProductForm : Form
    {
        string _kullaniciRolu = "";
        List<Urun> _tumUrunler;


        public ProductForm(string rol)
        {
            InitializeComponent();
            _kullaniciRolu = rol;
            dgwUrunler.CellClick += dgwUrunler_CellClick;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (_kullaniciRolu == "Satış Personeli")
            {
                btnEkle.Enabled = false;
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
            }

            Listele();
        }

        void Listele()
        {
            urunManager um = new urunManager();

            _tumUrunler = um.TumUrunleriGetir()
                .OrderBy(x => x.UrunAdi)
                .ToList();

            dgwUrunler.AutoGenerateColumns = true;
            dgwUrunler.DataSource = _tumUrunler;
        }

        void Temizle()
        {
            txtUrunAdi.Clear();
            txtStok.Clear();
            txtMinStok.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
            txtUrunAdi.Tag = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun
            {
                UrunAdi = txtUrunAdi.Text,
                StokMiktari = int.Parse(txtStok.Text),
                MinStokLimit = int.Parse(txtMinStok.Text),
                AlisFiyati = decimal.Parse(txtAlisFiyat.Text),
                SatisFiyati = decimal.Parse(txtSatisFiyat.Text)
            };

            urunManager um = new urunManager();

            if (um.UrunEkle(yeniUrun))
            {
                Temizle();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Tag == null) return;

            Urun guncellenecek = new Urun
            {
                Id = Convert.ToInt32(txtUrunAdi.Tag),
                UrunAdi = txtUrunAdi.Text,
                StokMiktari = int.Parse(txtStok.Text),
                MinStokLimit = int.Parse(txtMinStok.Text),
                AlisFiyati = decimal.Parse(txtAlisFiyat.Text),
                SatisFiyati = decimal.Parse(txtSatisFiyat.Text)
            };

            urunManager um = new urunManager();

            if (um.Guncelle(guncellenecek))
            {
                Temizle();
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Tag == null) return;

            int id = Convert.ToInt32(txtUrunAdi.Tag);
            urunManager um = new urunManager();

            if (um.Sil(id))
            {
                Temizle();
                Listele();
            }
        }

        //private void txtUrunAra_TextChanged(object sender, EventArgs e){}

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var satir = (Urun)dgwUrunler.Rows[e.RowIndex].DataBoundItem;

            txtUrunAdi.Text = satir.UrunAdi;
            txtStok.Text = satir.StokMiktari.ToString();
            txtMinStok.Text = satir.MinStokLimit.ToString();
            txtAlisFiyat.Text = satir.AlisFiyati.ToString();
            txtSatisFiyat.Text = satir.SatisFiyati.ToString();

            txtUrunAdi.Tag = satir.Id;
        }

        private void txtUrunAra_TextChanged_1(object sender, EventArgs e)
        {
            if (_tumUrunler == null) return;

            string aranan = txtUrunAra.Text.ToLower();

            var filtreli = _tumUrunler
                .Where(x => x.UrunAdi != null &&
                            x.UrunAdi.ToLower().Contains(aranan))
                .OrderBy(x => x.UrunAdi)
                .ToList();

            dgwUrunler.DataSource = filtreli;
        }
    }
}
