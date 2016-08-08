using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım.Admin
{
    public partial class Adminİslemleri : System.Web.UI.UserControl
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtKullaniciAdi.Focus();
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != null)
            {
                var kullanici = (from k in ent.Kullanicilar
                                 where k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.Silindi == false && k.Admin == true
                                 select k).Count();
                if (kullanici > 0)
                {
                    Session["admin"] = txtKullaniciAdi.Text;
                    

                }

                Response.Redirect("AdminPaneli.aspx");
            }

            else
            {
                Response.Write("Hatalı kullanıcı veya şifre girişi!");
                txtKullaniciAdi.Focus();
            }
            }
            
        }
    }
