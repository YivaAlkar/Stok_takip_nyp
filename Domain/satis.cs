using System;

namespace StokSatisTakipSistemi.Entities
{
    public class Satis : baseClass
    {
        public int MusteriId { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
