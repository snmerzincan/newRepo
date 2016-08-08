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
    public partial class UrunKartlari : Form
    {
        public UrunKartlari()
        {
            InitializeComponent();
        }
        BindingSource bs;
        DataSet ds = new DataSet();

        private void UrunKartlari_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Urun u = new Urun();
            u.UrunleriGoster(lvUrunler);

            DataBagla();
            Konum();

            Kategori k = new Kategori();
            k.KategorileriGetir(cbKategoriler);
            k.KategorileriGetir(cbKategori);

            tabControl1.SelectedIndex = Genel.urunsayfano;
        }
        private void DataBagla()
        {
            Urun u = new Urun();
            ds = u.UrunleriGetir();
            bs = new BindingSource();
            bs.DataSource = ds.Tables["Urunler"];

            txtUrunKodu.DataBindings.Clear();
            txtUrunAdi.DataBindings.Clear();
            txtUrunID.DataBindings.Clear();
            txtKategori.DataBindings.Clear();
            txtKategoriNo.DataBindings.Clear();
            txtMiktar.DataBindings.Clear();
            txtKritik.DataBindings.Clear();
            txtFiyat.DataBindings.Clear();

            txtUrunKodu.DataBindings.Add("Text", bs, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", bs, "UrunAd");
            txtUrunID.DataBindings.Add("Text", bs, "UrunID");
            txtKategori.DataBindings.Add("Text", bs, "KategoriAd");
            txtKategoriNo.DataBindings.Add("Text", bs, "KategoriID");
            txtMiktar.DataBindings.Add("Text", bs, "Miktar");
            txtKritik.DataBindings.Add("Text", bs, "KritikSeviye");
            txtFiyat.DataBindings.Add("Text", bs, "BirimFiyat");

            txtUrunKodu2.DataBindings.Clear();
            txtUrunAdi2.DataBindings.Clear();
            txtUrunID2.DataBindings.Clear();

            txtUrunKodu2.DataBindings.Add("Text", bs, "UrunKodu");
            txtUrunAdi2.DataBindings.Add("Text", bs, "UrunAd");
            txtUrunID2.DataBindings.Add("Text", bs, "UrunID");
        }
        private void tsFirst_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            Konum();
        }
        private void tsPrev_Click(object sender, EventArgs e)
        {
            bs.Position -= 1;
            Konum();
        }
        private void tsNext_Click(object sender, EventArgs e)
        {
            bs.Position += 1;
            Konum();
        }

        private void tsLast_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
            Konum();
        }
        private void Konum()
        {
            lblKonum.Text = (bs.Position + 1) + " / " + bs.Count;
            UrunHareket uh = new UrunHareket();
            uh.UrunHareketleriGetir(lvHareketler, Convert.ToInt32(txtUrunID.Text));
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori k = (Kategori)cbKategoriler.SelectedItem;
            txtKategoriNo.Text = k.KategoriNo.ToString();
            txtKategori.Text = k.KategoriAd;
            txtFiyat.Focus();
        }
        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            bs.AddNew();
            txtUrunKodu.Focus();
        }
        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunKodu.Text) || string.IsNullOrEmpty(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Kodu ve Adı boş geçilmemelidir.");
                txtUrunKodu.Focus();
            }
            else
            {
                Urun u = new Urun();
                if (u.UrunKontrol(txtUrunKodu.Text, txtUrunAdi.Text))
                {
                    MessageBox.Show("Aynı ürün zaten stokta kayıtlı!");
                    txtUrunKodu.Focus();
                }
                else
                {
                    tsKaydet.Enabled = false;
                    tsDegistir.Enabled = true;
                    tsSil.Enabled = true;
                    bs.EndEdit();
                    u.UrunKodu = txtUrunKodu.Text;
                    u.UrunAd = txtUrunAdi.Text;
                    u.KategoriID = Convert.ToInt32(txtKategoriNo.Text);
                    if (string.IsNullOrEmpty(txtFiyat.Text)) txtFiyat.Text = "0";
                    u.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                    if (string.IsNullOrEmpty(txtKritik.Text)) txtKritik.Text = "0";
                    u.KritikSeviye = Convert.ToInt32(txtKritik.Text);
                    if (u.UrunEkle(u))
                    {
                        MessageBox.Show("Ürün Bilgileri eklendi.");
                        u.UrunleriGoster(lvUrunler);
                        DataBagla();
                        Konum();
                    }
                    else { MessageBox.Show("Ürün Eklemede sorunla karşılaşıldı!"); }
                }
            }
        }
        private void tsVazgec_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = false;
            bs.CancelEdit();
            Konum();
        }

        private void txtKodaGore_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunleriGetirByKodaGore(txtKodaGore.Text, lvUrunler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunleriGetirByAdaGore(txtAdaGore.Text, lvUrunler);
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            Urun u = new Urun();
            int kacinci = u.KacinciKayit(Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[7].Text));
            bs.Position = kacinci;
            Konum();

        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            if (u.UrunKontrol(txtUrunKodu.Text, txtUrunAdi.Text, Convert.ToInt32(txtUrunID.Text)))
            {
                MessageBox.Show("Aynı kod ve isimde zaten başka bir ürün kayıtlı!");
                txtUrunKodu.Focus();
            }
            else
            {
                bs.EndEdit();
                u.UrunID = Convert.ToInt32(txtUrunID.Text);
                u.UrunKodu = txtUrunKodu.Text;
                u.UrunAd = txtUrunAdi.Text;
                u.KategoriID = Convert.ToInt32(txtKategoriNo.Text);
                if (string.IsNullOrEmpty(txtFiyat.Text)) txtFiyat.Text = "0";
                u.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                if (string.IsNullOrEmpty(txtKritik.Text)) txtKritik.Text = "0";
                u.KritikSeviye = Convert.ToInt32(txtKritik.Text);
                if (u.UrunGuncelle(u))
                {
                    MessageBox.Show("Ürün Bilgileri güncellendi.");
                    u.UrunleriGoster(lvUrunler);
                    DataBagla();
                    Konum();
                }
                else { MessageBox.Show("Ürün Güncellemede sorunla karşılaşıldı!"); }
            }
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Urun u = new Urun();
                bool Sonuc = u.UrunSil(Convert.ToInt32(txtUrunID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Ürün bilgileri silindi.");
                    u.UrunleriGoster(lvUrunler);
                    DataBagla();
                    Konum();
                }
            }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }
        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
            txtFirma.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtTarih.Text = DateTime.Now.ToString();
            cbIslemTurleri.SelectedIndex = 1;
            txtBirim.Text = "Adet";
            txtAdet.Text = "1";
            txtBirimFiyat.Text = txtFiyat.Text;
            txtBelge.Focus();
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                txtBirimFiyat.Text = "0";
                txtBirimFiyat.Select(0, txtBirimFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                txtBirimFiyat.Text = "0";
                txtBirimFiyat.Select(0, txtBirimFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            if (txtIslemTuru.Text == "Stok Giriş")
            {
                Genel.caritipi = "Satıcı";
            }
            else if (txtIslemTuru.Text == "Stok Çıkış")
            {
                Genel.caritipi = "Alıcı";
            }
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtCariNo.Text = Genel.carino.ToString();
            txtFirma.Text = Genel.cariunvan;
            txtBelge.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirma.Text.Trim() != "")
            {
                if (txtIslemTuru.Text == "Stok Çıkış" && (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtMiktar.Text)))
                {
                    MessageBox.Show("Stok yeterli değil!");
                }
                else
                {
                    UrunHareket uh = new UrunHareket();
                    uh.Tarih = Convert.ToDateTime(txtTarih.Text);
                    uh.IslemTuru = txtIslemTuru.Text;
                    uh.FirmaID = Convert.ToInt32(txtCariNo.Text);
                    uh.UrunID = Convert.ToInt32(txtUrunID2.Text);
                    uh.Belge = txtBelge.Text;
                    uh.Birim = txtBirim.Text;
                    uh.Adet = Convert.ToInt32(txtAdet.Text);
                    uh.BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                    int kayitno = uh.UrunHareketEkle(uh);
                    if (kayitno > 0)
                    {
                        MessageBox.Show("Ürün hareket eklendi!");
                        uh.UrunHareketleriGetir(lvHareketler, uh.UrunID);
                        //Stok Miktarı güncellenmeli...
                        Urun u = new Urun();
                        bool Sonuc = u.UrunStokGuncelleFromHareketEkle(uh.UrunID, uh.Adet, uh.IslemTuru);
                        if (Sonuc)
                        {
                            MessageBox.Show("Ürün Stok Miktarı güncellendi!");
                            //CariHareket eklenmeli...
                            CariHareket ch = new CariHareket();
                            ch.Tarih = Convert.ToDateTime(txtTarih.Text);
                            ch.IslemTuru = txtIslemTuru.Text;
                            ch.CariNo = Convert.ToInt32(txtCariNo.Text);
                            ch.Belge = txtBelge.Text;
                            if (txtIslemTuru.Text == "Stok Çıkış")
                            {
                                ch.Borc = Convert.ToDouble(txtTutar.Text);
                                ch.Alacak = 0;
                            }
                            else
                            {
                                ch.Borc = 0;
                                ch.Alacak = Convert.ToDouble(txtTutar.Text);
                            }
                            ch.KasaHareketID = 0;
                            ch.UrunHareketID = kayitno;
                            if (ch.CariHareketEkle(ch))
                            {
                                MessageBox.Show("Cari hareket eklendi!");
                                //Cari Toplamlar güncellenmeli...
                                Cari c = new Cari();
                                Sonuc = c.CariToplamlariGuncelle(ch.CariNo, ch.Borc, ch.Alacak);
                                if (Sonuc)
                                {
                                    MessageBox.Show("Cari toplamlar güncellendi!");
                                }
                                else { MessageBox.Show("Cari toplamlar değiştirilemedi!"); }
                            }
                            else { MessageBox.Show("Cari Hareket eklenemedi!"); }
                        }
                        else { MessageBox.Show("Ürün Stok Miktarı güncellenemedi!"); }
                    }
                    else { MessageBox.Show("ürün Hareket eklenemedi!"); }
                }
            }
            else { MessageBox.Show("Mutlaka Firma seçmelisiniz!"); }
        }

        private void lvHareketler_DoubleClick(object sender, EventArgs e)
        {
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtHareketID.Text = lvHareketler.SelectedItems[0].SubItems[10].Text;
            txtTarih.Text = lvHareketler.SelectedItems[0].SubItems[0].Text;
            txtIslemTuru.Text = lvHareketler.SelectedItems[0].SubItems[1].Text;
            txtFirma.Text = lvHareketler.SelectedItems[0].SubItems[2].Text;
            txtCariNo.Text = lvHareketler.SelectedItems[0].SubItems[9].Text;
            txtBelge.Text = lvHareketler.SelectedItems[0].SubItems[6].Text;
            txtBirim.Text = lvHareketler.SelectedItems[0].SubItems[7].Text;
            txtBirimFiyat.Text = lvHareketler.SelectedItems[0].SubItems[4].Text;
            txtAdet.Text = lvHareketler.SelectedItems[0].SubItems[3].Text;
            txtTutar.Text = lvHareketler.SelectedItems[0].SubItems[5].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Stok Giriş-Çıkış hareketini iptal edicek misiniz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                UrunHareket uh = new UrunHareket();     
                bool Sonuc = uh.UrunHareketSil(Convert.ToInt32(txtHareketID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Ürün hareketi silindi!");
                    uh.UrunHareketleriGetir(lvHareketler, Convert.ToInt32(txtUrunID2.Text));
                    //Stok Miktarı güncellenmeli...
                    Urun u = new Urun();
                    Sonuc = u.UrunStokGuncelleFromHareketSil(Convert.ToInt32(txtUrunID2.Text), Convert.ToInt32(txtAdet.Text), txtIslemTuru.Text);
                    if (Sonuc)
                    {
                        MessageBox.Show("Ürün Stok Miktarı güncellendi!");
                        //CariHareket silinmeli...
                        CariHareket ch = new CariHareket();
                        double Borc, Alacak;
                        if (txtIslemTuru.Text == "Stok Çıkış")
                        {
                            Borc = (-1) * Convert.ToDouble(txtTutar.Text);
                            Alacak = 0;
                        }
                        else
                        {
                            Borc = 0;
                            Alacak = (-1) * Convert.ToDouble(txtTutar.Text);
                        }
                        if (ch.CariHareketSilFromUrunHareket(Convert.ToInt32(txtHareketID.Text)))
                        {
                            MessageBox.Show("Cari hareket silindi!");
                            //Cari Toplamlar güncellenmeli...
                            Cari c = new Cari();
                            Sonuc = c.CariToplamlariGuncelle(Convert.ToInt32(txtCariNo.Text), Borc, Alacak);
                            if (Sonuc)
                            {
                                MessageBox.Show("Cari toplamlar güncellendi!");
                            }
                            else { MessageBox.Show("Cari toplamlar değiştirilemedi!"); }
                        }
                        else { MessageBox.Show("Cari Hareket eklenemedi!"); }
                    }
                    else { MessageBox.Show("Ürün Stok Miktarı güncellenemedi!"); }
                }
                else { MessageBox.Show("ürün Hareket eklenemedi!"); }}
        }

        private void rbTumUrunler_CheckedChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            ds = u.UrunleriGetirByTumu();
            dgvUrunler.DataSource = ds.Tables["Urunler"];
            GridViewDuzenle();
            dgvUrunler.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void rbKritikSeviye_CheckedChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            ds = u.UrunleriGetirByKritikSeviye();
            dgvUrunler.DataSource = ds.Tables["Urunler"];
            GridViewDuzenle();
            int ToplamMiktar = 0;
            double ToplamTutar = 0;
            foreach (DataRow dr in ds.Tables["Urunler"].Rows)
            {
                ToplamMiktar += Convert.ToInt32(dr["SiparisMiktar"]);
                ToplamTutar += Convert.ToDouble(dr["SiparisTutar"]);
            }
            txtToplamMiktar.Text = ToplamMiktar.ToString();
            txtToplamTutar.Text = ToplamTutar.ToString();
            txtToplamMiktar.Visible = true;
            txtToplamTutar.Visible = true;
            dgvUrunler.Columns["SiparisMiktar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunler.Columns["SiparisTutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GridViewDuzenle()
        {
            dgvUrunler.Columns["UrunAd"].Width = 130;
            dgvUrunler.Columns["Miktar"].Width = 70;
            dgvUrunler.Columns["Miktar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunler.Columns["KritikSeviye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunler.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtToplamMiktar.Visible = false;
            txtToplamTutar.Visible = false;
        }
    }
}
