using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriID.Text = Genel.MstrID.ToString();
            txtMAdSoyad.Text = Genel.MustrAd + " " + Genel.MustrSoyad;
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            frmOdaSorgulama frm = new frmOdaSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtOdaID.Text = Genel.OdaId.ToString();
            txtOdaNumarasi.Text = Genel.OdaNumarasi;
            txtKatNo.Text = Genel.Kat;
        }

        private void btnRezKaydet_Click(object sender, EventArgs e)
        {
            Rezervasyon rez = new Rezervasyon();
            txtMusteriID.Text = rez.MusteriID.ToString();
            txtOdaID.Text = rez.OdaID.ToString();

            if (chCheckOut.Checked == true)
            {
                rez.Durum = false;

            }
            else
            {
                rez.Durum = true;
            }
            if (rez.RezervasyonEkle(rez))
            {
                MessageBox.Show("Check out işlemi tamamlandı.");
                
            }
            
        }

        
    }
}
