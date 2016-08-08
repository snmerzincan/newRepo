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
    public partial class frmOdaDuzenleme : Form
    {
        public frmOdaDuzenleme()
        {
            InitializeComponent();
        }
         Odalar oda = new Odalar();
       
        private void cmbOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
            int odaNo=Convert.ToInt32(cmbOdalar.SelectedItem.ToString());
            oda.OdaBilgileri(odaNo,lwOdaBilgileri);
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        private void lwOdaBilgileri_DoubleClick(object sender, EventArgs e)
        {
            txtOdaID.Text=lwOdaBilgileri.SelectedItems[0].SubItems[0].Text;
            txtOdaNo.Text = lwOdaBilgileri.SelectedItems[0].SubItems[1].Text;
            txtOdaDurum.Text = lwOdaBilgileri.SelectedItems[0].SubItems[3].Text;
            //if (Convert.ToBoolean(lwOdaBilgileri.SelectedItems[0].SubItems[3].Text) == false)
            //{
            //    lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            //    txtOdaDurum.Text = lwOdaBilgileri.SelectedItems[0].SubItems[3].Text;
            //}
            //else
            //{
            //    lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            //    txtOdaDurum.Text = lwOdaBilgileri.SelectedItems[0].SubItems[3].Text;
            //}
            //txtOdaTip.Text = lwOdaBilgileri.SelectedItems[0].SubItems[4].Text;
            //txtYatakSayisi.Text = lwOdaBilgileri.SelectedItems[0].SubItems[5].Text;
            //txtFiyat.Text = lwOdaBilgileri.SelectedItems[0].SubItems[6].Text;
            //txtAciklama.Text = lwOdaBilgileri.SelectedItems[0].SubItems[7].Text;

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            Odalar oda = new Odalar();
            oda.OdaNumarasi = Convert.ToInt32(txtOdaNo.Text);
            oda.Durum = Convert.ToBoolean(txtOdaDurum.Text);
            if (oda.OdaDurumuGüncelle(oda))
            {
                MessageBox.Show("Durum Güncellendi");
                
            }
            else
            {
                MessageBox.Show("Durum Güncellenemedi");

            }
        }

       
    }
}
