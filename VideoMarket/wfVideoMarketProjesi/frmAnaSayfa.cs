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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mitmFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTurleri frm = new frmFilmTurleri();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }
        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); //Kullanılmayacağı için oluşturduğumuz Acilacakform nesnesini hafızadan atıyoruz.
            }
        }

        private void mitmFilmTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmler frm = new frmFilmler();
            FormAcikmi(frm);
        }

        private void mitmFilmSorgulama_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            FormAcikmi(frm);
        }

        private void mitmMusteriTanimlama_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            FormAcikmi(frm);
        }

        private void mitmMusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            FormAcikmi(frm);
        }

        private void mitmFilmSatis_Click(object sender, EventArgs e)
        {
            frmFilmSatis frm = new frmFilmSatis();
            FormAcikmi(frm);
        }

        private void mitmSatisSorgulama_Click(object sender, EventArgs e)
        {
            frmSatisSorgulama frm = new frmSatisSorgulama();
            FormAcikmi(frm);
        }

        private void mitmDetayliSatisRaporu_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
            FormAcikmi(frm);
        }
    }
}
