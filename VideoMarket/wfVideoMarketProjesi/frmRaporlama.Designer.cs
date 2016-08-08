namespace wfVideoMarketProjesi
{
    partial class frmRaporlama
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.btnFilmBul = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTumMusteriler = new System.Windows.Forms.CheckBox();
            this.cbxTumFilmler = new System.Windows.Forms.CheckBox();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Toplam";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(621, 436);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(95, 20);
            this.txtToplamTutar.TabIndex = 38;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(532, 436);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(83, 20);
            this.txtToplamAdet.TabIndex = 37;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.AllowUserToAddRows = false;
            this.dgvSatislar.AllowUserToDeleteRows = false;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(70, 215);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.ReadOnly = true;
            this.dgvSatislar.Size = new System.Drawing.Size(676, 206);
            this.dgvSatislar.TabIndex = 36;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(298, 156);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(183, 23);
            this.btnGetir.TabIndex = 35;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Son Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "İlk Tarih";
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(439, 37);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(118, 20);
            this.dtpTarih2.TabIndex = 32;
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(243, 37);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(118, 20);
            this.dtpTarih1.TabIndex = 31;
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(752, 120);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(31, 20);
            this.txtFilmNo.TabIndex = 47;
            // 
            // btnFilmBul
            // 
            this.btnFilmBul.Enabled = false;
            this.btnFilmBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmBul.Location = new System.Drawing.Point(598, 119);
            this.btnFilmBul.Name = "btnFilmBul";
            this.btnFilmBul.Size = new System.Drawing.Size(40, 23);
            this.btnFilmBul.TabIndex = 46;
            this.btnFilmBul.Text = "...";
            this.btnFilmBul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmBul.UseVisualStyleBackColor = true;
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(638, 120);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(108, 20);
            this.txtFilm.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Film Bul";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(12, 118);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(31, 20);
            this.txtMusteriNo.TabIndex = 43;
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Enabled = false;
            this.btnMusteriBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBul.Location = new System.Drawing.Point(178, 117);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(40, 23);
            this.btnMusteriBul.TabIndex = 42;
            this.btnMusteriBul.Text = "...";
            this.btnMusteriBul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(70, 118);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(108, 20);
            this.txtMusteri.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Müşteri Bul";
            // 
            // cbxTumMusteriler
            // 
            this.cbxTumMusteriler.AutoSize = true;
            this.cbxTumMusteriler.Checked = true;
            this.cbxTumMusteriler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTumMusteriler.Location = new System.Drawing.Point(98, 156);
            this.cbxTumMusteriler.Name = "cbxTumMusteriler";
            this.cbxTumMusteriler.Size = new System.Drawing.Size(95, 17);
            this.cbxTumMusteriler.TabIndex = 48;
            this.cbxTumMusteriler.Text = "Tüm Müşteriler";
            this.cbxTumMusteriler.UseVisualStyleBackColor = true;
            // 
            // cbxTumFilmler
            // 
            this.cbxTumFilmler.AutoSize = true;
            this.cbxTumFilmler.Checked = true;
            this.cbxTumFilmler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTumFilmler.Location = new System.Drawing.Point(638, 160);
            this.cbxTumFilmler.Name = "cbxTumFilmler";
            this.cbxTumFilmler.Size = new System.Drawing.Size(79, 17);
            this.cbxTumFilmler.TabIndex = 49;
            this.cbxTumFilmler.Text = "Tüm Filmler";
            this.cbxTumFilmler.UseVisualStyleBackColor = true;
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 100;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(337, 94);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(125, 21);
            this.cbFilmTurleri.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Film Türü";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(95, 432);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.ReadOnly = true;
            this.txtSatir.Size = new System.Drawing.Size(51, 20);
            this.txtSatir.TabIndex = 52;
            this.txtSatir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "adet listelenmiştir.";
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.cbxTumFilmler);
            this.Controls.Add(this.cbxTumMusteriler);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.btnFilmBul);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Name = "frmRaporlama";
            this.Text = "Detaylı Satış Raporu";
            this.Load += new System.EventHandler(this.frmRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.Button btnFilmBul;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxTumMusteriler;
        private System.Windows.Forms.CheckBox cbxTumFilmler;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.Label label6;
    }
}