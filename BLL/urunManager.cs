using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StokSatisTakipSistemi.Entities;
using StokSatisTakipSistemi.DAL;

namespace StokSatisTakipSistemi.BLL
{
    public class urunManager
    {
        private readonly string connStr = "Server=172.21.54.253;Database=26_132430054;Uid=26_132430054;Pwd=İnif123.;";
        private readonly UrunRepository urunRepo = new UrunRepository();

        public List<Urun> TumUrunleriGetir()
        {
            if (urunRepo == null) return new List<Urun>();
            return urunRepo.Listele() ?? new List<Urun>();
        }

        public bool StokDus(int urunId, int adet)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE urunler SET StokMiktari = StokMiktari - @adet WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@adet", adet);
                        cmd.Parameters.AddWithValue("@id", urunId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool UrunEkle(Urun urun)
        {
            if (urun == null) return false;

            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                try
                {
                    baglanti.Open();

                    string sql =
                        "INSERT INTO urunler (UrunAdi, StokMiktari, MinStokLimit, AlisFiyati, SatisFiyati) " +
                        "VALUES (@ad, @stok, @min, @alis, @satis)";

                    using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", urun.UrunAdi);
                        komut.Parameters.AddWithValue("@stok", urun.StokMiktari);
                        komut.Parameters.AddWithValue("@min", urun.MinStokLimit);
                        komut.Parameters.AddWithValue("@alis", urun.AlisFiyati);
                        komut.Parameters.AddWithValue("@satis", urun.SatisFiyati);

                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Sil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                try
                {
                    baglanti.Open();

                    using (MySqlCommand komut = new MySqlCommand("DELETE FROM urunler WHERE Id = @id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", id);
                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Guncelle(Urun urun)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                try
                {
                    baglanti.Open();

                    string sql =
                        "UPDATE urunler SET " +
                        "UrunAdi = @ad, " +
                        "StokMiktari = @stok, " +
                        "MinStokLimit = @min, " +
                        "AlisFiyati = @alis, " +
                        "SatisFiyati = @satis " +
                        "WHERE Id = @id";

                    using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", urun.UrunAdi);
                        komut.Parameters.AddWithValue("@stok", urun.StokMiktari);
                        komut.Parameters.AddWithValue("@min", urun.MinStokLimit);
                        komut.Parameters.AddWithValue("@alis", urun.AlisFiyati);
                        komut.Parameters.AddWithValue("@satis", urun.SatisFiyati);
                        komut.Parameters.AddWithValue("@id", urun.Id);

                        return komut.ExecuteNonQuery() > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public int SatisKaydet(int musteriId, decimal tutar)
        {
            string connStr = "Server=172.21.54.253;Database=26_132430054;Uid=26_132430054;Pwd=İnif123.;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO satis (musteriId, toplamTutar, satisTarihi) VALUES (@musteriId, @tutar, @tarih)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@musteriId", musteriId);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc <= 0) return 0;

                MySqlCommand idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                return Convert.ToInt32(idCmd.ExecuteScalar());
            }
        }

        public bool SatisDetayKaydet(int satisId, int urunId, int miktar, decimal birimFiyat)
        {
            string connStr = "Server=172.21.54.253;Database=26_132430054;Uid=26_132430054;Pwd=İnif123.;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO satisDetay (satisId, urunId, miktar, birimFiyat) VALUES (@satisId, @urunId, @miktar, @birimFiyat)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@satisId", satisId);
                cmd.Parameters.AddWithValue("@urunId", urunId);
                cmd.Parameters.AddWithValue("@miktar", miktar);
                cmd.Parameters.AddWithValue("@birimFiyat", birimFiyat);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int SatisSayisiniGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM satis WHERE DATE(satisTarihi) = CURDATE()", conn))
                    {
                        object sonuc = cmd.ExecuteScalar();
                        return sonuc == null || sonuc == DBNull.Value ? 0 : Convert.ToInt32(sonuc);
                    }
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
