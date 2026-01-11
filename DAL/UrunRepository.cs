using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StokSatisTakipSistemi.Entities;

namespace StokSatisTakipSistemi.DAL
{
    public class UrunRepository : IRepository<Urun>
    {
        public void Ekle(Urun urun)
        {
            using (MySqlConnection conn = Baglanti.BaglantiAl())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO urunler (urunAdi, stokMiktari, minStokLimit, alisFiyati, satisFiyati) " +
                    "VALUES (@ad, @stok, @limit, @alis, @satis)", conn))
                {
                    cmd.Parameters.AddWithValue("@ad", urun.UrunAdi);
                    cmd.Parameters.AddWithValue("@stok", urun.StokMiktari);
                    cmd.Parameters.AddWithValue("@limit", urun.MinStokLimit);
                    cmd.Parameters.AddWithValue("@alis", urun.AlisFiyati);
                    cmd.Parameters.AddWithValue("@satis", urun.SatisFiyati);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Guncelle(Urun urun)
        {
            using (MySqlConnection conn = Baglanti.BaglantiAl())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE urunler SET urunAdi=@ad, stokMiktari=@stok, minStokLimit=@limit, " +
                    "alisFiyati=@alis, satisFiyati=@satis WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@ad", urun.UrunAdi);
                    cmd.Parameters.AddWithValue("@stok", urun.StokMiktari);
                    cmd.Parameters.AddWithValue("@limit", urun.MinStokLimit);
                    cmd.Parameters.AddWithValue("@alis", urun.AlisFiyati);
                    cmd.Parameters.AddWithValue("@satis", urun.SatisFiyati);
                    cmd.Parameters.AddWithValue("@id", urun.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Sil(int id)
        {
            using (MySqlConnection conn = Baglanti.BaglantiAl())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM urunler WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Urun> Listele()
        {
            List<Urun> urunler = new List<Urun>();

            using (MySqlConnection conn = Baglanti.BaglantiAl())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM urunler", conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        urunler.Add(new Urun
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            UrunAdi = reader["urunAdi"].ToString(),
                            StokMiktari = Convert.ToInt32(reader["stokMiktari"]),
                            MinStokLimit = Convert.ToInt32(reader["minStokLimit"]),
                            AlisFiyati = Convert.ToDecimal(reader["alisFiyati"]),
                            SatisFiyati = Convert.ToDecimal(reader["satisFiyati"])
                        });
                    }
                }
            }

            return urunler;
        }
    }
}
