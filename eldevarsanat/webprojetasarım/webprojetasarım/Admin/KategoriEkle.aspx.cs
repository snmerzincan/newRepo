using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım.Admin
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] !=null)
                {
                    KategorileriGetir();
                }
                else
                {
                    Response.Redirect("AdminPaneli.aspx");
                }
            }
        }
        private void KategorileriGetir()
        {
            var Kategoriler = (from k in ent.Kategoriler
                               where k.Silindi == false
                               select k).ToList();
            gvKategoriler.DataSource = Kategoriler;
            gvKategoriler.DataBind();

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
            txtKategoriAdi.Text = "";
            txtAciklama.Text = "";
            txtKategoriAdi.Focus();

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataModel.Kategoriler k = new DataModel.Kategoriler();
            k.KategoriAd = txtKategoriAdi.Text;
            k.Aciklama = txtAciklama.Text;
            ent.Kategoriler.Add(k);
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible =false;
                KategorileriGetir();

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int silinenID = Convert.ToInt32(gvKategoriler.SelectedValue);
            var silinen = (from s in ent.Kategoriler
                           where s.KategoriID == silinenID 
                           select s).FirstOrDefault();
            silinen.Silindi = true;
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                KategorileriGetir();

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
    
            int degisenID = Convert.ToInt32(gvKategoriler.SelectedValue);
            var degisen = (from d in ent.Kategoriler
                           where  d.KategoriID == degisenID 
                           select d).FirstOrDefault();
            degisen.KategoriAd = txtKategoriAdi.Text;
            degisen.Aciklama = txtAciklama.Text;
            try
            {
                ent.SaveChanges();
                pnlEkle.Visible = false;
                KategorileriGetir();

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
        }

        protected void gvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtKategoriAdi.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[2].Text);
            txtKategoriAdi.Focus();

        }
    }
}