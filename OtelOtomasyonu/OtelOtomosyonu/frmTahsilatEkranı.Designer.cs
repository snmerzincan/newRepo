namespace OtelOtomosyonu
{
    partial class frmTahsilatEkranı
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
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.btnTahsilat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtKalanOdeme = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOnOdeme = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMusteri
            // 
            this.txtMusteri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteri.Location = new System.Drawing.Point(153, 78);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(163, 20);
            this.txtMusteri.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tahsilat Tarihi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(100, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(153, 154);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(163, 20);
            this.txtTutar.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(65, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Ödeme Türü:";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(153, 115);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(163, 22);
            this.cmbOdemeTuru.TabIndex = 26;
            // 
            // btnTahsilat
            // 
            this.btnTahsilat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTahsilat.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTahsilat.Location = new System.Drawing.Point(115, 269);
            this.btnTahsilat.Name = "btnTahsilat";
            this.btnTahsilat.Size = new System.Drawing.Size(108, 39);
            this.btnTahsilat.TabIndex = 27;
            this.btnTahsilat.Text = "Tahsilat Ekle";
            this.btnTahsilat.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(229, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sonra Tahsilat Yap";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(153, 41);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(163, 20);
            this.dtpTarih.TabIndex = 29;
            // 
            // txtKalanOdeme
            // 
            this.txtKalanOdeme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanOdeme.Location = new System.Drawing.Point(153, 228);
            this.txtKalanOdeme.Name = "txtKalanOdeme";
            this.txtKalanOdeme.Size = new System.Drawing.Size(163, 20);
            this.txtKalanOdeme.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(100, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 14);
            this.label20.TabIndex = 32;
            this.label20.Text = "Kalan:";
            // 
            // txtOnOdeme
            // 
            this.txtOnOdeme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOnOdeme.Location = new System.Drawing.Point(153, 191);
            this.txtOnOdeme.Name = "txtOnOdeme";
            this.txtOnOdeme.Size = new System.Drawing.Size(163, 20);
            this.txtOnOdeme.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(70, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 14);
            this.label16.TabIndex = 30;
            this.label16.Text = "Ön Ödeme:";
            // 
            // frmTahsilatEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.txtKalanOdeme);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtOnOdeme);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTahsilat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTahsilatEkranı";
            this.Text = "Tahsilat Ekranı";
            this.Load += new System.EventHandler(this.frmTahsilatEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Button btnTahsilat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtKalanOdeme;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOnOdeme;
        private System.Windows.Forms.Label label16;
    }
}