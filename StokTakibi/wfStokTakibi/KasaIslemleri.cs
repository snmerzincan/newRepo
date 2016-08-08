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
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri()
        {
            InitializeComponent();
        }

        private void KasaIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            //İşlem tarihine kadar olan devirler gösterilmeli...
            Kasa k = new Kasa();
            k.KasaDevirleriGetir(txtTarih.Text, txtDevirGiren, txtDevirCikan, txtDevirBakiye);
            //İşlem tarihindeki kasa hareketleri listelenmeli...
            k.KasaHareketleriGetir(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
            //CariSorgulamadan firma seçtirilir.
            if (txtIslemTuru.Text == "Ödeme")
            {
                Genel.caritipi = "Satıcı";
            }
            else if (txtIslemTuru.Text == "Tahsilat")
            {
                Genel.caritipi = "Alıcı";
            }
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtCariNo.Text = Genel.carino.ToString();
            txtCariUnvan.Text = Genel.cariunvan;
            txtBelge.Focus();
            //Giren-Cikan readonly özelliklerini ayarla.
            if (cbIslemTurleri.SelectedItem.ToString() == "Tahsilat")
            {
                txtGiren.ReadOnly = false;
                txtCikan.ReadOnly = true;
            }
            else if (cbIslemTurleri.SelectedItem.ToString() == "Ödeme")
            {
                txtGiren.ReadOnly = true;
                txtCikan.ReadOnly = false;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtID.Clear();
            txtIslemTarihi.Text = txtTarih.Text;
            txtIslemTuru.Clear();
            txtCariUnvan.Clear();
            txtCariNo.Clear();
            txtBelge.Clear();
            txtGiren.Text = "0";
            txtCikan.Text = "0";
            txtIslemTuru.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIslemTuru.Text.Trim() != "" && txtCariUnvan.Text.Trim() != "")
            {
                if (txtGiren.Text == "0" && txtCikan.Text == "0")
                {
                    MessageBox.Show("Tutar girmelisiniz!");
                    txtGiren.Focus();
                }
                else
                {
                    Kasa k = new Kasa();
                    k.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                    k.IslemTuru = txtIslemTuru.Text;
                    k.CariNo = Convert.ToInt32(txtCariNo.Text);
                    k.Belge = txtBelge.Text;
                    k.Giren = Convert.ToDouble(txtGiren.Text);
                    k.Cikan = Convert.ToDouble(txtCikan.Text);
                    int kayitno = k.KasaHareketEkle(k);
                    if (kayitno > 0)
                    {
                        MessageBox.Show("Kasa hareketi eklendi.");
                        k.KasaHareketleriGetir(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
                        //CariHareket eklenecek.
                        CariHareket ch = new CariHareket();
                        ch.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                        ch.IslemTuru = txtIslemTuru.Text;
                        ch.CariNo = Convert.ToInt32(txtCariNo.Text);
                        ch.Belge = txtBelge.Text;
                        if (txtIslemTuru.Text == "Tahsilat")
                        {
                            ch.Borc = Convert.ToDouble(txtCikan.Text);
                            ch.Alacak = Convert.ToDouble(txtGiren.Text);
                        }
                        else if (txtIslemTuru.Text == "Ödeme")
                        {
                            ch.Borc = Convert.ToDouble(txtCikan.Text);
                            ch.Alacak = Convert.ToDouble(txtGiren.Text);
                        }
                        ch.KasaHareketID = kayitno;
                        ch.UrunHareketID = 0;
                        if (ch.CariHareketEkle(ch))
                        {
                            MessageBox.Show("Cari hareket eklendi!");
                            //Cari Toplamlar güncellenmeli...
                            Cari c = new Cari();
                            bool Sonuc = c.CariToplamlariGuncelle(ch.CariNo, ch.Borc, ch.Alacak);
                            if (Sonuc)
                            {
                                MessageBox.Show("Cari toplamlar güncellendi!");
                                Temizle();
                                btnKaydet.Enabled = false;
                            }
                            else { MessageBox.Show("Cari toplamlar değiştirilemedi!"); }
                        }
                        else { MessageBox.Show("Cari Hareket eklenemedi!"); }
                    }
                }
            }
            else { MessageBox.Show("İşlem Türü, Cari Ünvan seçili olmalıdır."); }
        }
        private void lvHareketler_DoubleClick(object sender, EventArgs e)
        {
            //btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtID.Text = lvHareketler.SelectedItems[0].SubItems[0].Text;
            txtIslemTarihi.Text = lvHareketler.SelectedItems[0].SubItems[1].Text;
            txtIslemTuru.Text = lvHareketler.SelectedItems[0].SubItems[2].Text;
            txtCariUnvan.Text = lvHareketler.SelectedItems[0].SubItems[3].Text;
            txtCariNo.Text = lvHareketler.SelectedItems[0].SubItems[8].Text;
            txtBelge.Text = lvHareketler.SelectedItems[0].SubItems[4].Text;
            txtGiren.Text = lvHareketler.SelectedItems[0].SubItems[5].Text;
            txtCikan.Text = lvHareketler.SelectedItems[0].SubItems[6].Text;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kasa hareketini iptal edicek misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Kasa k = new Kasa();
                bool Sonuc = k.KasaHareketSil(Convert.ToInt32(txtID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Kasa hareketi silindi!");
                    k.KasaHareketleriGetir(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
                    //CariHareket silinmeli...
                    CariHareket ch = new CariHareket();
                    if (ch.CariHareketSilFromKasaHareket(Convert.ToInt32(txtID.Text)))
                    {
                        MessageBox.Show("Cari hareket silindi!");
                        //Cari Toplamlar güncellenmeli...
                        double Borc = 0;
                        double Alacak = 0;
                        if (txtIslemTuru.Text == "Tahsilat")
                        {
                            Borc = 0;
                            Alacak = (-1) * Convert.ToDouble(txtGiren.Text);
                        }
                        else if (txtIslemTuru.Text == "Ödeme")
                        {
                            Borc = (-1) * Convert.ToDouble(txtCikan.Text);
                            Alacak = 0;
                        }
                        Cari c = new Cari();
                        Sonuc = c.CariToplamlariGuncelle(Convert.ToInt32(txtCariNo.Text), Borc, Alacak);
                        if (Sonuc)
                        {
                            MessageBox.Show("Cari toplamlar güncellendi!");
                            Temizle();
                            btnSil.Enabled = false;
                        }
                        else { MessageBox.Show("Cari toplamlar değiştirilemedi!"); }
                    }
                    else { MessageBox.Show("Cari Hareket silinemedi!"); }
                }
            }
            else { MessageBox.Show("Kasa Hareket silinemedi!"); }
        }
    }
}
