using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webprojetasarım.Models;

namespace webprojetasarım
{
    public partial class Kart : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        SepetIslem sepetislem = new SepetIslem();
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
            gvSepet.Columns[4].FooterText = ToplamTutarBul().ToString();
            gvSepet.Columns[4].FooterStyle.HorizontalAlign = HorizontalAlign.Right;

            gvSepet.DataSource = dt;
            gvSepet.DataBind();
        }

        private int ToplamAdetBul()
        {
            int tadet = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                tadet += Convert.ToInt32(dr["Adet"]);
            }
            return tadet;
        }

        private decimal ToplamTutarBul()
        {
            decimal ttutar = 0;
            DataTable dt = (DataTable)Session["Sepet"];

            foreach (DataRow dr in dt.Rows)
            {
                ttutar += Convert.ToInt32(dr["Tutar"]);
            }
            return ttutar;
        }
        
        protected void gvSepet_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = (DataTable)Session["Sepet"];
            dt.Rows.RemoveAt(e.RowIndex);
            gvSepet.DataSource = dt;
            gvSepet.DataBind();
            Session["sepet"] = dt;
            SepetGoster(dt);
        }
        
        protected void btnDevam_Click1(object sender, EventArgs e)
        {
            //if (Session["kullaniciAdi"]!=null)
            //{
            //    DataTable dt = (DataTable)Session["sepet"];
            //    if (dt.Rows.Count > 0)
            //    {
            //        Response.Redirect("FaturaBilgileri.aspx");
            //    }
            //    else
            //    {
            //        Response.Redirect("UrunGridGorunum.aspx");
            //    }
            //}
            //else
            //{
            //    Response.Redirect("Login.aspx");
            //}
            Response.Redirect("FaturaBilgileri.aspx");

        }

        protected void btnSepetBosalt_Click(object sender, EventArgs e)
        {

            DataTable dt = (DataTable)Session["sepet"];
            dt.Rows.Clear();
            Session["sepet"] = dt;
            SepetGoster(dt);
        }

        protected void btnAlisveris_Click(object sender, EventArgs e)
        {
                Response.Redirect("UrunGridGorunum.aspx");
        }
    }
}