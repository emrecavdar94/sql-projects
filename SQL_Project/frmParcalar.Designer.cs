namespace SQL_Project
{
    partial class frmParcalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbParcaKodu = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.tbParcaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgParcalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parça Kodu";
            // 
            // tbParcaKodu
            // 
            this.tbParcaKodu.Location = new System.Drawing.Point(82, 10);
            this.tbParcaKodu.Name = "tbParcaKodu";
            this.tbParcaKodu.Size = new System.Drawing.Size(186, 20);
            this.tbParcaKodu.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(274, 9);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(55, 49);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(254, 258);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgeç.Location = new System.Drawing.Point(16, 258);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(75, 23);
            this.btnVazgeç.TabIndex = 5;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = true;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // tbParcaAdi
            // 
            this.tbParcaAdi.Location = new System.Drawing.Point(82, 36);
            this.tbParcaAdi.Name = "tbParcaAdi";
            this.tbParcaAdi.Size = new System.Drawing.Size(186, 20);
            this.tbParcaAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parça Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parçalar";
            // 
            // dgParcalar
            // 
            this.dgParcalar.AllowUserToAddRows = false;
            this.dgParcalar.AllowUserToDeleteRows = false;
            this.dgParcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParcalar.Location = new System.Drawing.Point(16, 81);
            this.dgParcalar.MultiSelect = false;
            this.dgParcalar.Name = "dgParcalar";
            this.dgParcalar.ReadOnly = true;
            this.dgParcalar.RowHeadersVisible = false;
            this.dgParcalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParcalar.ShowEditingIcon = false;
            this.dgParcalar.Size = new System.Drawing.Size(313, 171);
            this.dgParcalar.TabIndex = 9;
            // 
            // frmParcalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgeç;
            this.ClientSize = new System.Drawing.Size(341, 287);
            this.Controls.Add(this.dgParcalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbParcaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.tbParcaKodu);
            this.Controls.Add(this.label1);
            this.Name = "frmParcalar";
            this.Text = "frmParcalar";
            this.Load += new System.EventHandler(this.frmParcalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgParcalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParcaKodu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.TextBox tbParcaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgParcalar;
    }
}