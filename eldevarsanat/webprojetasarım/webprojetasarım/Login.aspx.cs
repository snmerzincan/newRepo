using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class Login : System.Web.UI.Page
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
            var kullanici = (from k in ent.Kullanicilar
                             where k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.Silindi == false
                             select k).FirstOrDefault();
            if (kullanici !=null)
            {
                Session["kullaniciAdi"] = txtKullaniciAdi.Text;
                //Session["kullaniciAdi"] = AdSoyad(txtKullaniciAdi.Text);
                //Response.Redirect("FaturaBilgileri.aspx");
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("Hatalı kullanıcı veya şifre girişi!");
                txtKullaniciAdi.Focus();
            }

                       
        }
        //public string AdSoyad(string KullaniciAdSoyad)
        //{
        //    var kullaniciismi = from k in ent.Kullanicilar
        //                        where k.KullaniciAdi == txtKullaniciAdi.Text && k.Silindi == false
        //                        select new { k.Ad, k.Soyad };
        //    KullaniciAdSoyad = kullaniciismi.ToString();
        //    return KullaniciAdSoyad;
        //}
    }
}