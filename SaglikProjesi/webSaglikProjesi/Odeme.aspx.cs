using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class Odeme : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["kullanici"] != null)
                {
                    DataTable dt = (DataTable)Session["Sepet"];
                    int kid = Convert.ToInt32(Session["kullanici"]);

                    var user = (from k in ent.Kullanicilar
                                where k.id == kid
                                select k).FirstOrDefault();
                    lbladi.Text = user.ad;
                    lblSoyadi.Text = user.soyad;
                    lblTutar.Text = ToplamTutarBul().ToString();
                }
                else
                {
                    Response.Redirect("Adres.aspx");
                }
          

            }
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
        protected void btnhavaleeft_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void btndevam_Click(object sender, EventArgs e)
        {
            Session.Remove("sepet");
            Response.Redirect("Default.aspx");
        }

        protected void btncikis_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Default.aspx");
        }
    }
}