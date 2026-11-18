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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string nama = textBoxNamaPetugas.Text.Trim();
            string username = textBoxUsername1.Text.Trim();
            string password = textBoxPassword1.Text;
            string konfirmasi = textBoxKonfirmasiPassword.Text;
            string shift = comboBoxShift.Text.Trim();
            string role = comboBoxRole.Text.Trim();

            //Validasi semua field wajib diisi
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(konfirmasi) ||
                string.IsNullOrEmpty(shift) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Semua field wajib diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validasi kesesuaian kata sandi dan konfirmasi kata sandi
            if (password != konfirmasi)
            {
                MessageBox.Show("Konfirmasi password tidak sesuai !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validasi panjang minimal 6 karakter & wajib mengandung kombinasi angka
            if (password.Length < 6 || !password.Any(char.IsDigit))
            {
                MessageBox.Show("Password minimal 6 karakter dan wajib mengandung angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    //Cek duplikasi username di database
                    string queryCek = "SELECT COUNT(*) FROM tb_apoteker WHERE username = @username";
                    using (MySqlCommand cmdCek = new MySqlCommand(queryCek, conn))
                    {
                        cmdCek.Parameters.AddWithValue("@username", username);
                        int jumlah = Convert.ToInt32(cmdCek.ExecuteScalar());

                        if (jumlah > 0)
                        {
                            MessageBox.Show("Username sudah digunakan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    //Simpan data ke database dengan status_aktif = 1 otomatis
                    string queryInsert = "INSERT INTO tb_apoteker (username, password, nama_petugas, shift, role, status_aktif) " +
                                         "VALUES (@username, @password, @nama, @shift, @role, 1)";
                    using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@username", username);
                        cmdInsert.Parameters.AddWithValue("@password", password);
                        cmdInsert.Parameters.AddWithValue("@nama", nama);
                        cmdInsert.Parameters.AddWithValue("@shift", shift);
                        cmdInsert.Parameters.AddWithValue("@role", role);
                        cmdInsert.ExecuteNonQuery();
                    }

                    //Informasi berhasil dan kembali ke FormLogin
                    MessageBox.Show("Registrasi petugas apotek berhasil !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormLogin login = new FormLogin();
                    login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
