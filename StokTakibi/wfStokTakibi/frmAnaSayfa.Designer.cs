namespace wfStokTakibi
{
    partial class frmAnaSayfa
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
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.ürünBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmUrunKartlari = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmStokGirisCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmStokSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mirmKategoriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriCariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCariKartlari = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCariHareketler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCariSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmGunlukKasa = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmKasaSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCariEkstre = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmGelirGiderAnalizi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünBilgileriToolStripMenuItem,
            this.müşteriCariToolStripMenuItem,
            this.kasaİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(571, 27);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // ürünBilgileriToolStripMenuItem
            // 
            this.ürünBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmUrunKartlari,
            this.mitmStokGirisCikis,
            this.mitmStokSorgulama,
            this.mirmKategoriTanimlama});
            this.ürünBilgileriToolStripMenuItem.Name = "ürünBilgileriToolStripMenuItem";
            this.ürünBilgileriToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.ürünBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            // 
            // mitmUrunKartlari
            // 
            this.mitmUrunKartlari.Name = "mitmUrunKartlari";
            this.mitmUrunKartlari.Size = new System.Drawing.Size(199, 24);
            this.mitmUrunKartlari.Text = "Ürün Kartları";
            this.mitmUrunKartlari.Click += new System.EventHandler(this.mitmUrunKartlari_Click);
            // 
            // mitmStokGirisCikis
            // 
            this.mitmStokGirisCikis.Name = "mitmStokGirisCikis";
            this.mitmStokGirisCikis.Size = new System.Drawing.Size(199, 24);
            this.mitmStokGirisCikis.Text = "Stok Giriş-Çıkış";
            this.mitmStokGirisCikis.Click += new System.EventHandler(this.mitmStokGirisCikis_Click);
            // 
            // mitmStokSorgulama
            // 
            this.mitmStokSorgulama.Name = "mitmStokSorgulama";
            this.mitmStokSorgulama.Size = new System.Drawing.Size(199, 24);
            this.mitmStokSorgulama.Text = "Stok Sorgulama";
            this.mitmStokSorgulama.Click += new System.EventHandler(this.mitmStokSorgulama_Click);
            // 
            // mirmKategoriTanimlama
            // 
            this.mirmKategoriTanimlama.Name = "mirmKategoriTanimlama";
            this.mirmKategoriTanimlama.Size = new System.Drawing.Size(199, 24);
            this.mirmKategoriTanimlama.Text = "Kategori Tanımlama";
            // 
            // müşteriCariToolStripMenuItem
            // 
            this.müşteriCariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmCariKartlari,
            this.mitmCariHareketler,
            this.mitmCariSorgulama});
            this.müşteriCariToolStripMenuItem.Name = "müşteriCariToolStripMenuItem";
            this.müşteriCariToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.müşteriCariToolStripMenuItem.Text = "Müşteri Cari";
            // 
            // mitmCariKartlari
            // 
            this.mitmCariKartlari.Name = "mitmCariKartlari";
            this.mitmCariKartlari.Size = new System.Drawing.Size(171, 24);
            this.mitmCariKartlari.Text = "Cari Kartları";
            // 
            // mitmCariHareketler
            // 
            this.mitmCariHareketler.Name = "mitmCariHareketler";
            this.mitmCariHareketler.Size = new System.Drawing.Size(171, 24);
            this.mitmCariHareketler.Text = "Cari Hareketler";
            // 
            // mitmCariSorgulama
            // 
            this.mitmCariSorgulama.Name = "mitmCariSorgulama";
            this.mitmCariSorgulama.Size = new System.Drawing.Size(171, 24);
            this.mitmCariSorgulama.Text = "Cari Sorgulama";
            // 
            // kasaİşlemleriToolStripMenuItem
            // 
            this.kasaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmGunlukKasa,
            this.mitmKasaSorgulama});
            this.kasaİşlemleriToolStripMenuItem.Name = "kasaİşlemleriToolStripMenuItem";
            this.kasaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.kasaİşlemleriToolStripMenuItem.Text = "Kasa İşlemleri";
            // 
            // mitmGunlukKasa
            // 
            this.mitmGunlukKasa.Name = "mitmGunlukKasa";
            this.mitmGunlukKasa.Size = new System.Drawing.Size(175, 24);
            this.mitmGunlukKasa.Text = "Günlük Kasa";
            this.mitmGunlukKasa.Click += new System.EventHandler(this.mitmGunlukKasa_Click);
            // 
            // mitmKasaSorgulama
            // 
            this.mitmKasaSorgulama.Name = "mitmKasaSorgulama";
            this.mitmKasaSorgulama.Size = new System.Drawing.Size(175, 24);
            this.mitmKasaSorgulama.Text = "Kasa Sorgulama";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmCariEkstre,
            this.mitmGelirGiderAnalizi});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // mitmCariEkstre
            // 
            this.mitmCariEkstre.Name = "mitmCariEkstre";
            this.mitmCariEkstre.Size = new System.Drawing.Size(194, 24);
            this.mitmCariEkstre.Text = "Müşteri Cari Ekstre";
            this.mitmCariEkstre.Click += new System.EventHandler(this.mitmCariEkstre_Click);
            // 
            // mitmGelirGiderAnalizi
            // 
            this.mitmGelirGiderAnalizi.Name = "mitmGelirGiderAnalizi";
            this.mitmGelirGiderAnalizi.Size = new System.Drawing.Size(194, 24);
            this.mitmGelirGiderAnalizi.Text = "Gelir-Gider Analizi";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(49, 23);
            this.mitmCikis.Text = "Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 433);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaSayfa";
            this.Text = "Stok AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmUrunKartlari;
        private System.Windows.Forms.ToolStripMenuItem mitmStokGirisCikis;
        private System.Windows.Forms.ToolStripMenuItem mitmStokSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mirmKategoriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem müşteriCariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCariKartlari;
        private System.Windows.Forms.ToolStripMenuItem mitmCariHareketler;
        private System.Windows.Forms.ToolStripMenuItem mitmCariSorgulama;
        private System.Windows.Forms.ToolStripMenuItem kasaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmGunlukKasa;
        private System.Windows.Forms.ToolStripMenuItem mitmKasaSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmCariEkstre;
        private System.Windows.Forms.ToolStripMenuItem mitmGelirGiderAnalizi;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}