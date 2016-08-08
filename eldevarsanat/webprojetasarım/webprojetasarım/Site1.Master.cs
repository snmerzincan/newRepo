using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciAdi"] == null)
            {
                lbCikis.Visible = false;
            }
            else
            {
                lbCikis.Visible = true;
                lbGiris.Visible = false;
                lbFirmaGiris.Visible = false;
                lbUyeOl.Visible = false;
            }
        }

        protected void igLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Anasayfa.aspx");
        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Anasayfa.aspx");
        }

        protected void lbGiris_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void lbFirmaGiris_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin/AdminPaneli.aspx");
        }

        protected void lbUyeOl_Click(object sender, EventArgs e)
        {
            Response.Redirect("UyeOl.aspx");
        }
    }
}