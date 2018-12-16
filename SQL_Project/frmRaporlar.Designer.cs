namespace SQL_Project
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            this.dgVeriler = new System.Windows.Forms.DataGridView();
            this.gbRaporMusteriler = new System.Windows.Forms.GroupBox();
            this.mtbMusteriTCNo = new System.Windows.Forms.MaskedTextBox();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.lblMusterSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.tbMusteriSoyad = new System.Windows.Forms.TextBox();
            this.tbMusteriAd = new System.Windows.Forms.TextBox();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.gbRaporAraba = new System.Windows.Forms.GroupBox();
            this.rbTumArabalar = new System.Windows.Forms.RadioButton();
            this.rbSatilmamisAraba = new System.Windows.Forms.RadioButton();
            this.btnArabaGetir = new System.Windows.Forms.Button();
            this.rbSatilmisAraba = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.gbRaporPersonel = new System.Windows.Forms.GroupBox();
            this.btnPersonelEncokSatisYapan = new System.Windows.Forms.Button();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersonelAd = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).BeginInit();
            this.gbRaporMusteriler.SuspendLayout();
            this.gbRaporAraba.SuspendLayout();
            this.gbRaporPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVeriler
            // 
            this.dgVeriler.AllowUserToResizeColumns = false;
            this.dgVeriler.AllowUserToResizeRows = false;
            this.dgVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeriler.Location = new System.Drawing.Point(0, 253);
            this.dgVeriler.Margin = new System.Windows.Forms.Padding(2);
            this.dgVeriler.Name = "dgVeriler";
            this.dgVeriler.ReadOnly = true;
            this.dgVeriler.RowTemplate.Height = 24;
            this.dgVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVeriler.Size = new System.Drawing.Size(656, 257);
            this.dgVeriler.TabIndex = 0;
            // 
            // gbRaporMusteriler
            // 
            this.gbRaporMusteriler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbRaporMusteriler.Controls.Add(this.mtbMusteriTCNo);
            this.gbRaporMusteriler.Controls.Add(this.btnMusteriGetir);
            this.gbRaporMusteriler.Controls.Add(this.lblMusterSoyad);
            this.gbRaporMusteriler.Controls.Add(this.lblMusteriAd);
            this.gbRaporMusteriler.Controls.Add(this.tbMusteriSoyad);
            this.gbRaporMusteriler.Controls.Add(this.tbMusteriAd);
            this.gbRaporMusteriler.Controls.Add(this.lblMusteriTCNo);
            this.gbRaporMusteriler.Location = new System.Drawing.Point(12, 12);
            this.gbRaporMusteriler.Name = "gbRaporMusteriler";
            this.gbRaporMusteriler.Size = new System.Drawing.Size(260, 236);
            this.gbRaporMusteriler.TabIndex = 3;
            this.gbRaporMusteriler.TabStop = false;
            this.gbRaporMusteriler.Text = "Müşteri";
            // 
            // mtbMusteriTCNo
            // 
            this.mtbMusteriTCNo.Location = new System.Drawing.Point(106, 22);
            this.mtbMusteriTCNo.Mask = "00000000000";
            this.mtbMusteriTCNo.Name = "mtbMusteriTCNo";
            this.mtbMusteriTCNo.Size = new System.Drawing.Size(148, 20);
            this.mtbMusteriTCNo.TabIndex = 16;
            this.mtbMusteriTCNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(98, 176);
            this.btnMusteriGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(64, 46);
            this.btnMusteriGetir.TabIndex = 15;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // lblMusterSoyad
            // 
            this.lblMusterSoyad.AutoSize = true;
            this.lblMusterSoyad.Location = new System.Drawing.Point(6, 74);
            this.lblMusterSoyad.Name = "lblMusterSoyad";
            this.lblMusterSoyad.Size = new System.Drawing.Size(39, 13);
            this.lblMusterSoyad.TabIndex = 14;
            this.lblMusterSoyad.Text = "Soyadı";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(6, 48);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(22, 13);
            this.lblMusteriAd.TabIndex = 13;
            this.lblMusteriAd.Text = "Adı";
            // 
            // tbMusteriSoyad
            // 
            this.tbMusteriSoyad.Location = new System.Drawing.Point(106, 71);
            this.tbMusteriSoyad.Name = "tbMusteriSoyad";
            this.tbMusteriSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbMusteriSoyad.TabIndex = 12;
            // 
            // tbMusteriAd
            // 
            this.tbMusteriAd.Location = new System.Drawing.Point(106, 45);
            this.tbMusteriAd.Name = "tbMusteriAd";
            this.tbMusteriAd.Size = new System.Drawing.Size(148, 20);
            this.tbMusteriAd.TabIndex = 11;
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
            // gbRaporAraba
            // 
            this.gbRaporAraba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbRaporAraba.Controls.Add(this.rbTumArabalar);
            this.gbRaporAraba.Controls.Add(this.rbSatilmamisAraba);
            this.gbRaporAraba.Controls.Add(this.btnArabaGetir);
            this.gbRaporAraba.Controls.Add(this.rbSatilmisAraba);
            this.gbRaporAraba.Controls.Add(this.label1);
            this.gbRaporAraba.Controls.Add(this.label4);
            this.gbRaporAraba.Controls.Add(this.tbRenk);
            this.gbRaporAraba.Controls.Add(this.tbModel);
            this.gbRaporAraba.Controls.Add(this.label8);
            this.gbRaporAraba.Controls.Add(this.tbMarka);
            this.gbRaporAraba.Location = new System.Drawing.Point(278, 12);
            this.gbRaporAraba.Name = "gbRaporAraba";
            this.gbRaporAraba.Size = new System.Drawing.Size(260, 236);
            this.gbRaporAraba.TabIndex = 15;
            this.gbRaporAraba.TabStop = false;
            this.gbRaporAraba.Text = "Araba";
            // 
            // rbTumArabalar
            // 
            this.rbTumArabalar.AutoSize = true;
            this.rbTumArabalar.Location = new System.Drawing.Point(23, 103);
            this.rbTumArabalar.Name = "rbTumArabalar";
            this.rbTumArabalar.Size = new System.Drawing.Size(115, 17);
            this.rbTumArabalar.TabIndex = 22;
            this.rbTumArabalar.TabStop = true;
            this.rbTumArabalar.Text = "Tüm Arabaları Getir";
            this.rbTumArabalar.UseVisualStyleBackColor = true;
            // 
            // rbSatilmamisAraba
            // 
            this.rbSatilmamisAraba.AutoSize = true;
            this.rbSatilmamisAraba.Location = new System.Drawing.Point(23, 126);
            this.rbSatilmamisAraba.Name = "rbSatilmamisAraba";
            this.rbSatilmamisAraba.Size = new System.Drawing.Size(214, 17);
            this.rbSatilmamisAraba.TabIndex = 21;
            this.rbSatilmamisAraba.TabStop = true;
            this.rbSatilmamisAraba.Text = "Sadece Satışı Yapılmamış Arabaları Getir";
            this.rbSatilmamisAraba.UseVisualStyleBackColor = true;
            // 
            // btnArabaGetir
            // 
            this.btnArabaGetir.Location = new System.Drawing.Point(102, 176);
            this.btnArabaGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnArabaGetir.Name = "btnArabaGetir";
            this.btnArabaGetir.Size = new System.Drawing.Size(56, 46);
            this.btnArabaGetir.TabIndex = 15;
            this.btnArabaGetir.Text = "Arabaları Getir";
            this.btnArabaGetir.UseVisualStyleBackColor = true;
            this.btnArabaGetir.Click += new System.EventHandler(this.btnArabaGetir_Click);
            // 
            // rbSatilmisAraba
            // 
            this.rbSatilmisAraba.AutoSize = true;
            this.rbSatilmisAraba.Location = new System.Drawing.Point(23, 149);
            this.rbSatilmisAraba.Name = "rbSatilmisAraba";
            this.rbSatilmisAraba.Size = new System.Drawing.Size(197, 17);
            this.rbSatilmisAraba.TabIndex = 20;
            this.rbSatilmisAraba.TabStop = true;
            this.rbSatilmisAraba.Text = "Sadece Satışı Yapılan Arabaları Getir";
            this.rbSatilmisAraba.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Model";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(106, 71);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(148, 20);
            this.tbRenk.TabIndex = 12;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(106, 45);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(148, 20);
            this.tbModel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(106, 19);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(148, 20);
            this.tbMarka.TabIndex = 3;
            // 
            // gbRaporPersonel
            // 
            this.gbRaporPersonel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbRaporPersonel.Controls.Add(this.btnPersonelEncokSatisYapan);
            this.gbRaporPersonel.Controls.Add(this.btnPersonelGetir);
            this.gbRaporPersonel.Controls.Add(this.label6);
            this.gbRaporPersonel.Controls.Add(this.tbPersonelSoyad);
            this.gbRaporPersonel.Controls.Add(this.label7);
            this.gbRaporPersonel.Controls.Add(this.tbPersonelAd);
            this.gbRaporPersonel.Location = new System.Drawing.Point(544, 12);
            this.gbRaporPersonel.Name = "gbRaporPersonel";
            this.gbRaporPersonel.Size = new System.Drawing.Size(260, 236);
            this.gbRaporPersonel.TabIndex = 17;
            this.gbRaporPersonel.TabStop = false;
            this.gbRaporPersonel.Text = "Personel";
            // 
            // btnPersonelEncokSatisYapan
            // 
            this.btnPersonelEncokSatisYapan.Location = new System.Drawing.Point(118, 176);
            this.btnPersonelEncokSatisYapan.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelEncokSatisYapan.Name = "btnPersonelEncokSatisYapan";
            this.btnPersonelEncokSatisYapan.Size = new System.Drawing.Size(108, 46);
            this.btnPersonelEncokSatisYapan.TabIndex = 16;
            this.btnPersonelEncokSatisYapan.Text = "En Çok Satış Yapan Personeller";
            this.btnPersonelEncokSatisYapan.UseVisualStyleBackColor = true;
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(34, 176);
            this.btnPersonelGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(80, 46);
            this.btnPersonelGetir.TabIndex = 15;
            this.btnPersonelGetir.Text = "Personelleri Listele";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soyadı";
            // 
            // tbPersonelSoyad
            // 
            this.tbPersonelSoyad.Location = new System.Drawing.Point(106, 45);
            this.tbPersonelSoyad.Name = "tbPersonelSoyad";
            this.tbPersonelSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelSoyad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adı";
            // 
            // tbPersonelAd
            // 
            this.tbPersonelAd.Location = new System.Drawing.Point(106, 19);
            this.tbPersonelAd.Name = "tbPersonelAd";
            this.tbPersonelAd.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelAd.TabIndex = 3;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(660, 295);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(144, 51);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.Text = "Excel Olarak Dışarı Aktar";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(660, 435);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(144, 51);
            this.btnYazdir.TabIndex = 19;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 510);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.gbRaporPersonel);
            this.Controls.Add(this.gbRaporAraba);
            this.Controls.Add(this.gbRaporMusteriler);
            this.Controls.Add(this.dgVeriler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPOR";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).EndInit();
            this.gbRaporMusteriler.ResumeLayout(false);
            this.gbRaporMusteriler.PerformLayout();
            this.gbRaporAraba.ResumeLayout(false);
            this.gbRaporAraba.PerformLayout();
            this.gbRaporPersonel.ResumeLayout(false);
            this.gbRaporPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVeriler;
        private System.Windows.Forms.GroupBox gbRaporMusteriler;
        private System.Windows.Forms.Label lblMusterSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox tbMusteriSoyad;
        private System.Windows.Forms.TextBox tbMusteriAd;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.GroupBox gbRaporAraba;
        private System.Windows.Forms.Button btnArabaGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRenk;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.GroupBox gbRaporPersonel;
        private System.Windows.Forms.Button btnPersonelEncokSatisYapan;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPersonelSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPersonelAd;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.RadioButton rbSatilmisAraba;
        private System.Windows.Forms.RadioButton rbSatilmamisAraba;
        private System.Windows.Forms.RadioButton rbTumArabalar;
        private System.Windows.Forms.MaskedTextBox mtbMusteriTCNo;
    }
}