namespace wfVideoMarketProjesi
{
    partial class frmMusteriSorgulama
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
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyadinaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdreseGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.Location = new System.Drawing.Point(51, 105);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(433, 282);
            this.lvMusteriler.TabIndex = 35;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.DoubleClick += new System.EventHandler(this.lvMusteriler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MusteriNo";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 120;
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(51, 79);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(97, 20);
            this.txtAdaGore.TabIndex = 55;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Müşteri Adına Göre ";
            // 
            // txtSoyadinaGore
            // 
            this.txtSoyadinaGore.Location = new System.Drawing.Point(148, 79);
            this.txtSoyadinaGore.Name = "txtSoyadinaGore";
            this.txtSoyadinaGore.Size = new System.Drawing.Size(97, 20);
            this.txtSoyadinaGore.TabIndex = 57;
            this.txtSoyadinaGore.TextChanged += new System.EventHandler(this.txtSoyadinaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Soyadına Göre ";
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Location = new System.Drawing.Point(244, 79);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(91, 20);
            this.txtTelefonaGore.TabIndex = 59;
            this.txtTelefonaGore.TextChanged += new System.EventHandler(this.txtTelefonaGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Telefona Göre ";
            // 
            // txtAdreseGore
            // 
            this.txtAdreseGore.Location = new System.Drawing.Point(334, 79);
            this.txtAdreseGore.Name = "txtAdreseGore";
            this.txtAdreseGore.Size = new System.Drawing.Size(150, 20);
            this.txtAdreseGore.TabIndex = 61;
            this.txtAdreseGore.TextChanged += new System.EventHandler(this.txtAdreseGore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Adrese Göre ";
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 442);
            this.Controls.Add(this.txtAdreseGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadinaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvMusteriler);
            this.Name = "frmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyadinaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdreseGore;
        private System.Windows.Forms.Label label3;
    }
}