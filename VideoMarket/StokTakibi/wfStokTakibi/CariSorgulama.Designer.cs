﻿namespace wfStokTakibi
{
    partial class CariSorgulama
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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnvanaGore = new System.Windows.Forms.TextBox();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbTumFirmalar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariler
            // 
            this.dgvCariler.AllowUserToAddRows = false;
            this.dgvCariler.AllowUserToDeleteRows = false;
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(41, 151);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.ReadOnly = true;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(464, 257);
            this.dgvCariler.TabIndex = 0;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ünvana Göre Arama";
            // 
            // txtUnvanaGore
            // 
            this.txtUnvanaGore.Location = new System.Drawing.Point(44, 90);
            this.txtUnvanaGore.Name = "txtUnvanaGore";
            this.txtUnvanaGore.Size = new System.Drawing.Size(100, 20);
            this.txtUnvanaGore.TabIndex = 2;
            this.txtUnvanaGore.TextChanged += new System.EventHandler(this.txtUnvanaGore_TextChanged);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Location = new System.Drawing.Point(215, 92);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(55, 17);
            this.rbAlicilar.TabIndex = 3;
            this.rbAlicilar.TabStop = true;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Location = new System.Drawing.Point(322, 93);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(62, 17);
            this.rbSaticilar.TabIndex = 4;
            this.rbSaticilar.TabStop = true;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbTumFirmalar
            // 
            this.rbTumFirmalar.AutoSize = true;
            this.rbTumFirmalar.Location = new System.Drawing.Point(420, 93);
            this.rbTumFirmalar.Name = "rbTumFirmalar";
            this.rbTumFirmalar.Size = new System.Drawing.Size(85, 17);
            this.rbTumFirmalar.TabIndex = 5;
            this.rbTumFirmalar.TabStop = true;
            this.rbTumFirmalar.Text = "Tüm Firmalar";
            this.rbTumFirmalar.UseVisualStyleBackColor = true;
            this.rbTumFirmalar.CheckedChanged += new System.EventHandler(this.rbTumFirmalar_CheckedChanged);
            // 
            // CariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 487);
            this.Controls.Add(this.rbTumFirmalar);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.txtUnvanaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCariler);
            this.Name = "CariSorgulama";
            this.Text = "CariSorgulama";
            this.Load += new System.EventHandler(this.CariSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnvanaGore;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbTumFirmalar;
    }
}