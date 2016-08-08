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
    public partial class frmFilmTurleri : Form
    {
        public frmFilmTurleri()
        {
            InitializeComponent();
        }

        private void frmFilmTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(lvFilmTurleri);
        }

        private void lvFilmTurleri_DoubleClick(object sender, EventArgs e)
        {
            txtTurNo.Text = lvFilmTurleri.SelectedItems[0].SubItems[0].Text;
            txtFilmTuru.Text = lvFilmTurleri.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTurleri.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtFilmTuru.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruGuncelle(Convert.ToInt32(txtTurNo.Text), txtFilmTuru.Text, txtAciklama.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü güncellendi.");
                    ft.FilmTurleriGetir(lvFilmTurleri);
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                }
            }
        }
        private void Temizle()
        {
            txtTurNo.Clear();
            txtFilmTuru.Clear();
            txtAciklama.Clear();
            txtFilmTuru.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruSil(Convert.ToInt32(txtTurNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü silindi.");
                    ft.FilmTurleriGetir(lvFilmTurleri);
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                if (ft.FilmTuruVarmi(txtFilmTuru.Text))
                {
                    MessageBox.Show("Önceden kayıtlı");
                    txtFilmTuru.Focus();
                }
                else
                {
                    //bool Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    bool Sonuc = ft.FilmTuruEkle(ft);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film Türü eklendi.");
                        ft.FilmTurleriGetir(lvFilmTurleri);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                }
            }
        }
    }
}
