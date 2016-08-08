using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım.Admin
{
    public partial class AltKategoriEkle : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"]!=null)
                {
                    KategorileriGetir();
                    AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                }
                else
                {
                    Response.Redirect("AdminPaneli.aspx");
                    
                }
            }
        }
        private void AltKategorileriGetirByKategoriNo(int KNo)
        {
            var altKategoriler = (from altk in ent.AltKategori
                                  where altk.KategoriID == KNo && altk.Silindi == false
                                  select altk).ToList();
            gvAltKategoriler.DataSource = altKategoriler;
            gvAltKategoriler.DataBind();
        }
        private void KategorileriGetir()
        {
            var Kategoriler = (from k in ent.Kategoriler
                               where k.Silindi == false
                               select k).ToList();
            ddlKategoriler.DataTextField = "KategoriAd";
            ddlKategoriler.DataValueField = "KategoriID";
            ddlKategoriler.DataSource = Kategoriler;
            ddlKategoriler.DataBind();
        }


        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataModel.AltKategori altk = new DataModel.AltKategori();
            altk.AltKategoriAd = txtAltKategoriAdi.Text;
            altk.Aciklama = txtAciklama.Text;
            altk.KategoriID = Convert.ToInt32(ddlKategoriler.SelectedValue);
            ent.AltKategori.Add(altk);
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
           
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            int degisenID = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            var degisen = (from d in ent.AltKategori
                           where d.AltKategoriID == degisenID
                           select d).FirstOrDefault();
            degisen.AltKategoriAd = txtAltKategoriAdi.Text;
            degisen.Aciklama = txtAltKategoriAdi.Text;
            //ent.AltKategori.Add(degisen);
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
            }
            catch (Exception  ex)
            {
                string hata = ex.Message;
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int silinenID = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            var silinen = (from s in ent.AltKategori
                           where s.AltKategoriID == silinenID
                           select s).FirstOrDefault();
            silinen.Silindi = true;
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
        }

        protected void gvAltKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtAltKategoriAdi.Text = HttpUtility.HtmlDecode(gvAltKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvAltKategoriler.SelectedRow.Cells[2].Text);
            txtAltKategoriAdi.Focus();
        }

        protected void lbEkle_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtAltKategoriAdi.Text = "";
            txtAciklama.Text = "";
            txtAltKategoriAdi.Focus();
        }
    }
}