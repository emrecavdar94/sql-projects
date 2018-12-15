namespace SQL_Project
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnCikis);
            this.pnlLogin.Controls.Add(this.pbLogin);
            this.pnlLogin.Controls.Add(this.btnGiris);
            this.pnlLogin.Controls.Add(this.lblParola);
            this.pnlLogin.Controls.Add(this.lblKullaniciAdi);
            this.pnlLogin.Controls.Add(this.tbParola);
            this.pnlLogin.Controls.Add(this.tbKullaniciAdi);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(284, 262);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(249, -1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(36, 36);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(80, 0);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(130, 130);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 5;
            this.pbLogin.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(117, 216);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(50, 30);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(55, 188);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(55, 147);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // tbParola
            // 
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbParola.Location = new System.Drawing.Point(130, 184);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(100, 26);
            this.tbParola.TabIndex = 1;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciAdi.Location = new System.Drawing.Point(130, 143);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(100, 26);
            this.tbKullaniciAdi.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Button btnCikis;
    }
}