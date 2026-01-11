using System;

namespace StokSatisTakipSistemi.Entities
{
    public class Urun : baseClass
    {
        public string UrunAdi { get; set; }
        public int StokMiktari { get; set; }
        public int MinStokLimit { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
    }
}
