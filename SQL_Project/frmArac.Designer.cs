namespace SQL_Project
{
    partial class frmArac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArac));
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMotorNo = new System.Windows.Forms.Label();
            this.tbMotorNo = new System.Windows.Forms.TextBox();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.tbSasiNo = new System.Windows.Forms.TextBox();
            this.tbPlaka = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.gbAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.label1);
            this.gbAracBilgileri.Controls.Add(this.tbRenk);
            this.gbAracBilgileri.Controls.Add(this.tbPlaka);
            this.gbAracBilgileri.Controls.Add(this.btnEkle);
            this.gbAracBilgileri.Controls.Add(this.lblModel);
            this.gbAracBilgileri.Controls.Add(this.tbModel);
            this.gbAracBilgileri.Controls.Add(this.lblMarka);
            this.gbAracBilgileri.Controls.Add(this.tbMarka);
            this.gbAracBilgileri.Controls.Add(this.lblPlaka);
            this.gbAracBilgileri.Controls.Add(this.lblMotorNo);
            this.gbAracBilgileri.Controls.Add(this.tbMotorNo);
            this.gbAracBilgileri.Controls.Add(this.lblSasiNo);
            this.gbAracBilgileri.Controls.Add(this.tbSasiNo);
            this.gbAracBilgileri.Location = new System.Drawing.Point(0, 0);
            this.gbAracBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.gbAracBilgileri.Size = new System.Drawing.Size(381, 277);
            this.gbAracBilgileri.TabIndex = 0;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(252, 212);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 155);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(141, 151);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(196, 22);
            this.tbModel.TabIndex = 8;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(16, 123);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(141, 119);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(196, 22);
            this.tbMarka.TabIndex = 6;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(16, 91);
            this.lblPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(43, 17);
            this.lblPlaka.TabIndex = 5;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblMotorNo
            // 
            this.lblMotorNo.AutoSize = true;
            this.lblMotorNo.Location = new System.Drawing.Point(16, 59);
            this.lblMotorNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotorNo.Name = "lblMotorNo";
            this.lblMotorNo.Size = new System.Drawing.Size(66, 17);
            this.lblMotorNo.TabIndex = 3;
            this.lblMotorNo.Text = "Motor No";
            // 
            // tbMotorNo
            // 
            this.tbMotorNo.Location = new System.Drawing.Point(141, 55);
            this.tbMotorNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMotorNo.Name = "tbMotorNo";
            this.tbMotorNo.Size = new System.Drawing.Size(196, 22);
            this.tbMotorNo.TabIndex = 2;
            // 
            // lblSasiNo
            // 
            this.lblSasiNo.AutoSize = true;
            this.lblSasiNo.Location = new System.Drawing.Point(16, 27);
            this.lblSasiNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSasiNo.Name = "lblSasiNo";
            this.lblSasiNo.Size = new System.Drawing.Size(57, 17);
            this.lblSasiNo.TabIndex = 1;
            this.lblSasiNo.Text = "Şasi No";
            // 
            // tbSasiNo
            // 
            this.tbSasiNo.Location = new System.Drawing.Point(141, 23);
            this.tbSasiNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(196, 22);
            this.tbSasiNo.TabIndex = 0;
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(141, 90);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(196, 22);
            this.tbPlaka.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Renk";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(141, 181);
            this.tbRenk.Margin = new System.Windows.Forms.Padding(4);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(196, 22);
            this.tbRenk.TabIndex = 11;
            // 
            // frmArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 290);
            this.Controls.Add(this.gbAracBilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç";
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.TextBox tbSasiNo;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMotorNo;
        private System.Windows.Forms.TextBox tbMotorNo;
        private System.Windows.Forms.Label lblSasiNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox tbPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRenk;
    }
}