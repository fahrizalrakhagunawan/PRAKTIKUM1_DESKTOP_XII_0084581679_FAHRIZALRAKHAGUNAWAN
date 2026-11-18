namespace PRAKTIKUM1_DESKTOP_XII_0084581679_FAHRIZALRAKHAGUNAWAN
{
    partial class FormDashboard
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
            this.labelNamaPetugas = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNamaPetugas
            // 
            this.labelNamaPetugas.AutoSize = true;
            this.labelNamaPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPetugas.Location = new System.Drawing.Point(271, 92);
            this.labelNamaPetugas.Name = "labelNamaPetugas";
            this.labelNamaPetugas.Size = new System.Drawing.Size(133, 24);
            this.labelNamaPetugas.TabIndex = 0;
            this.labelNamaPetugas.Text = "Nama Petugas";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShift.Location = new System.Drawing.Point(270, 127);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(55, 25);
            this.labelShift.TabIndex = 1;
            this.labelShift.Text = "Shift";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(270, 162);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(56, 25);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(713, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelNamaPetugas);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaPetugas;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
    }
}