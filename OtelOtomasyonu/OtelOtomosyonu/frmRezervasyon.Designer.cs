namespace OtelOtomosyonu
{
    partial class frmRezervasyon
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
            this.mcGirisTarihi = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbExtralar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOnOdeme = new System.Windows.Forms.TextBox();
            this.txtGirisTarihi = new System.Windows.Forms.TextBox();
            this.txtCikisTarihi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chCheckOut = new System.Windows.Forms.CheckBox();
            this.chCheckIn = new System.Windows.Forms.CheckBox();
            this.txtOdaID = new System.Windows.Forms.TextBox();
            this.txtMAdSoyad = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKalanOdeme = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKatNo = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.mcCikisTarihi = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResepsiyonist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResepsiyonistAdSoyad = new System.Windows.Forms.TextBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.btnCikisTarihi = new System.Windows.Forms.Button();
            this.btnGirisTarihi = new System.Windows.Forms.Button();
            this.btnRezKaydet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcGirisTarihi
            // 
            this.mcGirisTarihi.BackColor = System.Drawing.SystemColors.Window;
            this.mcGirisTarihi.Location = new System.Drawing.Point(-45, 54);
            this.mcGirisTarihi.MaxSelectionCount = 14;
            this.mcGirisTarihi.Name = "mcGirisTarihi";
            this.mcGirisTarihi.TabIndex = 0;
            this.mcGirisTarihi.Visible = false;
            this.mcGirisTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcGirisCikisTarihi_DateChanged);
            this.mcGirisTarihi.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcGirisCikisTarihi_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giriş Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çıkış Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Oda Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(61, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "Oda Numarası:";
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNumarasi.Location = new System.Drawing.Point(177, 108);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(181, 20);
            this.txtOdaNumarasi.TabIndex = 14;
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Royal",
            "Deluxe",
            "Suit",
            "Family",
            "Economic",
            "Eco-Suit"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(177, 73);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(216, 22);
            this.cmbOdaTipi.TabIndex = 15;
            this.cmbOdaTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTipi_SelectedIndexChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(177, 214);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(216, 20);
            this.txtTutar.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(61, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tutar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(61, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 14);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ekstralar:";
            // 
            // cmbExtralar
            // 
            this.cmbExtralar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbExtralar.FormattingEnabled = true;
            this.cmbExtralar.Items.AddRange(new object[] {
            "Evcil Hayvan",
            "Spor",
            "Eğlence Aktiviteleri",
            "Oyun Odaları",
            "Ulaşım",
            "Araç Kiralama",
            "Güzellik Merkezi"});
            this.cmbExtralar.Location = new System.Drawing.Point(177, 160);
            this.cmbExtralar.Name = "cmbExtralar";
            this.cmbExtralar.Size = new System.Drawing.Size(216, 22);
            this.cmbExtralar.TabIndex = 20;
            this.cmbExtralar.Text = "Seçiniz";
            this.cmbExtralar.SelectedIndexChanged += new System.EventHandler(this.cmbExtralar_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(61, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 14);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ödeme Türü:";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(177, 187);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(216, 22);
            this.cmbOdemeTuru.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(61, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 14);
            this.label16.TabIndex = 23;
            this.label16.Text = "Ön Ödeme:";
            // 
            // txtOnOdeme
            // 
            this.txtOnOdeme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOnOdeme.Location = new System.Drawing.Point(178, 240);
            this.txtOnOdeme.Name = "txtOnOdeme";
            this.txtOnOdeme.Size = new System.Drawing.Size(216, 20);
            this.txtOnOdeme.TabIndex = 24;
            this.txtOnOdeme.TextChanged += new System.EventHandler(this.txtOnOdeme_TextChanged);
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarihi.Location = new System.Drawing.Point(261, 54);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.Size = new System.Drawing.Size(123, 20);
            this.txtGirisTarihi.TabIndex = 32;
            // 
            // txtCikisTarihi
            // 
            this.txtCikisTarihi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikisTarihi.Location = new System.Drawing.Point(501, 54);
            this.txtCikisTarihi.Name = "txtCikisTarihi";
            this.txtCikisTarihi.Size = new System.Drawing.Size(123, 20);
            this.txtCikisTarihi.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.chCheckOut);
            this.groupBox2.Controls.Add(this.chCheckIn);
            this.groupBox2.Controls.Add(this.txtOdaID);
            this.groupBox2.Controls.Add(this.txtMAdSoyad);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtMusteriID);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtKalanOdeme);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtKatNo);
            this.groupBox2.Controls.Add(this.cmbOdaTipi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtOdaNumarasi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbExtralar);
            this.groupBox2.Controls.Add(this.btnYeni);
            this.groupBox2.Controls.Add(this.txtOnOdeme);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbOdemeTuru);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 406);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervasyon Bilgileri";
            // 
            // chCheckOut
            // 
            this.chCheckOut.AutoSize = true;
            this.chCheckOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.chCheckOut.Location = new System.Drawing.Point(178, 315);
            this.chCheckOut.Name = "chCheckOut";
            this.chCheckOut.Size = new System.Drawing.Size(82, 18);
            this.chCheckOut.TabIndex = 45;
            this.chCheckOut.Text = "Check out";
            this.chCheckOut.UseVisualStyleBackColor = true;
            // 
            // chCheckIn
            // 
            this.chCheckIn.AutoSize = true;
            this.chCheckIn.Checked = true;
            this.chCheckIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCheckIn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.chCheckIn.Location = new System.Drawing.Point(178, 292);
            this.chCheckIn.Name = "chCheckIn";
            this.chCheckIn.Size = new System.Drawing.Size(74, 18);
            this.chCheckIn.TabIndex = 44;
            this.chCheckIn.Text = "Check in";
            this.chCheckIn.UseVisualStyleBackColor = true;
            // 
            // txtOdaID
            // 
            this.txtOdaID.BackColor = System.Drawing.Color.SteelBlue;
            this.txtOdaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaID.Location = new System.Drawing.Point(31, 110);
            this.txtOdaID.Name = "txtOdaID";
            this.txtOdaID.Size = new System.Drawing.Size(24, 20);
            this.txtOdaID.TabIndex = 41;
            this.txtOdaID.Visible = false;
            // 
            // txtMAdSoyad
            // 
            this.txtMAdSoyad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMAdSoyad.Location = new System.Drawing.Point(176, 42);
            this.txtMAdSoyad.Name = "txtMAdSoyad";
            this.txtMAdSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtMAdSoyad.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(61, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 14);
            this.label25.TabIndex = 41;
            this.label25.Text = "Müşteri Adı Soyadı:";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BackColor = System.Drawing.Color.SteelBlue;
            this.txtMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriID.Location = new System.Drawing.Point(31, 43);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(24, 20);
            this.txtMusteriID.TabIndex = 40;
            this.txtMusteriID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::OtelOtomosyonu.Properties.Resources.ileri;
            this.button1.Location = new System.Drawing.Point(357, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 20);
            this.button1.TabIndex = 38;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKalanOdeme
            // 
            this.txtKalanOdeme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanOdeme.Location = new System.Drawing.Point(178, 266);
            this.txtKalanOdeme.Name = "txtKalanOdeme";
            this.txtKalanOdeme.Size = new System.Drawing.Size(216, 20);
            this.txtKalanOdeme.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(61, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 14);
            this.label20.TabIndex = 27;
            this.label20.Text = "Kalan:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAra.Image = global::OtelOtomosyonu.Properties.Resources.search;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(306, 345);
            this.btnAra.Name = "btnAra";
            this.btnAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAra.Size = new System.Drawing.Size(68, 37);
            this.btnAra.TabIndex = 37;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(61, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 14);
            this.label19.TabIndex = 25;
            this.label19.Text = "Kat:";
            // 
            // txtKatNo
            // 
            this.txtKatNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKatNo.Location = new System.Drawing.Point(177, 134);
            this.txtKatNo.Name = "txtKatNo";
            this.txtKatNo.Size = new System.Drawing.Size(216, 20);
            this.txtKatNo.TabIndex = 26;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYeni.Image = global::OtelOtomosyonu.Properties.Resources.User;
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.Location = new System.Drawing.Point(204, 345);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(83, 37);
            this.btnYeni.TabIndex = 6;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // mcCikisTarihi
            // 
            this.mcCikisTarihi.BackColor = System.Drawing.SystemColors.Window;
            this.mcCikisTarihi.Location = new System.Drawing.Point(675, 54);
            this.mcCikisTarihi.MaxSelectionCount = 14;
            this.mcCikisTarihi.Name = "mcCikisTarihi";
            this.mcCikisTarihi.TabIndex = 40;
            this.mcCikisTarihi.Visible = false;
            this.mcCikisTarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCikisTarihi_DateChanged);
            this.mcCikisTarihi.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcCikisTarihi_DateSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(201, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 397);
            this.panel1.TabIndex = 41;
            // 
            // txtResepsiyonist
            // 
            this.txtResepsiyonist.BackColor = System.Drawing.Color.SteelBlue;
            this.txtResepsiyonist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResepsiyonist.Location = new System.Drawing.Point(261, 12);
            this.txtResepsiyonist.Name = "txtResepsiyonist";
            this.txtResepsiyonist.Size = new System.Drawing.Size(24, 20);
            this.txtResepsiyonist.TabIndex = 42;
            this.txtResepsiyonist.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "Resepsiyonist:";
            // 
            // txtResepsiyonistAdSoyad
            // 
            this.txtResepsiyonistAdSoyad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResepsiyonistAdSoyad.Location = new System.Drawing.Point(398, 11);
            this.txtResepsiyonistAdSoyad.Name = "txtResepsiyonistAdSoyad";
            this.txtResepsiyonistAdSoyad.Size = new System.Drawing.Size(166, 20);
            this.txtResepsiyonistAdSoyad.TabIndex = 44;
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonelAra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPersonelAra.Location = new System.Drawing.Point(560, 11);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(29, 21);
            this.btnPersonelAra.TabIndex = 45;
            this.btnPersonelAra.Text = "...";
            this.btnPersonelAra.UseVisualStyleBackColor = false;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // btnCikisTarihi
            // 
            this.btnCikisTarihi.BackgroundImage = global::OtelOtomosyonu.Properties.Resources.calendar_add;
            this.btnCikisTarihi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikisTarihi.FlatAppearance.BorderSize = 0;
            this.btnCikisTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisTarihi.Location = new System.Drawing.Point(625, 54);
            this.btnCikisTarihi.Name = "btnCikisTarihi";
            this.btnCikisTarihi.Size = new System.Drawing.Size(25, 23);
            this.btnCikisTarihi.TabIndex = 34;
            this.btnCikisTarihi.UseVisualStyleBackColor = true;
            this.btnCikisTarihi.Click += new System.EventHandler(this.btnCikisTarihi_Click);
            // 
            // btnGirisTarihi
            // 
            this.btnGirisTarihi.BackgroundImage = global::OtelOtomosyonu.Properties.Resources.calendar_add;
            this.btnGirisTarihi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGirisTarihi.FlatAppearance.BorderSize = 0;
            this.btnGirisTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisTarihi.Location = new System.Drawing.Point(382, 54);
            this.btnGirisTarihi.Name = "btnGirisTarihi";
            this.btnGirisTarihi.Size = new System.Drawing.Size(32, 23);
            this.btnGirisTarihi.TabIndex = 31;
            this.btnGirisTarihi.UseVisualStyleBackColor = true;
            this.btnGirisTarihi.Click += new System.EventHandler(this.btnGirisTarihi_Click);
            // 
            // btnRezKaydet
            // 
            this.btnRezKaydet.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRezKaydet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezKaydet.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRezKaydet.Image = global::OtelOtomosyonu.Properties.Resources.save1;
            this.btnRezKaydet.Location = new System.Drawing.Point(382, 531);
            this.btnRezKaydet.Name = "btnRezKaydet";
            this.btnRezKaydet.Size = new System.Drawing.Size(154, 62);
            this.btnRezKaydet.TabIndex = 6;
            this.btnRezKaydet.Text = "Rezervasyonu Kaydet";
            this.btnRezKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezKaydet.UseVisualStyleBackColor = false;
            this.btnRezKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(915, 605);
            this.Controls.Add(this.btnPersonelAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResepsiyonistAdSoyad);
            this.Controls.Add(this.txtResepsiyonist);
            this.Controls.Add(this.mcCikisTarihi);
            this.Controls.Add(this.btnCikisTarihi);
            this.Controls.Add(this.txtCikisTarihi);
            this.Controls.Add(this.txtGirisTarihi);
            this.Controls.Add(this.btnGirisTarihi);
            this.Controls.Add(this.btnRezKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcGirisTarihi);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmRezervasyon";
            this.Text = "Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcGirisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRezKaydet;
        private System.Windows.Forms.TextBox txtOdaNumarasi;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbExtralar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOnOdeme;
        private System.Windows.Forms.Button btnGirisTarihi;
        private System.Windows.Forms.TextBox txtGirisTarihi;
        private System.Windows.Forms.TextBox txtCikisTarihi;
        private System.Windows.Forms.Button btnCikisTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKalanOdeme;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.TextBox txtOdaID;
        private System.Windows.Forms.TextBox txtMAdSoyad;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKatNo;
        private System.Windows.Forms.MonthCalendar mcCikisTarihi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chCheckOut;
        private System.Windows.Forms.CheckBox chCheckIn;
        private System.Windows.Forms.TextBox txtResepsiyonist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResepsiyonistAdSoyad;
        private System.Windows.Forms.Button btnPersonelAra;
    }
}