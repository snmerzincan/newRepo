namespace OtelOtomosyonu
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilatEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylıSatışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCikacakSayisi = new System.Windows.Forms.TextBox();
            this.txtCikacakOdaSayisi = new System.Windows.Forms.TextBox();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBosOdaSayisi = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtDoluOdaSayisi = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.calisanlarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.raporlamaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1366, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriSorgulamaToolStripMenuItem,
            this.müşteriKaydıToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriSorgulamaToolStripMenuItem
            // 
            this.müşteriSorgulamaToolStripMenuItem.Name = "müşteriSorgulamaToolStripMenuItem";
            this.müşteriSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.müşteriSorgulamaToolStripMenuItem.Text = "Müşteri Sorgulama";
            this.müşteriSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.müşteriSorgulamaToolStripMenuItem_Click);
            // 
            // müşteriKaydıToolStripMenuItem
            // 
            this.müşteriKaydıToolStripMenuItem.Name = "müşteriKaydıToolStripMenuItem";
            this.müşteriKaydıToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.müşteriKaydıToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriKaydıToolStripMenuItem.Click += new System.EventHandler(this.müşteriKaydıToolStripMenuItem_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem,
            this.odaSorgulamaToolStripMenuItem});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(126, 23);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonToolStripMenuItem_Click);
            // 
            // odaSorgulamaToolStripMenuItem
            // 
            this.odaSorgulamaToolStripMenuItem.Name = "odaSorgulamaToolStripMenuItem";
            this.odaSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.odaSorgulamaToolStripMenuItem.Text = "Oda Sorgulama";
            this.odaSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.odaSorgulamaToolStripMenuItem_Click);
            // 
            // calisanlarToolStripMenuItem
            // 
            this.calisanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persToolStripMenuItem});
            this.calisanlarToolStripMenuItem.Name = "calisanlarToolStripMenuItem";
            this.calisanlarToolStripMenuItem.Size = new System.Drawing.Size(156, 23);
            this.calisanlarToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // persToolStripMenuItem
            // 
            this.persToolStripMenuItem.Name = "persToolStripMenuItem";
            this.persToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.persToolStripMenuItem.Text = "Personel Kaydı";
            this.persToolStripMenuItem.Click += new System.EventHandler(this.persToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekstraEkleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 23);
            this.toolStripMenuItem1.Text = "Ekstralar";
            // 
            // ekstraEkleToolStripMenuItem
            // 
            this.ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            this.ekstraEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
            this.ekstraEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraEkleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tahsilatEkleToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 23);
            this.toolStripMenuItem2.Text = "Tahsilat";
            // 
            // tahsilatEkleToolStripMenuItem
            // 
            this.tahsilatEkleToolStripMenuItem.Name = "tahsilatEkleToolStripMenuItem";
            this.tahsilatEkleToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.tahsilatEkleToolStripMenuItem.Text = "Tahsilat Ekle";
            this.tahsilatEkleToolStripMenuItem.Click += new System.EventHandler(this.tahsilatEkleToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylıSatışRaporuToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // detaylıSatışRaporuToolStripMenuItem
            // 
            this.detaylıSatışRaporuToolStripMenuItem.Name = "detaylıSatışRaporuToolStripMenuItem";
            this.detaylıSatışRaporuToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.detaylıSatışRaporuToolStripMenuItem.Text = "Detaylı Satış Raporu";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // txtCikacakSayisi
            // 
            this.txtCikacakSayisi.BackColor = System.Drawing.Color.Blue;
            this.txtCikacakSayisi.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikacakSayisi.Location = new System.Drawing.Point(1006, 150);
            this.txtCikacakSayisi.Name = "txtCikacakSayisi";
            this.txtCikacakSayisi.Size = new System.Drawing.Size(249, 32);
            this.txtCikacakSayisi.TabIndex = 63;
            this.txtCikacakSayisi.Text = "Çıkacak Oda Sayısı";
            // 
            // txtCikacakOdaSayisi
            // 
            this.txtCikacakOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikacakOdaSayisi.Location = new System.Drawing.Point(1262, 150);
            this.txtCikacakOdaSayisi.Name = "txtCikacakOdaSayisi";
            this.txtCikacakOdaSayisi.Size = new System.Drawing.Size(76, 32);
            this.txtCikacakOdaSayisi.TabIndex = 64;
            this.txtCikacakOdaSayisi.Text = " ";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(622, -45);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 62;
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(622, -89);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtGirisTarihi.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, -43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 60;
            this.label2.Text = "Çıkış Tarihi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, -87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "Giriş Tarihi: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(1006, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 32);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "Boş Oda Sayısı";
            // 
            // txtBosOdaSayisi
            // 
            this.txtBosOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBosOdaSayisi.Location = new System.Drawing.Point(1262, 68);
            this.txtBosOdaSayisi.Name = "txtBosOdaSayisi";
            this.txtBosOdaSayisi.Size = new System.Drawing.Size(76, 32);
            this.txtBosOdaSayisi.TabIndex = 55;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Red;
            this.textBox5.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(1006, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 32);
            this.textBox5.TabIndex = 56;
            this.textBox5.Text = "Dolu Oda Sayısı";
            // 
            // txtDoluOdaSayisi
            // 
            this.txtDoluOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoluOdaSayisi.Location = new System.Drawing.Point(1262, 109);
            this.txtDoluOdaSayisi.Name = "txtDoluOdaSayisi";
            this.txtDoluOdaSayisi.Size = new System.Drawing.Size(76, 32);
            this.txtDoluOdaSayisi.TabIndex = 57;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.txtCikacakSayisi);
            this.Controls.Add(this.txtCikacakOdaSayisi);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.dtGirisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBosOdaSayisi);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtDoluOdaSayisi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnasayfa";
            this.Text = "frmAnasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaylıSatışRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tahsilatEkleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCikacakSayisi;
        private System.Windows.Forms.TextBox txtCikacakOdaSayisi;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBosOdaSayisi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtDoluOdaSayisi;
    }
}