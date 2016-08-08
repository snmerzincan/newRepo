using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi.Admin
{
    public partial class Urunekle : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["admin"] != null)
                {
                    KategorileriGetir();
                    AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                    UrunleriGetir();
                }
                else
                {
                    Response.Redirect("admin.aspx");
                }
            }
        }

        private void UrunleriGetir()
        {
            int kno = Convert.ToInt32(ddlKategoriler.SelectedValue);
            int altkno = Convert.ToInt32(ddlAltKategoriler.SelectedValue);

            var urunler = (from u in ent.Urunler
                           where u.urunkategorino == kno && u.urunaltkategorino == altkno
                           select u).ToList();
            gvUrunler.DataSource = urunler;
            gvUrunler.DataBind();
        }

        private void KategorileriGetir()
        {
            var categories = (from k in ent.Kategoriler
                              where k.silindi == false
                              select k).ToList();
            ddlKategoriler.DataTextField = "kategoriad";
            ddlKategoriler.DataValueField = "id";
            ddlKategoriler.DataSource = categories;
            ddlKategoriler.DataBind();
        }
        private void Temizle()
        {
            //txtAltKategoriAdi.Text = "";
            //txtAciklama.Text = "";
            //txtAltKategoriAdi.Focus();
        }
        private void AltKategorileriGetirByKategoriNo(int katno)
        {
            var sub = (from cat in ent.AltKategoriler
                       where cat.silindi == false && cat.kategorino == katno
                       select cat).ToList();
            ddlAltKategoriler.DataTextField = "AltKategoriAd";
            ddlAltKategoriler.DataValueField = "id";
            ddlAltKategoriler.DataSource = sub;
            ddlAltKategoriler.DataBind();
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
            UrunleriGetir();
        }

        protected void ddlAltKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            UrunleriGetir();
            

            //txtAltKategoriAdi.Focus();
        }

        protected void lbYeniUrun_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
        }

        protected void gvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrunKodu.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[1].Text);
            txtUrunAdi.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[2].Text);
            txtMiktar.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[3].Text);
            txtFiyat.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[4].Text);
            txtUrunBilgisi.Text = HttpUtility.HtmlDecode(gvUrunler.SelectedRow.Cells[5].Text);

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunKodu.Text.Trim() !="" && txtUrunAdi.Text.Trim() !="")
            {
                if (fuKucukResim.HasFile)
                {
                    fuKucukResim.SaveAs(Server.MapPath("/content/urunimages/images/") + fuKucukResim.FileName);
                }
                if (fuBuyukResim.HasFile)
                {
                    fuBuyukResim.SaveAs(Server.MapPath("/content/urunimages/images/buyuk/") + fuBuyukResim.FileName);
                }
                DataModel.Urunler u = new DataModel.Urunler();
                u.urunad = txtUrunAdi.Text;
                u.urunkodu = txtUrunKodu.Text;
                u.urunfiyat =Convert.ToDecimal(txtFiyat.Text);
                u.urunbilgisi = txtUrunBilgisi.Text;
                u.urunaltkategorino = Convert.ToInt32(ddlAltKategoriler.SelectedValue);
                u.urunkategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);
                u.miktar = Convert.ToInt32(txtMiktar.Text);
                u.urunresimyolu1 = "/content/urunimages/images/" + fuKucukResim.FileName;
                u.urunresimyolu2 = "/content/urunimages/images/buyuk/" + fuBuyukResim.FileName;
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
    }
}