using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int yeniRezervasyonID;
        Musteriler mstr = new Musteriler();
        frmOdaSorgulama oda = new frmOdaSorgulama();

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            this.Top = 10;
            this.Left=30;
          //  txtRezervasyonID.Text = "Rzrv-" + rnd.Next(1000, 10000).ToString();
        }

        private void btnGirisTarihi_Click(object sender, EventArgs e)
        {
            mcGirisTarihi.Visible = true;
            mcGirisTarihi.Top = 127;
            mcGirisTarihi.Left = 147;
            mcGirisTarihi.Show();
        }

        private void mcGirisCikisTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtGirisTarihi.Text = mcGirisTarihi.SelectionStart.ToShortDateString();
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            //btnYeni.Text = "Kaydet";
            //btnYeni.BackColor = Color.Blue;
            //btnYeni.TextAlign = ContentAlignment.MiddleRight;
            //btnYeni.Image = Properties.Resources.useradd;
            //btnYeni.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOdaSorgulama frm = new frmOdaSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtOdaID.Text = Genel.OdaId.ToString();
            txtOdaNumarasi.Text = Genel.OdaNumarasi;
            txtKatNo.Text = Genel.Kat;
            //frm.Top = 10;
            //frm.Left = 230;
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriID.Text = Genel.MstrID.ToString();
            txtMAdSoyad.Text = Genel.MustrAd + " " + Genel.MustrSoyad;

        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            frmPersonelAra frm = new frmPersonelAra();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtResepsiyonist.Text = Genel.PersonelID.ToString();
            txtResepsiyonistAdSoyad.Text = Genel.PersAd + " " + Genel.PersSoyad;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Rezervasyon r = new Rezervasyon();
            r.CalisanID = Genel.PersonelID;
            r.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            r.GirisTarihi = Convert.ToDateTime(mcGirisTarihi.SelectionRange.Start.ToShortDateString());
            r.CikisTarihi = Convert.ToDateTime(mcCikisTarihi.SelectionRange.End.ToShortDateString());
            r.RezervasyonTarihi = Convert.ToDateTime(mcGirisTarihi.SelectionRange.Start.ToShortDateString());
            r.OdaID = Convert.ToInt32(txtOdaID.Text);
            r.OdaNumarasi = Convert.ToInt32(txtOdaNumarasi.Text);
            r.Tutar = Convert.ToDecimal(txtTutar.Text);
            r.OnOdeme = Convert.ToDecimal(txtOnOdeme.Text);
            r.Kalan = r.Tutar - r.OnOdeme;
            if (chCheckIn.Checked==true)
            {
                r.Durum = true;
                
            }
            else
            {
                r.Durum = false;
            }
            if (r.RezervasyonEkle(r))
            {
                MessageBox.Show("Rezervasyon bilgileri eklendi");
                frmTahsilatEkranı frm = new frmTahsilatEkranı();
                frm.Show();
            }
            else MessageBox.Show("Rezervasyon bilgileri eklenemedi");

            
            txtMAdSoyad.Text = Genel.Musteri;
            txtTutar.Text = Genel.Tutar.ToString();
            txtOnOdeme.Text = Genel.OnOdeme.ToString();
            txtKalanOdeme.Text = Genel.Kalan.ToString();


            
        }


        //private void btnCikisTarihi_Click(object sender, EventArgs e)
        //{
        //    mcGirisCikisTarihi.Show();
        //}

        private void mcGirisCikisTarihi_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcGirisTarihi.Hide();
        }

        private void btnCikisTarihi_Click(object sender, EventArgs e)
        {
            mcCikisTarihi.Top = 97;
            mcCikisTarihi.Left = 668;
            mcCikisTarihi.Show();
        }

        private void mcCikisTarihi_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcCikisTarihi.Hide();
        }

        private void mcCikisTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtCikisTarihi.Text = mcCikisTarihi.SelectionEnd.ToShortDateString();
        }

      

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string odaTipi = cmbOdaTipi.SelectedItem.ToString();
            Rezervasyon rez = new Rezervasyon();
            txtTutar.Text= rez.FiyatGetir(cmbOdaTipi).ToString();
        }

        private void txtOnOdeme_TextChanged(object sender, EventArgs e)
        {
            if (txtOnOdeme.Text != "")
            {
                txtKalanOdeme.Text = (Convert.ToDouble(txtTutar.Text) - Convert.ToDouble(txtOnOdeme.Text)).ToString();
            }
            if (txtOnOdeme.Text == "")
            {
                txtOnOdeme.Text = "0";
            }
           
        }

        private void cmbExtralar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ekstralar ekstra = new Ekstralar();
            //int fiyat = Convert.ToInt32(txtTutar.Text);
            double toplam = 0;
            //toplam=fiyat+ekstra.EkstraFiyat(cmbExtralar);
            Rezervasyon rez = new Rezervasyon();

            toplam = rez.FiyatGetir(cmbOdaTipi) + ekstra.EkstraFiyat(cmbExtralar);
            txtTutar.Text = toplam.ToString();
        }

   


     

    }
}
