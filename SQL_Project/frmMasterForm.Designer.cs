namespace SQL_Project
{
    partial class frmMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterForm));
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnServis = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.lblMasterKarsilama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatis
            // 
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(36, 60);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(130, 100);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "SATIŞ";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnServis
            // 
            this.btnServis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServis.Location = new System.Drawing.Point(219, 60);
            this.btnServis.Margin = new System.Windows.Forms.Padding(2);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(130, 100);
            this.btnServis.TabIndex = 3;
            this.btnServis.Text = "SERVİS";
            this.btnServis.UseVisualStyleBackColor = true;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // btnYonetim
            // 
            this.btnYonetim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetim.Location = new System.Drawing.Point(219, 202);
            this.btnYonetim.Margin = new System.Windows.Forms.Padding(2);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(130, 100);
            this.btnYonetim.TabIndex = 5;
            this.btnYonetim.Text = "YÖNETİM";
            this.btnYonetim.UseVisualStyleBackColor = true;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Location = new System.Drawing.Point(36, 202);
            this.btnRaporlar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(130, 100);
            this.btnRaporlar.TabIndex = 4;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // lblMasterKarsilama
            // 
            this.lblMasterKarsilama.AutoSize = true;
            this.lblMasterKarsilama.Location = new System.Drawing.Point(175, 23);
            this.lblMasterKarsilama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasterKarsilama.Name = "lblMasterKarsilama";
            this.lblMasterKarsilama.Size = new System.Drawing.Size(35, 13);
            this.lblMasterKarsilama.TabIndex = 6;
            this.lblMasterKarsilama.Text = "label1";
            // 
            // frmMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.lblMasterKarsilama);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnServis);
            this.Controls.Add(this.btnSatis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Satış";
            this.Load += new System.EventHandler(this.frmMasterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btnYonetim;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Label lblMasterKarsilama;
    }
}

