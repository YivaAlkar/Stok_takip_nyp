using System;

namespace StokSatisTakipSistemi.Entities
{
    public class Kullanici : baseClass
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } = string.Empty;
    }
}
