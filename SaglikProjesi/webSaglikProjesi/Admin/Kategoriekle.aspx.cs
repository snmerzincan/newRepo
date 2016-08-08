using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webSaglikProjesi.DataModel;

namespace webSaglikProjesi.Admin
{
    public partial class Kategoriekle : System.Web.UI.Page
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
                    KategoriGetir();
                    
                }
            }
        }

        private void KategoriGetir()
        {
            var cat = (from k in ent.Kategoriler
                       where k.silindi == false
                       select k).ToList();
            gvKategoriler.DataSource = cat;
            gvKategoriler.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text.Trim() != "")
            {
                Kategoriler k = new Kategoriler();
                k.kategoriad = txtKategori.Text;
                k.aciklama = txtAciklama.Text;
                ent.Kategoriler.Add(k);
                ent.SaveChanges();
                pnlEkle.Visible = false;
                KategoriGetir();

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            txtKategori.Focus();
        }

        protected void gvKategoriler_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvKategoriler.EditIndex = e.NewEditIndex;
        }

        protected void gvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEkle.Visible = true;
            btnKaydet.Enabled = false;
            btndegistir.Enabled = true;
            btnsil.Enabled = true;
            txtKategori.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[1].Text);
            txtAciklama.Text = HttpUtility.HtmlDecode(gvKategoriler.SelectedRow.Cells[2].Text);

        }

        private void Temizle()
        {
            txtKategori.Text = "";
            txtAciklama.Text = "";
            
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            int degisenid = Convert.ToInt32(gvKategoriler.SelectedValue);
            var degisen = (from k in ent.Kategoriler
                           where k.id == degisenid  
                           select k).FirstOrDefault();
            degisen.kategoriad = txtKategori.Text;
            degisen.aciklama = txtAciklama.Text;

        }

        protected void btndegistir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvKategoriler.SelectedValue);
            Kategoriler k = new Kategoriler();
            k.kategoriad = txtKategori.Text;
            k.aciklama = txtAciklama.Text;
            ent.SaveChanges();
        }

        
    }
}