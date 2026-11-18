using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM1_DESKTOP_XII_0084581679_FAHRIZALRAKHAGUNAWAN
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            //Validasi field wajib diisi
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field wajib diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama_petugas, shift, role, status_aktif FROM tb_apoteker WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            //Cek apakah data sesuai
                            if (!reader.Read())
                            {
                                MessageBox.Show("Username atau password yang anda masukkan tidak sesuai !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            int statusAktif = Convert.ToInt32(reader["status_aktif"]);

                            //Cek apakah akun berstatus nonaktif (status_aktif = 0)
                            if (statusAktif == 0)
                            {
                                MessageBox.Show("Akun petugas Anda sedang dinonaktifkan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            //Simpan identitas petugas ke sesi aktif
                            UserSession.IsLoggedIn = true;
                            UserSession.NamaPetugas = reader["nama_petugas"].ToString();
                            UserSession.Shift = reader["shift"].ToString();
                            UserSession.Role = reader["role"].ToString();
                        }
                    }

                    //Buka FormDashboard dan tutup/sembunyikan FormLogin
                    FormDashboard dashboard = new FormDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }
    }
}