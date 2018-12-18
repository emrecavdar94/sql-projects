namespace SQL_Project
{
    partial class frmParca
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParcaKodu = new System.Windows.Forms.TextBox();
            this.tbParcaAdi = new System.Windows.Forms.TextBox();
            this.tbIscilik = new System.Windows.Forms.TextBox();
            this.tbParcaTutari = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle/Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parça Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parça Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşçilik Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parça Tutarı";
            // 
            // tbParcaKodu
            // 
            this.tbParcaKodu.Location = new System.Drawing.Point(87, 13);
            this.tbParcaKodu.Name = "tbParcaKodu";
            this.tbParcaKodu.Size = new System.Drawing.Size(150, 20);
            this.tbParcaKodu.TabIndex = 7;
            // 
            // tbParcaAdi
            // 
            this.tbParcaAdi.Location = new System.Drawing.Point(87, 43);
            this.tbParcaAdi.Name = "tbParcaAdi";
            this.tbParcaAdi.Size = new System.Drawing.Size(185, 20);
            this.tbParcaAdi.TabIndex = 8;
            // 
            // tbIscilik
            // 
            this.tbIscilik.Location = new System.Drawing.Point(87, 81);
            this.tbIscilik.Name = "tbIscilik";
            this.tbIscilik.Size = new System.Drawing.Size(185, 20);
            this.tbIscilik.TabIndex = 9;
            // 
            // tbParcaTutari
            // 
            this.tbParcaTutari.Location = new System.Drawing.Point(87, 117);
            this.tbParcaTutari.Name = "tbParcaTutari";
            this.tbParcaTutari.Size = new System.Drawing.Size(185, 20);
            this.tbParcaTutari.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnParcaDoldur_Click);
            // 
            // frmParca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 191);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbParcaTutari);
            this.Controls.Add(this.tbIscilik);
            this.Controls.Add(this.tbParcaAdi);
            this.Controls.Add(this.tbParcaKodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "frmParca";
            this.Text = "frmParca";
            this.Load += new System.EventHandler(this.frmParca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParcaKodu;
        private System.Windows.Forms.TextBox tbParcaAdi;
        private System.Windows.Forms.TextBox tbIscilik;
        private System.Windows.Forms.TextBox tbParcaTutari;
        private System.Windows.Forms.Button button4;
    }
}