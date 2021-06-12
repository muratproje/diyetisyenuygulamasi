namespace diyetisyenGUI
{
    partial class DiyetisyenAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenAnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diyetsiyenKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diyetKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalıkKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.diyetsiyenKayıtToolStripMenuItem,
            this.diyetKayıtToolStripMenuItem,
            this.hastalıkKayıtToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // diyetsiyenKayıtToolStripMenuItem
            // 
            this.diyetsiyenKayıtToolStripMenuItem.Name = "diyetsiyenKayıtToolStripMenuItem";
            this.diyetsiyenKayıtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.diyetsiyenKayıtToolStripMenuItem.Text = "Diyetisyen Kayıt";
            this.diyetsiyenKayıtToolStripMenuItem.Click += new System.EventHandler(this.diyetsiyenKayıtToolStripMenuItem_Click);
            // 
            // diyetKayıtToolStripMenuItem
            // 
            this.diyetKayıtToolStripMenuItem.Name = "diyetKayıtToolStripMenuItem";
            this.diyetKayıtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.diyetKayıtToolStripMenuItem.Text = "Diyet Kayıt";
            this.diyetKayıtToolStripMenuItem.Click += new System.EventHandler(this.diyetKayıtToolStripMenuItem_Click);
            // 
            // hastalıkKayıtToolStripMenuItem
            // 
            this.hastalıkKayıtToolStripMenuItem.Name = "hastalıkKayıtToolStripMenuItem";
            this.hastalıkKayıtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hastalıkKayıtToolStripMenuItem.Text = "Hastalık Kayıt";
            this.hastalıkKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastalıkKayıtToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaRaporuToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // hastaRaporuToolStripMenuItem
            // 
            this.hastaRaporuToolStripMenuItem.Name = "hastaRaporuToolStripMenuItem";
            this.hastaRaporuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hastaRaporuToolStripMenuItem.Text = "Hasta Raporu";
            this.hastaRaporuToolStripMenuItem.Click += new System.EventHandler(this.hastaRaporuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 412);
            this.panel1.TabIndex = 3;
            // 
            // DiyetisyenAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DiyetisyenAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyen";
            this.Load += new System.EventHandler(this.DiyetisyenAnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem diyetsiyenKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diyetKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalıkKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaRaporuToolStripMenuItem;
    }
}

