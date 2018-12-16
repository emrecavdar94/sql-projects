namespace SQL_Project
{
    partial class frmYetkiler
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
            this.lbPersonel = new System.Windows.Forms.ListBox();
            this.lbYetkiler = new System.Windows.Forms.ListBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.btnYetkiSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPersonel
            // 
            this.lbPersonel.FormattingEnabled = true;
            this.lbPersonel.ItemHeight = 16;
            this.lbPersonel.Location = new System.Drawing.Point(33, 30);
            this.lbPersonel.Name = "lbPersonel";
            this.lbPersonel.Size = new System.Drawing.Size(332, 308);
            this.lbPersonel.TabIndex = 0;
            this.lbPersonel.SelectedIndexChanged += new System.EventHandler(this.lbPersonel_SelectedIndexChanged);
            // 
            // lbYetkiler
            // 
            this.lbYetkiler.FormattingEnabled = true;
            this.lbYetkiler.ItemHeight = 16;
            this.lbYetkiler.Location = new System.Drawing.Point(415, 30);
            this.lbYetkiler.Name = "lbYetkiler";
            this.lbYetkiler.Size = new System.Drawing.Size(332, 308);
            this.lbYetkiler.TabIndex = 1;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(33, 345);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 31);
            this.btnPersonelEkle.TabIndex = 2;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(129, 345);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(75, 31);
            this.btnPersonelSil.TabIndex = 3;
            this.btnPersonelSil.Text = "Çıkar";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.Location = new System.Drawing.Point(415, 345);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(75, 31);
            this.btnYetkiEkle.TabIndex = 4;
            this.btnYetkiEkle.Text = "Ekle";
            this.btnYetkiEkle.UseVisualStyleBackColor = true;
            // 
            // btnYetkiSil
            // 
            this.btnYetkiSil.Location = new System.Drawing.Point(510, 345);
            this.btnYetkiSil.Name = "btnYetkiSil";
            this.btnYetkiSil.Size = new System.Drawing.Size(75, 31);
            this.btnYetkiSil.TabIndex = 5;
            this.btnYetkiSil.Text = "Çıkar";
            this.btnYetkiSil.UseVisualStyleBackColor = true;
            this.btnYetkiSil.Click += new System.EventHandler(this.btnYetkiSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personeller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yetkiler";
            // 
            // frmYetkiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYetkiSil);
            this.Controls.Add(this.btnYetkiEkle);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.lbYetkiler);
            this.Controls.Add(this.lbPersonel);
            this.Name = "frmYetkiler";
            this.Text = "frmYetkiler";
            this.Load += new System.EventHandler(this.frmYetkiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersonel;
        private System.Windows.Forms.ListBox lbYetkiler;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.Button btnYetkiSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}