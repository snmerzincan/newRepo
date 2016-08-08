using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class AdminPaneli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"]!=null)
                {
                    pnlGiris.Visible = false;
                }
                else
                {
                    Panel pnl = (Panel)this.Master.FindControl("pnlKategoriler");
                    pnl.Visible = false;
                    pnlGiris.Visible = true;
                }
               
            }
        }
    }
}