namespace wfStokTakibi
{
    partial class MusteriCariEkstre
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
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.btnFirmaBul = new System.Windows.Forms.Button();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbTumFirmalar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCariEkstre = new System.Windows.Forms.DataGridView();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariEkstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(13, 13);
            this.txtCariNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(24, 23);
            this.txtCariNo.TabIndex = 50;
            // 
            // btnFirmaBul
            // 
            this.btnFirmaBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaBul.Location = new System.Drawing.Point(282, 49);
            this.btnFirmaBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirmaBul.Name = "btnFirmaBul";
            this.btnFirmaBul.Size = new System.Drawing.Size(51, 28);
            this.btnFirmaBul.TabIndex = 49;
            this.btnFirmaBul.Text = "...";
            this.btnFirmaBul.UseVisualStyleBackColor = true;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(110, 51);
            this.txtFirma.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(171, 23);
            this.txtFirma.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Firma";
            // 
            // rbTumFirmalar
            // 
            this.rbTumFirmalar.AutoSize = true;
            this.rbTumFirmalar.Location = new System.Drawing.Point(236, 107);
            this.rbTumFirmalar.Name = "rbTumFirmalar";
            this.rbTumFirmalar.Size = new System.Drawing.Size(109, 21);
            this.rbTumFirmalar.TabIndex = 53;
            this.rbTumFirmalar.Text = "Tüm Firmalar";
            this.rbTumFirmalar.UseVisualStyleBackColor = true;
            this.rbTumFirmalar.CheckedChanged += new System.EventHandler(this.rbTumFirmalar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Location = new System.Drawing.Point(138, 107);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(76, 21);
            this.rbSaticilar.TabIndex = 52;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Location = new System.Drawing.Point(31, 106);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(67, 21);
            this.rbAlicilar.TabIndex = 51;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(461, 103);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(129, 23);
            this.dtpIlkTarih.TabIndex = 54;
            this.dtpIlkTarih.ValueChanged += new System.EventHandler(this.dtpIlkTarih_ValueChanged);
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(650, 103);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(129, 23);
            this.dtpSonTarih.TabIndex = 55;
            this.dtpSonTarih.ValueChanged += new System.EventHandler(this.dtpSonTarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Son Tarih";
            // 
            // dgvCariEkstre
            // 
            this.dgvCariEkstre.AllowUserToAddRows = false;
            this.dgvCariEkstre.AllowUserToDeleteRows = false;
            this.dgvCariEkstre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariEkstre.Location = new System.Drawing.Point(372, 156);
            this.dgvCariEkstre.Name = "dgvCariEkstre";
            this.dgvCariEkstre.ReadOnly = true;
            this.dgvCariEkstre.Size = new System.Drawing.Size(490, 261);
            this.dgvCariEkstre.TabIndex = 59;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(796, 423);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(66, 23);
            this.txtBakiye.TabIndex = 62;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamAlacak
            // 
            this.txtToplamAlacak.Location = new System.Drawing.Point(722, 423);
            this.txtToplamAlacak.Name = "txtToplamAlacak";
            this.txtToplamAlacak.ReadOnly = true;
            this.txtToplamAlacak.Size = new System.Drawing.Size(75, 23);
            this.txtToplamAlacak.TabIndex = 61;
            this.txtToplamAlacak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.Location = new System.Drawing.Point(648, 423);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(75, 23);
            this.txtToplamBorc.TabIndex = 60;
            this.txtToplamBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCariler
            // 
            this.dgvCariler.AllowUserToAddRows = false;
            this.dgvCariler.AllowUserToDeleteRows = false;
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(23, 156);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.ReadOnly = true;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(319, 290);
            this.dgvCariler.TabIndex = 63;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // MusteriCariEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.dgvCariler);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtToplamAlacak);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.dgvCariEkstre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.rbTumFirmalar);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.btnFirmaBul);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriCariEkstre";
            this.Text = "MusteriCariEkstre";
            this.Load += new System.EventHandler(this.MusteriCariEkstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariEkstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.Button btnFirmaBul;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbTumFirmalar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCariEkstre;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamAlacak;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.DataGridView dgvCariler;
    }
}