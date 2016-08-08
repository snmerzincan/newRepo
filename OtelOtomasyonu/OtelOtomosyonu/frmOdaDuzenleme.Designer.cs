namespace OtelOtomosyonu
{
    partial class frmOdaDuzenleme
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
            this.lwOdaBilgileri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOdaID = new System.Windows.Forms.TextBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdaDurum = new System.Windows.Forms.TextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Oda Bilgileri : ";
            // 
            // lwOdaBilgileri
            // 
            this.lwOdaBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader7});
            this.lwOdaBilgileri.Font = new System.Drawing.Font("Arial", 8F);
            this.lwOdaBilgileri.FullRowSelect = true;
            this.lwOdaBilgileri.Location = new System.Drawing.Point(12, 77);
            this.lwOdaBilgileri.Name = "lwOdaBilgileri";
            this.lwOdaBilgileri.Size = new System.Drawing.Size(763, 198);
            this.lwOdaBilgileri.TabIndex = 73;
            this.lwOdaBilgileri.UseCompatibleStateImageBehavior = false;
            this.lwOdaBilgileri.View = System.Windows.Forms.View.Details;
            this.lwOdaBilgileri.DoubleClick += new System.EventHandler(this.lwOdaBilgileri_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OdaID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda Numarası";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kat";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oda Durumu";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oda Tipi";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yatak Sayısı";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fiyat";
            this.columnHeader10.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Aciklama";
            this.columnHeader7.Width = 222;
            // 
            // txtOdaID
            // 
            this.txtOdaID.BackColor = System.Drawing.Color.SteelBlue;
            this.txtOdaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaID.ForeColor = System.Drawing.Color.Transparent;
            this.txtOdaID.Location = new System.Drawing.Point(182, 300);
            this.txtOdaID.Name = "txtOdaID";
            this.txtOdaID.Size = new System.Drawing.Size(25, 20);
            this.txtOdaID.TabIndex = 82;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(327, 300);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(181, 20);
            this.txtOdaNo.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(213, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Oda Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(222, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Oda Durumu:";
            // 
            // txtOdaDurum
            // 
            this.txtOdaDurum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaDurum.Location = new System.Drawing.Point(327, 333);
            this.txtOdaDurum.Name = "txtOdaDurum";
            this.txtOdaDurum.Size = new System.Drawing.Size(181, 20);
            this.txtOdaDurum.TabIndex = 80;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDuzenle.Image = global::OtelOtomosyonu.Properties.Resources.comment_user_page;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(367, 376);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(93, 36);
            this.btnDuzenle.TabIndex = 84;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Items.AddRange(new object[] {
            "201",
            "202",
            "203",
            "204",
            "205",
            "301",
            "302",
            "303",
            "304",
            "305",
            "401",
            "402",
            "403",
            "404",
            "501",
            "502",
            "503",
            "504",
            "601",
            "602",
            "603",
            "701",
            "702",
            "801",
            "802",
            "901",
            "1001"});
            this.cmbOdalar.Location = new System.Drawing.Point(327, 30);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(181, 21);
            this.cmbOdalar.TabIndex = 90;
            this.cmbOdalar.SelectedIndexChanged += new System.EventHandler(this.cmbOdalar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(227, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Oda Numarası: ";
            // 
            // frmOdaDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.txtOdaID);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdaDurum);
            this.Controls.Add(this.lwOdaBilgileri);
            this.Controls.Add(this.label1);
            this.Name = "frmOdaDuzenleme";
            this.Text = " Oda Düzenleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwOdaBilgileri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtOdaID;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdaDurum;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.Label label4;
    }
}