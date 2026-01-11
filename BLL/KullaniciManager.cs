using MySql.Data.MySqlClient;
using StokSatisTakipSistemi.Entities;
using System;
using System.Windows.Forms;

namespace StokSatisTakipSistemi.BLL
{
    public class KullaniciManager
    {
        private readonly string baglantiCumlesi =
            "Server=172.21.54.253;Database=26_132430054;User ID=26_132430054;Password=İnif123.;";

        public Kullanici GirisKontrol(string ad, string sifre)
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    string sorgu = "SELECT * FROM kullanici WHERE kullaniciAdi=@ad AND sifre=@sifre";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        baglanti.Open();

                        using (MySqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return new Kullanici
                                {
                                    KullaniciAdi = dr["kullaniciAdi"].ToString(),
                                    Rol = dr["rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch
            {
               
            }

            return null;
        }

        public bool KayitEkle(string ad, string sifre, string rol)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                try
                {
                    string sorgu = "INSERT INTO kullanici (kullaniciAdi, sifre, rol) VALUES (@ad, @sifre, @rol)";

                    using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        komut.Parameters.AddWithValue("@rol", rol);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        return sonuc > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Hatası: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
