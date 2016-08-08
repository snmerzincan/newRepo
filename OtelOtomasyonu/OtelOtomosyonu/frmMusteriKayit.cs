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
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtMAd.Text.Trim() != "" && txtMSoyad.Text.Trim() != "" && txtTCKimlikNo.Text.Trim() != "" && mtxtTelefon.Text != "")
            {
                Musteriler m = new Musteriler();
                m.MusteriAd = txtMAd.Text.ToString();
                m.MusteriSoyad = txtMSoyad.Text.ToString();
                m.TcNo = txtTCKimlikNo.Text.ToString();
                m.Telefon = mtxtTelefon.Text.ToString();
                m.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
                m.EMail = txtEmail.Text.ToString();
                m.Adres = txtAdres.Text.ToString();

                if (m.MusteriEkle(m))
                {
                    MessageBox.Show("Müşteri bilgileri kayıt edildi.");
                    m.MusterilerinTumBilgileriniGetir(lvMusteriBilgileri);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri bilgileri eklenemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen * ile belirtilen alanları boş bırakmayınız.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtMAd.Focus();
        }

        public void Temizle()
        {
            txtMAd.Clear();
            txtMSoyad.Clear();
            txtTCKimlikNo.Clear();
            mtxtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();

        }

        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            this.Top = 30;
            this.Left = 50;
            Musteriler m = new Musteriler();
            m.MusterilerinTumBilgileriniGetir(lvMusteriBilgileri);
        }

        private void lvMusteriBilgileri_DoubleClick(object sender, EventArgs e)
        {
            txtMusteriID.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[0].Text;
            txtMAd.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[1].Text;
            txtMSoyad.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[2].Text;
            txtTCKimlikNo.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[3].Text;
            mtxtTelefon.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[4].Text;
            txtEmail.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[6].Text;
            txtAdres.Text = lvMusteriBilgileri.SelectedItems[0].SubItems[7].Text;
            txtMAd.Focus();


        }

        private void txtDuzenle_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();

            m.MusteriID = Convert.ToInt32(txtMusteriID.Text);
            m.MusteriAd = txtMAd.Text.ToString();
            m.MusteriSoyad = txtMSoyad.Text.ToString();
            m.TcNo = txtTCKimlikNo.Text.ToString();
            m.Telefon = mtxtTelefon.Text.ToString();
            m.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
            m.EMail = txtEmail.Text.ToString();
            m.Adres = txtAdres.Text.ToString();
            if (m.MusteriBilgileriGuncelle(m))
            {
                MessageBox.Show("Müşteri bilgileri güncellendi.");
                m.MusterilerinTumBilgileriniGetir(lvMusteriBilgileri);
                Temizle();
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri güncellenemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriID = Convert.ToInt32(txtMusteriID.Text);

            if (m.MusteriSil(m))
            {
                MessageBox.Show("Müşteri bilgileri silindi.");
                m.MusterilerinTumBilgileriniGetir(lvMusteriBilgileri);
                Temizle();
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri silinemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}


