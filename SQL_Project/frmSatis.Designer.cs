namespace SQL_Project
{
    partial class frmSatis
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
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.tbMusteriTCNo = new System.Windows.Forms.MaskedTextBox();
            this.tbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.btnTCNoDoldur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAdres = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriTelNo = new System.Windows.Forms.Label();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbEPosta = new System.Windows.Forms.TextBox();
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.btnSasiNoDoldur = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.lblMotorNo = new System.Windows.Forms.Label();
            this.tbMotorNo = new System.Windows.Forms.TextBox();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.tbSasiNo = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSatisTutari = new System.Windows.Forms.TextBox();
            this.dtSatis = new System.Windows.Forms.DateTimePicker();
            this.btnSatisDoldur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSatisNo = new System.Windows.Forms.TextBox();
            this.gbKisiselBilgiler.SuspendLayout();
            this.gbAracBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.btnTCNoDoldur);
            this.gbKisiselBilgiler.Controls.Add(this.label1);
            this.gbKisiselBilgiler.Controls.Add(this.label2);
            this.gbKisiselBilgiler.Controls.Add(this.tbSoyad);
            this.gbKisiselBilgiler.Controls.Add(this.tbAd);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbAdres);
            this.gbKisiselBilgiler.Controls.Add(this.tbEPosta);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(10, 11);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(260, 236);
            this.gbKisiselBilgiler.TabIndex = 1;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Müşteri";
            // 
            // tbMusteriTCNo
            // 
            this.tbMusteriTCNo.Location = new System.Drawing.Point(105, 18);
            this.tbMusteriTCNo.Mask = "00000000000";
            this.tbMusteriTCNo.Name = "tbMusteriTCNo";
            this.tbMusteriTCNo.Size = new System.Drawing.Size(118, 20);
            this.tbMusteriTCNo.TabIndex = 16;
            this.tbMusteriTCNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbMusteriTCNo_MaskInputRejected);
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(106, 97);
            this.tbTelNo.Mask = "+\\9\\0(000) 000 0000";
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(148, 20);
            this.tbTelNo.TabIndex = 16;
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(229, 18);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnTCNoDoldur.TabIndex = 4;
            this.btnTCNoDoldur.Tag = "";
            this.btnTCNoDoldur.Text = "...";
            this.btnTCNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCNoDoldur.UseVisualStyleBackColor = true;
            this.btnTCNoDoldur.Click += new System.EventHandler(this.btnTCNoDoldur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adı";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(106, 71);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbSoyad.TabIndex = 12;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(106, 45);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(148, 20);
            this.tbAd.TabIndex = 11;
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Location = new System.Drawing.Point(6, 152);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(71, 13);
            this.lblMusteriAdres.TabIndex = 10;
            this.lblMusteriAdres.Text = "Müşteri Adres";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(6, 126);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(87, 13);
            this.lblMusteriEPosta.TabIndex = 9;
            this.lblMusteriEPosta.Text = "Müşteri E - Posta";
            // 
            // lblMusteriTelNo
            // 
            this.lblMusteriTelNo.AutoSize = true;
            this.lblMusteriTelNo.Location = new System.Drawing.Point(6, 100);
            this.lblMusteriTelNo.Name = "lblMusteriTelNo";
            this.lblMusteriTelNo.Size = new System.Drawing.Size(76, 13);
            this.lblMusteriTelNo.TabIndex = 8;
            this.lblMusteriTelNo.Text = "Müşteri Tel No";
            // 
            // lblMusteriTCNo
            // 
            this.lblMusteriTCNo.AutoSize = true;
            this.lblMusteriTCNo.Location = new System.Drawing.Point(6, 22);
            this.lblMusteriTCNo.Name = "lblMusteriTCNo";
            this.lblMusteriTCNo.Size = new System.Drawing.Size(98, 13);
            this.lblMusteriTCNo.TabIndex = 7;
            this.lblMusteriTCNo.Text = "TC Kimlik Numarası";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(106, 149);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(148, 72);
            this.tbAdres.TabIndex = 6;
            // 
            // tbEPosta
            // 
            this.tbEPosta.Location = new System.Drawing.Point(106, 123);
            this.tbEPosta.Name = "tbEPosta";
            this.tbEPosta.Size = new System.Drawing.Size(148, 20);
            this.tbEPosta.TabIndex = 5;
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.label4);
            this.gbAracBilgileri.Controls.Add(this.tbRenk);
            this.gbAracBilgileri.Controls.Add(this.btnSasiNoDoldur);
            this.gbAracBilgileri.Controls.Add(this.lblModel);
            this.gbAracBilgileri.Controls.Add(this.tbModel);
            this.gbAracBilgileri.Controls.Add(this.lblMarka);
            this.gbAracBilgileri.Controls.Add(this.tbMarka);
            this.gbAracBilgileri.Controls.Add(this.lblPlaka);
            this.gbAracBilgileri.Controls.Add(this.tbPlaka);
            this.gbAracBilgileri.Controls.Add(this.lblMotorNo);
            this.gbAracBilgileri.Controls.Add(this.tbMotorNo);
            this.gbAracBilgileri.Controls.Add(this.lblSasiNo);
            this.gbAracBilgileri.Controls.Add(this.tbSasiNo);
            this.gbAracBilgileri.Location = new System.Drawing.Point(276, 11);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(260, 236);
            this.gbAracBilgileri.TabIndex = 2;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Renk";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(106, 149);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(148, 20);
            this.tbRenk.TabIndex = 16;
            // 
            // btnSasiNoDoldur
            // 
            this.btnSasiNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSasiNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSasiNoDoldur.Location = new System.Drawing.Point(230, 18);
            this.btnSasiNoDoldur.Name = "btnSasiNoDoldur";
            this.btnSasiNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnSasiNoDoldur.TabIndex = 15;
            this.btnSasiNoDoldur.Tag = "";
            this.btnSasiNoDoldur.Text = "...";
            this.btnSasiNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSasiNoDoldur.UseVisualStyleBackColor = true;
            this.btnSasiNoDoldur.Click += new System.EventHandler(this.btnSasiNoDoldur_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 126);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(106, 123);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(148, 20);
            this.tbModel.TabIndex = 8;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 100);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(106, 97);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(148, 20);
            this.tbMarka.TabIndex = 6;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(12, 74);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 5;
            this.lblPlaka.Text = "Plaka";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(106, 71);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(148, 20);
            this.tbPlaka.TabIndex = 4;
            // 
            // lblMotorNo
            // 
            this.lblMotorNo.AutoSize = true;
            this.lblMotorNo.Location = new System.Drawing.Point(12, 48);
            this.lblMotorNo.Name = "lblMotorNo";
            this.lblMotorNo.Size = new System.Drawing.Size(51, 13);
            this.lblMotorNo.TabIndex = 3;
            this.lblMotorNo.Text = "Motor No";
            // 
            // tbMotorNo
            // 
            this.tbMotorNo.Location = new System.Drawing.Point(106, 45);
            this.tbMotorNo.Name = "tbMotorNo";
            this.tbMotorNo.Size = new System.Drawing.Size(148, 20);
            this.tbMotorNo.TabIndex = 2;
            // 
            // lblSasiNo
            // 
            this.lblSasiNo.AutoSize = true;
            this.lblSasiNo.Location = new System.Drawing.Point(12, 22);
            this.lblSasiNo.Name = "lblSasiNo";
            this.lblSasiNo.Size = new System.Drawing.Size(44, 13);
            this.lblSasiNo.TabIndex = 1;
            this.lblSasiNo.Text = "Şasi No";
            // 
            // tbSasiNo
            // 
            this.tbSasiNo.Location = new System.Drawing.Point(106, 19);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(119, 20);
            this.tbSasiNo.TabIndex = 0;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(324, 29);
            this.btnSatisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(125, 33);
            this.btnSatisYap.TabIndex = 3;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.tbSatisTutari);
            this.groupBox1.Controls.Add(this.dtSatis);
            this.groupBox1.Controls.Add(this.btnSatisDoldur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSatisNo);
            this.groupBox1.Location = new System.Drawing.Point(10, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Fatura Bas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Satış Tutarı";
            // 
            // tbSatisTutari
            // 
            this.tbSatisTutari.Location = new System.Drawing.Point(105, 82);
            this.tbSatisTutari.Name = "tbSatisTutari";
            this.tbSatisTutari.Size = new System.Drawing.Size(148, 20);
            this.tbSatisTutari.TabIndex = 20;
            // 
            // dtSatis
            // 
            this.dtSatis.Location = new System.Drawing.Point(105, 49);
            this.dtSatis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtSatis.Name = "dtSatis";
            this.dtSatis.Size = new System.Drawing.Size(148, 20);
            this.dtSatis.TabIndex = 15;
            // 
            // btnSatisDoldur
            // 
            this.btnSatisDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSatisDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisDoldur.Location = new System.Drawing.Point(228, 19);
            this.btnSatisDoldur.Name = "btnSatisDoldur";
            this.btnSatisDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnSatisDoldur.TabIndex = 4;
            this.btnSatisDoldur.Tag = "";
            this.btnSatisDoldur.Text = "...";
            this.btnSatisDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisDoldur.UseVisualStyleBackColor = true;
            this.btnSatisDoldur.Click += new System.EventHandler(this.btnSatisDoldur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Satış Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Satış Numarası";
            // 
            // tbSatisNo
            // 
            this.tbSatisNo.Location = new System.Drawing.Point(106, 19);
            this.tbSatisNo.Name = "tbSatisNo";
            this.tbSatisNo.Size = new System.Drawing.Size(117, 20);
            this.tbSatisNo.TabIndex = 3;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAracBilgileri);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label lblMusteriAdres;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriTelNo;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbEPosta;
        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.Label lblMotorNo;
        private System.Windows.Forms.TextBox tbMotorNo;
        private System.Windows.Forms.Label lblSasiNo;
        private System.Windows.Forms.TextBox tbSasiNo;
        private System.Windows.Forms.Button btnTCNoDoldur;
        private System.Windows.Forms.Button btnSasiNoDoldur;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSatisTutari;
        private System.Windows.Forms.DateTimePicker dtSatis;
        private System.Windows.Forms.Button btnSatisDoldur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSatisNo;
        private System.Windows.Forms.MaskedTextBox tbTelNo;
        private System.Windows.Forms.MaskedTextBox tbMusteriTCNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRenk;
        private System.Windows.Forms.Button button1;
    }
}