using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi.Admin
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] != null)
                {
                    pnlLogin.Visible = false;
                    
                }
                else
                {
                    Panel pnl = (Panel)this.Master.FindControl("pnlMenu");
                    pnl.Visible = false;
                    pnlLogin.Visible = true;
                }
            }
        }
    }
}