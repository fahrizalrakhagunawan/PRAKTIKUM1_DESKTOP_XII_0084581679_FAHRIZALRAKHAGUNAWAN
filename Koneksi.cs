using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM1_DESKTOP_XII_0084581679_FAHRIZALRAKHAGUNAWAN
{
    public class Koneksi
    {
        //Sesuaikan server, uid, dan pwd dengan konfigurasi MySQL lokal Anda (XAMPP default: uid=root, pwd kosong)
        private static string connString = "server=localhost;database=db_apotek_petugas;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }

    public static class UserSession
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string NamaPetugas { get; set; }
        public static string Shift { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            IsLoggedIn = false;
            NamaPetugas = string.Empty;
            Shift = string.Empty;
            Role = string.Empty;
        }
    }
}
