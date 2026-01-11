using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokSatisTakipSistemi.Entities;

namespace StokSatisTakipSistemi.BLL
{
    public class SatisManager
    {
        public string SatisYap(Satis s, int urunStokMiktari, int satilacakMiktar)
        {
            return satilacakMiktar > urunStokMiktari
                ? "Hata: Yetersiz stok! Mevcut: " + urunStokMiktari
                : "Satış başarıyla tamamlandı.";
        }

        public List<Urun> KritikStoklariGetir()
        {
            urunManager urunManager = new urunManager();
            List<Urun> urunler = urunManager.TumUrunleriGetir();

            if (urunler == null)
                return new List<Urun>();

            return urunler
                .Where(u => u.StokMiktari <= u.MinStokLimit)
                .ToList();
        }

        public List<Satis> TumSatislariGetir()
        {
            return new List<Satis>();
        }
    }
}
