namespace PRAKTIKUM1_DESKTOP_XII_0084581679_FAHRIZALRAKHAGUNAWAN
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxKonfirmasiPassword = new System.Windows.Forms.TextBox();
            this.textBoxNamaPetugas = new System.Windows.Forms.TextBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Location = new System.Drawing.Point(231, 127);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(302, 20);
            this.textBoxUsername1.TabIndex = 1;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(231, 169);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(302, 20);
            this.textBoxPassword1.TabIndex = 2;
            // 
            // textBoxKonfirmasiPassword
            // 
            this.textBoxKonfirmasiPassword.Location = new System.Drawing.Point(231, 211);
            this.textBoxKonfirmasiPassword.Name = "textBoxKonfirmasiPassword";
            this.textBoxKonfirmasiPassword.PasswordChar = '*';
            this.textBoxKonfirmasiPassword.Size = new System.Drawing.Size(302, 20);
            this.textBoxKonfirmasiPassword.TabIndex = 3;
            // 
            // textBoxNamaPetugas
            // 
            this.textBoxNamaPetugas.Location = new System.Drawing.Point(231, 85);
            this.textBoxNamaPetugas.Name = "textBoxNamaPetugas";
            this.textBoxNamaPetugas.Size = new System.Drawing.Size(302, 20);
            this.textBoxNamaPetugas.TabIndex = 4;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "Pagi",
            "Siang",
            "Malam"});
            this.comboBoxShift.Location = new System.Drawing.Point(231, 253);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(302, 21);
            this.comboBoxShift.TabIndex = 5;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Apoteker",
            "Asisten Apoteker",
            "Kasir Apotek"});
            this.comboBoxRole.Location = new System.Drawing.Point(231, 295);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(302, 21);
            this.comboBoxRole.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.Location = new System.Drawing.Point(358, 338);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(75, 23);
            this.buttonDaftar.TabIndex = 8;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = true;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(458, 338);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(75, 23);
            this.buttonBatal.TabIndex = 9;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Konfirmasi Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Shift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "REGISTER";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonDaftar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxShift);
            this.Controls.Add(this.textBoxNamaPetugas);
            this.Controls.Add(this.textBoxKonfirmasiPassword);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.textBoxUsername1);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxKonfirmasiPassword;
        private System.Windows.Forms.TextBox textBoxNamaPetugas;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

