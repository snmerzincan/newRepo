namespace wfStokTakibi
{
    partial class KasaIslemleri
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
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDevirGiren = new System.Windows.Forms.TextBox();
            this.txtDevirCikan = new System.Windows.Forms.TextBox();
            this.txtDevirBakiye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIslemTuru = new System.Windows.Forms.TextBox();
            this.txtIslemTarihi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.txtBelge = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtToplamGiren = new System.Windows.Forms.TextBox();
            this.txtToplamCikan = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Türü";
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.Location = new System.Drawing.Point(118, 58);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(100, 20);
            this.txtKasaTuru.TabIndex = 1;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(118, 84);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 3;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlem Tarihi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(219, 84);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(22, 20);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "TL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Para Birimi";
            // 
            // txtDevirGiren
            // 
            this.txtDevirGiren.Location = new System.Drawing.Point(355, 87);
            this.txtDevirGiren.Name = "txtDevirGiren";
            this.txtDevirGiren.ReadOnly = true;
            this.txtDevirGiren.Size = new System.Drawing.Size(100, 20);
            this.txtDevirGiren.TabIndex = 7;
            this.txtDevirGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirCikan
            // 
            this.txtDevirCikan.Location = new System.Drawing.Point(455, 87);
            this.txtDevirCikan.Name = "txtDevirCikan";
            this.txtDevirCikan.ReadOnly = true;
            this.txtDevirCikan.Size = new System.Drawing.Size(100, 20);
            this.txtDevirCikan.TabIndex = 8;
            this.txtDevirCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirBakiye
            // 
            this.txtDevirBakiye.Location = new System.Drawing.Point(555, 87);
            this.txtDevirBakiye.Name = "txtDevirBakiye";
            this.txtDevirBakiye.ReadOnly = true;
            this.txtDevirBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtDevirBakiye.TabIndex = 9;
            this.txtDevirBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Devirler";
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvHareketler.FullRowSelect = true;
            this.lvHareketler.GridLines = true;
            this.lvHareketler.Location = new System.Drawing.Point(41, 223);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(623, 187);
            this.lvHareketler.TabIndex = 11;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            this.lvHareketler.DoubleClick += new System.EventHandler(this.lvHareketler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İşlemTarihi";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlemTürü";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cari Ünvan";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Belge";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giren";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Çıkan";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 80;
            // 
            // txtIslemTuru
            // 
            this.txtIslemTuru.Location = new System.Drawing.Point(161, 197);
            this.txtIslemTuru.Name = "txtIslemTuru";
            this.txtIslemTuru.ReadOnly = true;
            this.txtIslemTuru.Size = new System.Drawing.Size(80, 20);
            this.txtIslemTuru.TabIndex = 14;
            this.txtIslemTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIslemTarihi
            // 
            this.txtIslemTarihi.Location = new System.Drawing.Point(80, 197);
            this.txtIslemTarihi.Name = "txtIslemTarihi";
            this.txtIslemTarihi.ReadOnly = true;
            this.txtIslemTarihi.Size = new System.Drawing.Size(82, 20);
            this.txtIslemTarihi.TabIndex = 13;
            this.txtIslemTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(41, 197);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(40, 20);
            this.txtID.TabIndex = 12;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(240, 197);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.ReadOnly = true;
            this.txtCariUnvan.Size = new System.Drawing.Size(129, 20);
            this.txtCariUnvan.TabIndex = 15;
            this.txtCariUnvan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBelge
            // 
            this.txtBelge.Location = new System.Drawing.Point(368, 197);
            this.txtBelge.Name = "txtBelge";
            this.txtBelge.Size = new System.Drawing.Size(121, 20);
            this.txtBelge.TabIndex = 16;
            this.txtBelge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(488, 197);
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(81, 20);
            this.txtGiren.TabIndex = 17;
            this.txtGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(568, 197);
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(81, 20);
            this.txtCikan.TabIndex = 18;
            this.txtCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Tahsilat",
            "Ödeme"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(161, 170);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(80, 21);
            this.cbIslemTurleri.TabIndex = 19;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(574, 148);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(44, 26);
            this.btnSil.TabIndex = 48;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(504, 148);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(65, 26);
            this.btnDegistir.TabIndex = 47;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(436, 148);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 26);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(384, 148);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(47, 26);
            this.btnYeni.TabIndex = 45;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtToplamGiren
            // 
            this.txtToplamGiren.Location = new System.Drawing.Point(489, 413);
            this.txtToplamGiren.Name = "txtToplamGiren";
            this.txtToplamGiren.ReadOnly = true;
            this.txtToplamGiren.Size = new System.Drawing.Size(75, 20);
            this.txtToplamGiren.TabIndex = 49;
            this.txtToplamGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamCikan
            // 
            this.txtToplamCikan.Location = new System.Drawing.Point(563, 413);
            this.txtToplamCikan.Name = "txtToplamCikan";
            this.txtToplamCikan.ReadOnly = true;
            this.txtToplamCikan.Size = new System.Drawing.Size(75, 20);
            this.txtToplamCikan.TabIndex = 50;
            this.txtToplamCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(637, 413);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(66, 20);
            this.txtBakiye.TabIndex = 51;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(261, 170);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(10, 20);
            this.txtCariNo.TabIndex = 52;
            this.txtCariNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(706, 477);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtToplamCikan);
            this.Controls.Add(this.txtToplamGiren);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.txtCikan);
            this.Controls.Add(this.txtGiren);
            this.Controls.Add(this.txtBelge);
            this.Controls.Add(this.txtCariUnvan);
            this.Controls.Add(this.txtIslemTuru);
            this.Controls.Add(this.txtIslemTarihi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDevirBakiye);
            this.Controls.Add(this.txtDevirCikan);
            this.Controls.Add(this.txtDevirGiren);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKasaTuru);
            this.Controls.Add(this.label1);
            this.Name = "KasaIslemleri";
            this.Text = "Günlük Kasa İşlemleri";
            this.Load += new System.EventHandler(this.KasaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDevirGiren;
        private System.Windows.Forms.TextBox txtDevirCikan;
        private System.Windows.Forms.TextBox txtDevirBakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtIslemTuru;
        private System.Windows.Forms.TextBox txtIslemTarihi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.TextBox txtBelge;
        private System.Windows.Forms.TextBox txtGiren;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtToplamGiren;
        private System.Windows.Forms.TextBox txtToplamCikan;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtCariNo;
    }
}