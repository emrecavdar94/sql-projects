namespace SQL_Project
{
    partial class frmSistemSabitleri
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
            this.Anahtar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anahtar,
            this.Deger});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(23, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(367, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Anahtar
            // 
            this.Anahtar.HeaderText = "Anahtar";
            this.Anahtar.Name = "Anahtar";
            // 
            // Deger
            // 
            this.Deger.HeaderText = "Değer";
            this.Deger.Name = "Deger";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(23, 271);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 33);
            this.btnSifirla.TabIndex = 1;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(164, 271);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(306, 271);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(75, 33);
            this.btnCik.TabIndex = 3;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            // 
            // frmSistemSabitleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 333);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSistemSabitleri";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anahtar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deger;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCik;
    }
}