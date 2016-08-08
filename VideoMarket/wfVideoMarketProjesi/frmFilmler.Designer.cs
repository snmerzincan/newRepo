namespace wfVideoMarketProjesi
{
    partial class frmFilmler
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
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtFilmTuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.txtTurNo = new System.Windows.Forms.TextBox();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(111, 106);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(156, 20);
            this.txtFilmAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adı";
            // 
            // lvFilmler
            // 
            this.lvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.Location = new System.Drawing.Point(292, 60);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(277, 282);
            this.lvFilmler.TabIndex = 9;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.View = System.Windows.Forms.View.Details;
            this.lvFilmler.DoubleClick += new System.EventHandler(this.lvFilmler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmNo";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmTürü";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oyuncular";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Özet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FilmTurNo";
            this.columnHeader9.Width = 0;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(230, 363);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(63, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(161, 363);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(63, 23);
            this.btnDegistir.TabIndex = 12;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(92, 363);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(39, 363);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(47, 23);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(12, 69);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(24, 20);
            this.txtFilmNo.TabIndex = 14;
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(111, 135);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.ReadOnly = true;
            this.txtFilmTuru.Size = new System.Drawing.Size(132, 20);
            this.txtFilmTuru.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Film Türü";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 100;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(242, 135);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(25, 21);
            this.cbFilmTurleri.TabIndex = 17;
            this.cbFilmTurleri.SelectedIndexChanged += new System.EventHandler(this.cbFilmTurleri_SelectedIndexChanged);
            // 
            // txtTurNo
            // 
            this.txtTurNo.Location = new System.Drawing.Point(12, 134);
            this.txtTurNo.Name = "txtTurNo";
            this.txtTurNo.ReadOnly = true;
            this.txtTurNo.Size = new System.Drawing.Size(24, 20);
            this.txtTurNo.TabIndex = 18;
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.Location = new System.Drawing.Point(111, 193);
            this.txtOyuncular.Multiline = true;
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(156, 39);
            this.txtOyuncular.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Oyuncular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Yönetmen";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(111, 164);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(156, 20);
            this.txtYonetmen.TabIndex = 20;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(111, 241);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(156, 38);
            this.txtOzet.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Özet";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(111, 317);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(73, 20);
            this.txtMiktar.TabIndex = 24;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Miktar";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(111, 60);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(156, 20);
            this.txtAdaGore.TabIndex = 26;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Film Adına Göre Arama";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(111, 288);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(73, 20);
            this.txtFiyat.TabIndex = 28;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(273, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(273, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(273, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "*";
            // 
            // frmFilmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(582, 444);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOyuncular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurNo);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.txtFilmTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFilmler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmler";
            this.Text = "Film Tanımlama";
            this.Load += new System.EventHandler(this.frmFilmler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtFilmTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.TextBox txtTurNo;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}