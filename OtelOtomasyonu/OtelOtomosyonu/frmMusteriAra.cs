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
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }
        Musteriler m = new Musteriler();
       

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            m.MusterileriGetir(lvMusteriler);
        }


        private void txtMAd_TextChanged_1(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusterileriGetirAdaGore(txtMAd.Text, lvMusteriler);
        }

        private void txtMSoyad_TextChanged_1(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusterileriGetirSoyadaGore(txtMSoyad.Text, lvMusteriler);
        }

        private void txtTCKimlikNo_TextChanged_1(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusterileriGetirTCyeGore(txtTCKimlikNo.Text, lvMusteriler);
            //m.MusterileriGetirDetayliSorgulama(txtMAd.Text, txtMSoyad.Text, txtTCKimlikNo.Text, mtxtTelefon.Text, lvMusteriler);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            Genel.MstrID= Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text); 
            Genel.MustrAd = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            Genel.MustrSoyad = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            Genel.TCKimlikNo = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            Genel.OdaId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
            this.Close();
       

        }

       

    }
}
