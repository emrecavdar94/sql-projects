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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.btnTCNoDoldur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.tbMusteriTCNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.btnArabaGetir = new System.Windows.Forms.Button();
            this.chckAraba = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersonelAd = new System.Windows.Forms.TextBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelEncokSatisYapan = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbKisiselBilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.btnMusteriGetir);
            this.gbKisiselBilgiler.Controls.Add(this.btnTCNoDoldur);
            this.gbKisiselBilgiler.Controls.Add(this.label2);
            this.gbKisiselBilgiler.Controls.Add(this.label3);
            this.gbKisiselBilgiler.Controls.Add(this.tbSoyad);
            this.gbKisiselBilgiler.Controls.Add(this.tbAd);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTCNo);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(82, 13);
            this.gbKisiselBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(347, 290);
            this.gbKisiselBilgiler.TabIndex = 3;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Müşteri";
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(304, 20);
            this.btnTCNoDoldur.Margin = new System.Windows.Forms.Padding(4);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(33, 25);
            this.btnTCNoDoldur.TabIndex = 4;
            this.btnTCNoDoldur.Tag = "";
            this.btnTCNoDoldur.Text = "...";
            this.btnTCNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCNoDoldur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adı";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(141, 87);
            this.tbSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(196, 22);
            this.tbSoyad.TabIndex = 12;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(141, 55);
            this.tbAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(196, 22);
            this.tbAd.TabIndex = 11;
            // 
            // lblMusteriTCNo
            // 
            this.lblMusteriTCNo.AutoSize = true;
            this.lblMusteriTCNo.Location = new System.Drawing.Point(8, 27);
            this.lblMusteriTCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTCNo.Name = "lblMusteriTCNo";
            this.lblMusteriTCNo.Size = new System.Drawing.Size(130, 17);
            this.lblMusteriTCNo.TabIndex = 7;
            this.lblMusteriTCNo.Text = "TC Kimlik Numarası";
            // 
            // tbMusteriTCNo
            // 
            this.tbMusteriTCNo.Location = new System.Drawing.Point(141, 23);
            this.tbMusteriTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMusteriTCNo.Name = "tbMusteriTCNo";
            this.tbMusteriTCNo.Size = new System.Drawing.Size(155, 22);
            this.tbMusteriTCNo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.chckAraba);
            this.groupBox1.Controls.Add(this.btnArabaGetir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRenk);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMarka);
            this.groupBox1.Location = new System.Drawing.Point(479, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Model";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(141, 87);
            this.tbRenk.Margin = new System.Windows.Forms.Padding(4);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(196, 22);
            this.tbRenk.TabIndex = 12;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(141, 55);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(196, 22);
            this.tbModel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(141, 23);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(196, 22);
            this.tbMarka.TabIndex = 3;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(127, 200);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(86, 59);
            this.btnMusteriGetir.TabIndex = 15;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // btnArabaGetir
            // 
            this.btnArabaGetir.Location = new System.Drawing.Point(130, 202);
            this.btnArabaGetir.Name = "btnArabaGetir";
            this.btnArabaGetir.Size = new System.Drawing.Size(75, 57);
            this.btnArabaGetir.TabIndex = 15;
            this.btnArabaGetir.Text = "Arabaları Getir";
            this.btnArabaGetir.UseVisualStyleBackColor = true;
            // 
            // chckAraba
            // 
            this.chckAraba.AutoSize = true;
            this.chckAraba.Location = new System.Drawing.Point(68, 145);
            this.chckAraba.Name = "chckAraba";
            this.chckAraba.Size = new System.Drawing.Size(211, 21);
            this.chckAraba.TabIndex = 16;
            this.chckAraba.Text = "Satışı Yapılan Arabaları Getir";
            this.chckAraba.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnPersonelEncokSatisYapan);
            this.groupBox2.Controls.Add(this.btnPersonelGetir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPersonelSoyad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbPersonelAd);
            this.groupBox2.Location = new System.Drawing.Point(849, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(347, 290);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soyadı";
            // 
            // tbPersonelSoyad
            // 
            this.tbPersonelSoyad.Location = new System.Drawing.Point(141, 55);
            this.tbPersonelSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbPersonelSoyad.Name = "tbPersonelSoyad";
            this.tbPersonelSoyad.Size = new System.Drawing.Size(196, 22);
            this.tbPersonelSoyad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adı";
            // 
            // tbPersonelAd
            // 
            this.tbPersonelAd.Location = new System.Drawing.Point(141, 23);
            this.tbPersonelAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbPersonelAd.Name = "tbPersonelAd";
            this.tbPersonelAd.Size = new System.Drawing.Size(196, 22);
            this.tbPersonelAd.TabIndex = 3;
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(11, 202);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(107, 57);
            this.btnPersonelGetir.TabIndex = 15;
            this.btnPersonelGetir.Text = "Personelleri Listele";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // btnPersonelEncokSatisYapan
            // 
            this.btnPersonelEncokSatisYapan.Location = new System.Drawing.Point(166, 202);
            this.btnPersonelEncokSatisYapan.Name = "btnPersonelEncokSatisYapan";
            this.btnPersonelEncokSatisYapan.Size = new System.Drawing.Size(144, 59);
            this.btnPersonelEncokSatisYapan.TabIndex = 16;
            this.btnPersonelEncokSatisYapan.Text = "En Çok Satış Yapan Personeller";
            this.btnPersonelEncokSatisYapan.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(920, 364);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(192, 63);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.Text = "Excel Olarak Dışarı Aktar";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(920, 537);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(192, 63);
            this.btnYazdir.TabIndex = 19;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 640);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.Button btnTCNoDoldur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.TextBox tbMusteriTCNo;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckAraba;
        private System.Windows.Forms.Button btnArabaGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRenk;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPersonelEncokSatisYapan;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPersonelSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPersonelAd;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnYazdir;
    }
}