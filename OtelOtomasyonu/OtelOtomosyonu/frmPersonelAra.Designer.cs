namespace OtelOtomosyonu
{
    partial class frmPersonelAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelAra));
            this.lvPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPersSoyad = new System.Windows.Forms.TextBox();
            this.txtPersAd = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPersoneller
            // 
            this.lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvPersoneller.FullRowSelect = true;
            this.lvPersoneller.Location = new System.Drawing.Point(46, 122);
            this.lvPersoneller.Name = "lvPersoneller";
            this.lvPersoneller.Size = new System.Drawing.Size(654, 268);
            this.lvPersoneller.TabIndex = 56;
            this.lvPersoneller.UseCompatibleStateImageBehavior = false;
            this.lvPersoneller.View = System.Windows.Forms.View.Details;
            this.lvPersoneller.DoubleClick += new System.EventHandler(this.lvPersoneller_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CalisanID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adı";
            this.columnHeader7.Width = 152;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyadı";
            this.columnHeader8.Width = 151;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TC Kimlik Numarası";
            this.columnHeader9.Width = 188;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Departmanı";
            this.columnHeader10.Width = 159;
            // 
            // txtPersSoyad
            // 
            this.txtPersSoyad.Location = new System.Drawing.Point(220, 85);
            this.txtPersSoyad.Name = "txtPersSoyad";
            this.txtPersSoyad.Size = new System.Drawing.Size(138, 20);
            this.txtPersSoyad.TabIndex = 55;
            this.txtPersSoyad.TextChanged += new System.EventHandler(this.txtPersSoyad_TextChanged);
            // 
            // txtPersAd
            // 
            this.txtPersAd.Location = new System.Drawing.Point(47, 85);
            this.txtPersAd.Name = "txtPersAd";
            this.txtPersAd.Size = new System.Drawing.Size(138, 20);
            this.txtPersAd.TabIndex = 54;
            this.txtPersAd.TextChanged += new System.EventHandler(this.txtPersAd_TextChanged);
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(392, 85);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(138, 20);
            this.txtTCKimlikNo.TabIndex = 53;
            this.txtTCKimlikNo.TextChanged += new System.EventHandler(this.txtTCKimlikNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(217, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(389, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(563, 85);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(138, 20);
            this.txtDepartman.TabIndex = 58;
            this.txtDepartman.TextChanged += new System.EventHandler(this.txtDepartman_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(560, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Departmanı:";
            // 
            // frmPersonelAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvPersoneller);
            this.Controls.Add(this.txtPersSoyad);
            this.Controls.Add(this.txtPersAd);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonelAra";
            this.Text = "frmPersonelAra";
            this.Load += new System.EventHandler(this.frmPersonelAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtPersSoyad;
        private System.Windows.Forms.TextBox txtPersAd;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.Label label4;
    }
}