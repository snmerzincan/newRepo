namespace wfVideoMarketProjesi
{
    partial class frmFilmSorgulama
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
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.txtYonetmeneGore = new System.Windows.Forms.TextBox();
            this.txtOyuncularaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lvFilmler.Location = new System.Drawing.Point(12, 97);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(660, 282);
            this.lvFilmler.TabIndex = 10;
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
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmTürü";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oyuncular";
            this.columnHeader5.Width = 138;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Özet";
            this.columnHeader6.Width = 97;
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
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(12, 71);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(110, 20);
            this.txtAdaGore.TabIndex = 28;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Film Adına Göre";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 100;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(122, 70);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(82, 21);
            this.cbFilmTurleri.TabIndex = 29;
            this.cbFilmTurleri.SelectedIndexChanged += new System.EventHandler(this.cbFilmTurleri_SelectedIndexChanged);
            // 
            // txtYonetmeneGore
            // 
            this.txtYonetmeneGore.Location = new System.Drawing.Point(204, 70);
            this.txtYonetmeneGore.Name = "txtYonetmeneGore";
            this.txtYonetmeneGore.Size = new System.Drawing.Size(106, 20);
            this.txtYonetmeneGore.TabIndex = 30;
            this.txtYonetmeneGore.TextChanged += new System.EventHandler(this.txtYonetmeneGore_TextChanged);
            // 
            // txtOyuncularaGore
            // 
            this.txtOyuncularaGore.Location = new System.Drawing.Point(310, 70);
            this.txtOyuncularaGore.Name = "txtOyuncularaGore";
            this.txtOyuncularaGore.Size = new System.Drawing.Size(139, 20);
            this.txtOyuncularaGore.TabIndex = 31;
            this.txtOyuncularaGore.TextChanged += new System.EventHandler(this.txtOyuncularaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Film Türüne Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Yönetmene Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Oyunculara Göre";
            // 
            // frmFilmSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncularaGore);
            this.Controls.Add(this.txtYonetmeneGore);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvFilmler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmSorgulama";
            this.Text = "Detaylı Film Sorgulama";
            this.Load += new System.EventHandler(this.frmFilmSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.TextBox txtYonetmeneGore;
        private System.Windows.Forms.TextBox txtOyuncularaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}