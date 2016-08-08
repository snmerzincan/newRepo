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
    public partial class frmPersonelAra : Form
    {
        public frmPersonelAra()
        {
            InitializeComponent();
        }

        Personel prs = new Personel();
       

        private void frmPersonelAra_Load(object sender, EventArgs e)
        {
            prs.PersonelleriGetir(lvPersoneller);
        }

        private void txtPersAd_TextChanged(object sender, EventArgs e)
        {
            prs.PersonelGetirDetayliSorgulama(txtPersAd.Text, txtPersSoyad.Text, txtTCKimlikNo.Text, txtDepartman.Text, lvPersoneller);
        }

        private void txtPersSoyad_TextChanged(object sender, EventArgs e)
        {
            prs.PersonelGetirDetayliSorgulama(txtPersAd.Text, txtPersSoyad.Text, txtTCKimlikNo.Text, txtDepartman.Text, lvPersoneller);
        }

        private void txtTCKimlikNo_TextChanged(object sender, EventArgs e)
        {
            prs.PersonelGetirDetayliSorgulama(txtPersAd.Text, txtPersSoyad.Text, txtTCKimlikNo.Text, txtDepartman.Text, lvPersoneller);
        }

        private void txtDepartman_TextChanged(object sender, EventArgs e)
        {
            prs.PersonelGetirDetayliSorgulama(txtPersAd.Text, txtPersSoyad.Text, txtTCKimlikNo.Text, txtDepartman.Text, lvPersoneller);
        }

        private void lvPersoneller_DoubleClick(object sender, EventArgs e)
        {
            //frmRezervasyon rez = (frmRezervasyon)Application.OpenForms["rez"];
            Genel.PersonelID = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[0].Text); 
            Genel.PersAd = lvPersoneller.SelectedItems[0].SubItems[1].Text;
            Genel.PersSoyad= lvPersoneller.SelectedItems[0].SubItems[2].Text;
            this.Close();
            
          
        }
    }
}
