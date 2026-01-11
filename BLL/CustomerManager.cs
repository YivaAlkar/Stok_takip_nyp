using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace StokSatisTakipSistemi.BLL
{
    public class CustomerManager
    {
        private readonly string _connStr =
            "Server=172.21.54.253;Database=26_132430054;Uid=26_132430054;Pwd=İnif123.;";

        public DataTable MusterileriGetir()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connStr))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM musteriler", conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public bool MusteriEkle(string ad, string tel)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connStr))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO musteriler (adSoyad, telefon) VALUES (@ad, @tel)", conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@tel", tel);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool MusteriGuncelle(int id, string ad, string tel)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE musteriler SET adSoyad=@ad, telefon=@tel WHERE musteri_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@id", id);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool MusteriSil(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM musteriler WHERE musteri_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
