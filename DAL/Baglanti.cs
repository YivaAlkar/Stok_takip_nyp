using System;
using MySql.Data.MySqlClient;

namespace StokSatisTakipSistemi.DAL
{
    public class Baglanti
    {
        private static readonly string connectionString =
            "Server=172.21.54.253;Database=26_132430054;User ID=26_132430054;Password=İnif123.;";

        public static MySqlConnection BaglantiAl()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
