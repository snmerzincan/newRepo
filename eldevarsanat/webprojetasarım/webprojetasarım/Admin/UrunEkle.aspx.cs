using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım.Admin
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] != null)
                {
                    KategorileriGetir();
                    AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                    UrunleriGetir();
                }
                else
                {
                    Response.Redirect("AdminPaneli.aspx");
                }
            }

        }
        private void KategorileriGetir()
        {
            var kategoriler = (from k in ent.Kategoriler
                               where k.Silindi == false
                               select k).ToList();
            ddlKategoriler.DataTextField = "KategoriAd";
            ddlKategoriler.DataValueField = "KategoriID";
            ddlKategoriler.DataSource = kategoriler;
            ddlKategoriler.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            //DataModel.Urunler urun = new DataModel.Urunler();
            //urun.UrunKodu = txtUrunKodu.Text;
            //urun.UrunAd = txtUrunAdi.Text;
            //urun.Miktar = Convert.ToInt32(txtMiktar.Text);
            //urun.Fiyat =Convert.ToDecimal(txtFiyat.Text);
            //urun.Aciklama = txtAciklama.Text;
            //urun.ResimYolu1 = "img/urunimages/" + fuResim.FileName;
            //ent.Urunler.Add(urun);
            //try
            //{
            //    ent.SaveChanges();
            //    pnlEkle.Visible = false;
            //    AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlAltKategoriler.SelectedValue));
            //}
            //catch (Exception ex)
            //{
            //    string hata = ex.Message;
            //}

            if (txtUrunKodu.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "")
            {
                if (fuResim.HasFile)
                {
                    fuResim.SaveAs(Server.MapPath("img/urunimages") + fuResim.FileName);
                }

                DataModel.Urunler u = new DataModel.Urunler();
                u.UrunAd = txtUrunAdi.Text;
                u.UrunKodu = txtUrunKodu.Text;
                u.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                u.Aciklama = txtAciklama.Text;
                u.AltKategoriID = Convert.ToInt32(ddlAltKategoriler.SelectedValue);
                u.KategoriID = Convert.ToInt32(ddlKategoriler.SelectedValue);
                u.Miktar = Convert.ToInt32(txtMiktar.Text);
                u.ResimYolu1 = "img/urunimages" + fuResim.FileName;
                ent.Urunler.Add(u);
                try
                {
                    ent.SaveChanges();
                    pnlEkle.Visible = false;
                    UrunleriGetir();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }

            }

        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {

            int degisenID = Convert.ToInt32(gvUrunler.SelectedValue);
            var degisen = (from d in ent.Urunler
                           where d.UrunID == degisenID
                           select d).FirstOrDefault();
            degisen.UrunKodu = txtUrunKodu.Text;
            degisen.UrunAd = txtUrunAdi.Text;
            degisen.Miktar = Convert.ToInt32(txtMiktar.Text);
            degisen.Fiyat = Convert.ToDecimal(txtMiktar.Text);
            degisen.Aciklama = txtAciklama.Text;
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                UrunleriGetir();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int silinenID = Convert.ToInt32(gvUrunler.SelectedValue);
            var silinen = (from s in ent.Urunler
                           where s.UrunID == silinenID
                           select s).FirstOrDefault();
            silinen.Silindi = true;
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                UrunleriGetir();
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
        }

        protected void lbEkle_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;

        }
        private void Temizle()
        {
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtAciklama.Text = "";
            txtMiktar.Text = "1";
            txtFiyat.Text = "0";
            fuResim.Controls.Clear();
            txtUrunKodu.Focus();
        }
        
        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
            UrunleriGetir();
        }
        private void AltKategorileriGetirByKategoriNo(int KNo)
        {
            var altkategoriler = (from a in ent.AltKategori
                                  where a.Silindi == false && a.KategoriID == KNo
                                  select a).ToList();
            ddlAltKategoriler.DataTextField = "AltKategoriAd";
            ddlAltKategoriler.DataValueField = "AltKategoriID";
            ddlAltKategoriler.DataSource = altkategoriler;
            ddlAltKategoriler.DataBind();
        }

        private void UrunleriGetir()
        {
            int kno = Convert.ToInt32(ddlKategoriler.SelectedValue);
            int akno = Convert.ToInt32(ddlAltKategoriler.SelectedValue);
            var urunler = (from u in ent.Urunler
                           where u.KategoriID == kno && u.AltKategoriID == akno && u.Silindi == false
                           select u).ToList();
            gvUrunler.DataSource = urunler;
            gvUrunler.DataBind();
        }

        protected void ddlAltKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            UrunleriGetir();

        }

        protected void gvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtUrunKodu.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[2].Text);
            txtUrunAdi.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[3].Text);
            txtMiktar.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[4].Text);
            txtFiyat.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[5].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[6].Text);
            txtUrunKodu.Focus();
        }
    }
}