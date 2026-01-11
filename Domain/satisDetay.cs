using System;

namespace StokSatisTakipSistemi.Entities
{
    public class SatisDetay : baseClass
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}
