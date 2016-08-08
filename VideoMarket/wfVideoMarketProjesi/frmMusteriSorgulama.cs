using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }
        cMusteri m = new cMusteri();

        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            m.MusterileriGetir(lvMusteriler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama(txtAdaGore.Text, txtSoyadinaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtSoyadinaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama(txtAdaGore.Text, txtSoyadinaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtTelefonaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama(txtAdaGore.Text, txtSoyadinaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtAdreseGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama(txtAdaGore.Text, txtSoyadinaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.musterino = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
            cGenel.musteri = lvMusteriler.SelectedItems[0].SubItems[1].Text + " " + lvMusteriler.SelectedItems[0].SubItems[2].Text;
            this.Close();
        }


    }
}
