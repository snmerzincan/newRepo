using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfStokTakibi.Model;

namespace wfStokTakibi
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

        private void mitmUrunKartlari_Click(object sender, EventArgs e)
        {
            Genel.urunsayfano = 0;
            UrunKartlari frm = new UrunKartlari();
            FormAcikmi(frm);
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

        private void mitmStokSorgulama_Click(object sender, EventArgs e)
        {
            Genel.urunsayfano = 2;
            UrunKartlari frm = new UrunKartlari();
            FormAcikmi(frm);
        }

        private void mitmStokGirisCikis_Click(object sender, EventArgs e)
        {
            Genel.urunsayfano = 1;
            UrunKartlari frm = new UrunKartlari();
            FormAcikmi(frm);
        }

        private void mitmGunlukKasa_Click(object sender, EventArgs e)
        {
            KasaIslemleri frm = new KasaIslemleri();
            FormAcikmi(frm);
        }

        private void mitmCariEkstre_Click(object sender, EventArgs e)
        {
            MusteriCariEkstre frm = new MusteriCariEkstre();
            FormAcikmi(frm);
        }
    }
}
