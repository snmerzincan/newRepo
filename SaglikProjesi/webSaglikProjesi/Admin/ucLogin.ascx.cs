using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi.Admin
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtuser.Focus();
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != null)
            {
                var varmi = (from k in ent.Kullanicilar
                             where k.kullaniciad == txtuser.Text && k.sifre == txtsifre.Text && k.admin == true
                             select k).Count();
                if (varmi > 0)
                {
                    Session["admin"] = txtuser.Text;
                }

                Response.Redirect("admin.aspx");
            }
            else
            {
                lblmesaj.Text = "Hatalı giriş!!!";
                txtuser.Focus();
            }
        }
    }
}