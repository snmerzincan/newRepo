using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webSaglikProjesi.DataModel;

namespace webSaglikProjesi.Admin
{
    public partial class AltKategoriekle : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["admin"] == null)
                {
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    KategorileriGetir();
                    AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
                }
            }
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategorileriGetirByKategoriNo(Convert.ToInt32(ddlKategoriler.SelectedValue));
        }
        private void AltKategorileriGetirByKategoriNo(int KNO)
        {
            var subcategories = (from altk in ent.AltKategoriler
                                 where altk.silindi == false && altk.kategorino == KNO
                                 select altk).ToList();
            gvAltKategoriler.DataSource = subcategories;
            gvAltKategoriler.DataBind();
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
        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            int degisenID = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            var degisen = (from k in ent.AltKategoriler
                           where k.id == degisenID
                           select k).FirstOrDefault();
            degisen.altkategoriad = txtAltKategoriAdi.Text;
            degisen.aciklama = txtAciklama.Text;
            //degisen.kategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);
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
        protected void btnSil_Click(object sender, EventArgs e)
        {
            int silinenID = Convert.ToInt32(gvAltKategoriler.SelectedValue);
            var silinen = (from k in ent.AltKategoriler
                           where k.id == silinenID
                           select k).FirstOrDefault();
            //ent.AltKategoriler.Remove(silinen);
            //Gerçekten silme yerine silindi kolonunu değiştirmek istersek,
            silinen.silindi = true;
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
        protected void lbYeniAltKategori_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataModel.AltKategoriler ak = new DataModel.AltKategoriler();
            ak.altkategoriad = txtAltKategoriAdi.Text;
            ak.aciklama = txtAciklama.Text;
            ak.kategorino = Convert.ToInt32(ddlKategoriler.SelectedValue);
            ent.AltKategoriler.Add(ak);
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
        private void Temizle()
        {
            txtAltKategoriAdi.Text = "";
            txtAciklama.Text = "";
            txtAltKategoriAdi.Focus();
        }
    }
}