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
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }

        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteri.Text = cGenel.musteri;
            txtMusteriNo.Text = cGenel.musterino.ToString();
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtFilmNo.Text = cGenel.filmno.ToString();
            txtFilm.Text = cGenel.filmadi;
            txtFiyat.Text = cGenel.fiyat.ToString();
            txtStok.Text = cGenel.stok.ToString();
            txtAdet.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnFilmBul.Enabled = true;
            btnMusteriBul.Enabled = true;
            btnKaydet.Enabled = true;
            Temizle();
        }
        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtFilm.Clear();
            txtFilmNo.Clear();
            txtStok.Clear();
            txtFilm.Focus();
        }
        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, 2);
                //txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, 3);
            }   
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, 2);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, 3);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriNo.Text) || string.IsNullOrEmpty(txtFilmNo.Text))
            {
                MessageBox.Show("Öncelikle Müşteri ve Film seçilmelidir!", "DİKKAT!, Eksik Bilgi!");
            }
            else
            {
                if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
                {
                    MessageBox.Show("Stok yeterli değil!", "Dikkat! Stok Eksik!");
                    txtAdet.Text = txtStok.Text;
                    txtAdet.Focus();
                }
                else
                {
                    cFilmSatis fs = new cFilmSatis();
                    fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                    fs.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    fs.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    fs.Adet = Convert.ToInt32(txtAdet.Text);
                    fs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                    if (fs.SatisEkle(fs))
                    {
                        MessageBox.Show("Satış Bilgileri kayıt edildi.");
                        cFilm f = new cFilm();
                        bool Sonuc = f.StokGuncelleBySatisEkle(fs.FilmNo, fs.Adet);
                        if (Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi.");
                            Temizle();
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            btnKaydet.Enabled = false;
                            btnMusteriBul.Enabled = false;
                            btnFilmBul.Enabled = false;
                        }
                        else { MessageBox.Show("Stok güncellenirken hata oluştu!"); }
                    }
                    else
                    {
                        MessageBox.Show("Satış Bilgileri kayıt edilemedi!","there is a problem!!");
                    }
                }
            }
        }

        private void lvSatislar_DoubleClick(object sender, EventArgs e)
        {
            txtSatisNo.Text = lvSatislar.SelectedItems[0].SubItems[0].Text;
            //txtTarih.Text = lvSatislar.SelectedItems[0].SubItems[1].Text;
            txtFilm.Text = lvSatislar.SelectedItems[0].SubItems[2].Text;
            txtFilmNo.Text = lvSatislar.SelectedItems[0].SubItems[7].Text;
            txtMusteri.Text = lvSatislar.SelectedItems[0].SubItems[3].Text;
            txtMusteriNo.Text = lvSatislar.SelectedItems[0].SubItems[8].Text;
            txtFiyat.Text = lvSatislar.SelectedItems[0].SubItems[4].Text;
            txtAdet.Text = lvSatislar.SelectedItems[0].SubItems[5].Text;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                if(fs.SatisIptal(Convert.ToInt32(txtSatisNo.Text)))
                {
                    MessageBox.Show("Satış iptal edildi!");

                    cFilm f = new cFilm();
                    bool Sonuc = f.StokGuncelleBySatisIptal(Convert.ToInt32(txtFilmNo.Text), Convert.ToInt32(txtAdet.Text));
                    if (Sonuc)
                    {
                        MessageBox.Show("Stok Güncellendi.");
                        btnSil.Enabled = false;
                        Temizle();
                        fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                    }
                }
            }
        }
    }
}
