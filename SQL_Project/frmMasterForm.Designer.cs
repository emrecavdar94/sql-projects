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
            this.msMasterForm = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnServis = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.lblMasterKarsilama = new System.Windows.Forms.Label();
            this.msMasterForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMasterForm
            // 
            this.msMasterForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.msMasterForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMasterForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.musteriToolStripMenuItem,
            this.aracToolStripMenuItem});
            this.msMasterForm.Location = new System.Drawing.Point(0, 0);
            this.msMasterForm.Name = "msMasterForm";
            this.msMasterForm.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMasterForm.Size = new System.Drawing.Size(736, 28);
            this.msMasterForm.TabIndex = 1;
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.musteriToolStripMenuItem.Text = "Müşteri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // aracToolStripMenuItem
            // 
            this.aracToolStripMenuItem.Name = "aracToolStripMenuItem";
            this.aracToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.aracToolStripMenuItem.Text = "Araç";
            this.aracToolStripMenuItem.Click += new System.EventHandler(this.aracToolStripMenuItem_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(58, 80);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(179, 124);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "SATIŞ";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnServis
            // 
            this.btnServis.Location = new System.Drawing.Point(303, 80);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(180, 124);
            this.btnServis.TabIndex = 3;
            this.btnServis.Text = "SERVİS";
            this.btnServis.UseVisualStyleBackColor = true;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // btnYonetim
            // 
            this.btnYonetim.Location = new System.Drawing.Point(303, 255);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(180, 124);
            this.btnYonetim.TabIndex = 5;
            this.btnYonetim.Text = "YÖNETİM";
            this.btnYonetim.UseVisualStyleBackColor = true;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(58, 255);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(179, 124);
            this.btnRaporlar.TabIndex = 4;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // lblMasterKarsilama
            // 
            this.lblMasterKarsilama.AutoSize = true;
            this.lblMasterKarsilama.Location = new System.Drawing.Point(58, 42);
            this.lblMasterKarsilama.Name = "lblMasterKarsilama";
            this.lblMasterKarsilama.Size = new System.Drawing.Size(46, 17);
            this.lblMasterKarsilama.TabIndex = 6;
            this.lblMasterKarsilama.Text = "label1";
            // 
            // frmMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 532);
            this.Controls.Add(this.lblMasterKarsilama);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnServis);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.msMasterForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Satış";
            this.Load += new System.EventHandler(this.frmMasterForm_Load);
            this.msMasterForm.ResumeLayout(false);
            this.msMasterForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMasterForm;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracToolStripMenuItem;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btnYonetim;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Label lblMasterKarsilama;
    }
}

