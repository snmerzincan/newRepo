using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webSaglikProjesi.Models;

namespace webSaglikProjesi
{
    public partial class Sepet : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        cSepet spt = new cSepet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sepet"] != null)
                {
                    DataTable dt = (DataTable)Session["Sepet"];
                    SepetGoster(dt);
                }
                else
                {
                    DataTable dt = (DataTable)Session["sepet"];   // yeni sepeti getirmek lazım sepete direk tıklayınca cıkan butonlardan satın ala tıklayınca hata verdiği icin
                    gvSepet.DataSource = dt;
                    gvSepet.DataBind();
                }
            }
        }
        private void SepetGoster(DataTable dt)
        {
            gvSepet.Columns[1].FooterText = "Toplam : ";
            gvSepet.Columns[2].FooterText = ToplamAdetBul().ToString();
            gvSepet.Columns[2].FooterStyle.HorizontalAlign = HorizontalAlign.Center;
            gvSepet.Columns[3].FooterText = ToplamTutarBul().ToString();
            gvSepet.Columns[3].FooterStyle.HorizontalAlign = HorizontalAlign.Right;

            gvSepet.DataSource = dt;
            gvSepet.DataBind();
        }

        private int ToplamAdetBul()
        {
            int tadet = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                tadet += Convert.ToInt32(dr["adet"]);
            }
            return tadet;
        }

        private decimal ToplamTutarBul()
        {
            decimal ttutar = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                ttutar += Convert.ToInt32(dr["tutar"]);
            }
            return ttutar;
        }

        protected void btnSepetiBosalt_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            Session["sepet"] = dt;
            SepetGoster(dt);
        }

        protected void btndevam_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void gvSepet_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = (DataTable)Session["Sepet"];
            dt.Rows.RemoveAt(e.RowIndex);
            gvSepet.DataSource = dt;
            gvSepet.DataBind();
            Session["sepet"] = dt;
            SepetGoster(dt);
        }

        protected void btnSatinAl_Click(object sender, EventArgs e)
        {
            
                DataTable dt = (DataTable)Session["sepet"];
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("adres.aspx");
                }
            
            
        }
    }
}