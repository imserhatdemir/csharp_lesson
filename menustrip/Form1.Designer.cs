namespace menustrip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcILoveYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynuYıldızınAltındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuSeansıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romatikToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kategorilerToolStripMenuItem.Text = "kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madMaxToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aksiyonToolStripMenuItem.Text = "aksiyon";
            // 
            // madMaxToolStripMenuItem
            // 
            this.madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            this.madMaxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.madMaxToolStripMenuItem.Text = "mad max";
            this.madMaxToolStripMenuItem.Click += new System.EventHandler(this.MadMaxToolStripMenuItem_Click);
            // 
            // romatikToolStripMenuItem
            // 
            this.romatikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pcILoveYouToolStripMenuItem,
            this.aynuYıldızınAltındaToolStripMenuItem});
            this.romatikToolStripMenuItem.Name = "romatikToolStripMenuItem";
            this.romatikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romatikToolStripMenuItem.Text = "romatik";
            // 
            // pcILoveYouToolStripMenuItem
            // 
            this.pcILoveYouToolStripMenuItem.Name = "pcILoveYouToolStripMenuItem";
            this.pcILoveYouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pcILoveYouToolStripMenuItem.Text = "pc ı love you";
            this.pcILoveYouToolStripMenuItem.Click += new System.EventHandler(this.PcILoveYouToolStripMenuItem_Click);
            // 
            // aynuYıldızınAltındaToolStripMenuItem
            // 
            this.aynuYıldızınAltındaToolStripMenuItem.Name = "aynuYıldızınAltındaToolStripMenuItem";
            this.aynuYıldızınAltındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aynuYıldızınAltındaToolStripMenuItem.Text = "aynu yıldızın altında";
            this.aynuYıldızınAltındaToolStripMenuItem.Click += new System.EventHandler(this.AynuYıldızınAltındaToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korkuSeansıToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korkuToolStripMenuItem.Text = "korku";
            // 
            // korkuSeansıToolStripMenuItem
            // 
            this.korkuSeansıToolStripMenuItem.Name = "korkuSeansıToolStripMenuItem";
            this.korkuSeansıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korkuSeansıToolStripMenuItem.Text = "korku seansı";
            this.korkuSeansıToolStripMenuItem.Click += new System.EventHandler(this.KorkuSeansıToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avengersToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bilimKurguToolStripMenuItem.Text = "bilim kurgu";
            // 
            // avengersToolStripMenuItem
            // 
            this.avengersToolStripMenuItem.Name = "avengersToolStripMenuItem";
            this.avengersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avengersToolStripMenuItem.Text = "avengers";
            this.avengersToolStripMenuItem.Click += new System.EventHandler(this.AvengersToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.turuncuToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.renklerToolStripMenuItem.Text = "renkler";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.maviToolStripMenuItem.Text = "mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.MaviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.griToolStripMenuItem.Text = "gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.GriToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.turuncuToolStripMenuItem.Text = "turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.TuruncuToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.hızlıErişimToolStripMenuItem.Text = "hızlı erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hakkımızdaToolStripMenuItem.Text = "hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.HakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.çıkışToolStripMenuItem.Text = "çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 76);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(364, 193);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcILoveYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynuYıldızınAltındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuSeansıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

