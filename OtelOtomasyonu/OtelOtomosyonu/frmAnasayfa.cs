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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        frmGiris frm = (frmGiris)Application.OpenForms["frmGiris"];
        

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void persToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelKayit frm = new frmPersonelKayit();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void müşteriKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void tahsilatEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTahsilatEkranı frm = new frmTahsilatEkranı();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void odaSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdaSorgulama frm = new frmOdaSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEkstralar frm = new frmEkstralar();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void müşteriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            if (frm.yetki == "1")
            {
                calisanlarToolStripMenuItem.Enabled = false;
                raporlamaToolStripMenuItem.Enabled = false;

            }

            if (frm.yetki == "2")
            {
                calisanlarToolStripMenuItem.Enabled = false;
                ekstraEkleToolStripMenuItem.Enabled = false;
            }

            if (frm.yetki == "3")
            {
                menuStrip1.Enabled = true;
            }
            Odalar oda = new Odalar();
            txtBosOdaSayisi.Text = oda.BosOdaSayisi().ToString();
            txtDoluOdaSayisi.Text = oda.DoluOdaSayisi().ToString();
            txtCikacakOdaSayisi.Text = oda.CikacakOdaSayisi().ToString();
        }
    }
}
