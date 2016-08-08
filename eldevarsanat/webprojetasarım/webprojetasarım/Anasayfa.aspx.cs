using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciAdi"]!=null)
            {
                lblKullanıcıismi.Text = "Hoşgeldiniz" + " " + Session["kullaniciAdi"].ToString();

            }
        }
    }
}