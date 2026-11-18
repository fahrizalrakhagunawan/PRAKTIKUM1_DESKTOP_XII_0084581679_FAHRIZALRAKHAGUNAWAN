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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void FormDashboard_Load_1(object sender, EventArgs e)
        {
            //Proteksi Akses Form: Cegah pembukaan langsung tanpa otentikasi login
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("Akses ditolak, silakan login terlebih dahulu !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
                return;
            }

            //Memunculkan identitas petugas secara otomatis pada Label
            labelNamaPetugas.Text = UserSession.NamaPetugas;
            labelShift.Text = UserSession.Shift;
            labelRole.Text = UserSession.Role;

        }
    }
}
