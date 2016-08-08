using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprojetasarım
{
    public partial class FaturaBilgileri : System.Web.UI.Page
    {
        DataModel.SETEKwebprojeEntities ent = new DataModel.SETEKwebprojeEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    //var id = (from i in ent.Kullanicilar
            //    //                where i.Silindi == false && i.KullaniciAdi==Session["kullaniciAdi"].ToString()
            //    //                select i).FirstOrDefault();

            //    var bilgiler = (from i in ent.Kullanicilar
            //                    where i.Silindi == false
            //                    select i).FirstOrDefault();
            //    if (Session["kullaniciAdi"].ToString()== bilgiler.KullaniciAdi.ToString())
            //    {
            //        txtAdres.Text = bilgiler.Adres;
            //        txtil.Text = bilgiler.il;
            //        txtilce.Text = bilgiler.ilce;
            //        txtTelefon.Text = bilgiler.Telefon;
            //        ent.SaveChanges();
            //    }
            //}
            if (!IsPostBack)
            {
                if (Session["kullaniciAdi"] != null)
                {
                    Panel1.Visible = false;
                    Getir();
                    pnladres.Visible = true;
                   
                }
                else
                {
                    Panel1.Visible = true;
                    pnladres.Visible = false;
                }
            }

        }

        private void Getir()
        {
            string kulAd = txtemail.Text;
            var kullanici = (from u in ent.Kullanicilar
                             where u.KullaniciAdi == kulAd && u.Silindi == false
                             select u).FirstOrDefault();

            if (kullanici != null)
            {
                Session["kullaniciAdi"] = kullanici.KullaniciAdi;
                pnladres.Visible = true;
                txtadres.Text = kullanici.Adres;
                txtilce.Text = kullanici.ilce;
                txtIl.Text = kullanici.il;
                txtTelefon.Text = kullanici.Telefon;
                txtadres.Focus();

            }
            else
            {
                txtemail.Focus();

            }
        }
        protected void btnGiris_Click(object sender, EventArgs e)
        {
            Getir();
            //var kullanici = (from u in ent.Kullanicilar
            //                 where u.KullaniciAdi == txtemail.Text && u.Sifre == txtsifre.Text && u.Silindi == false
            //                 select u).FirstOrDefault(); 

            //if (kullanici == null)
            //{

            //    txtemail.Focus();
            //}
            //else
            //{

            //    Session["kullaniciAdi"] = kullanici.KullaniciAdi;
            //    pnladres.Visible = true;
            //    txtadres.Text = kullanici.Adres;
            //    txtilce.Text = kullanici.ilce;
            //    txtIl.Text = kullanici.il;
            //    txtTelefon.Text = kullanici.Telefon;
            //    txtadres.Focus();

            //    }
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



        protected void cbxUnuttum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtemail.Text.Trim() != "")

            {
                DataModel.Kullanicilar k = EmailKontrol(txtemail.Text);

                if (k != null)
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("sinemerzincan@gmail.com", "Yardım", System.Text.Encoding.UTF8);
                    mail.To.Add(txtemail.Text);
                    mail.Subject = "Sağlık Ürünleri E-Ticaret Sitesi";
                    //mail.Body = "Sayın , " + k.ad + " " + k.soyad + "<br/> Şifreniz : " + k.sifre;
                    StringBuilder sbMesaj = new StringBuilder();
                    sbMesaj.Append("Sayın , " + k.Ad + " " + k.Soyad + "<br/> Şifreniz : " + k.Sifre + "<br/>");
                    sbMesaj.Append("<a href=\"" + Request.Url.Host + "/FaturaBilgileri.aspx\" > Alışverişe devam etmek için tıklayınız...</a>");                           //geldiği sayfanın adresini tutar
                    mail.Body = sbMesaj.ToString();
                    mail.IsBodyHtml = true;



                    SmtpClient sc = new SmtpClient();
                    sc.Host = "smtp.gmail.com";//mail.domain.com
                    sc.Port = 587;
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("sinemerzincan@gmail.com", "esterler");
                    try
                    {
                        sc.Send(mail);
                        lblmesaj.Text = "Şifreniz mail adresinize gönderilmiştir.";
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.Message;
                    }
                }
                else
                {
                    lblmesaj.Text = "Bu mail adresi kayıtlı değildir";
                }
            }
        }
        private DataModel.Kullanicilar EmailKontrol(string email)
        {
            var User = (from k in ent.Kullanicilar
                        where k.KullaniciAdi == email && k.Silindi == false
                        select k).FirstOrDefault();

            //if (User != null) return true;
            //return false;
            return User;
        }

        protected void btnAdresOnay_Click(object sender, EventArgs e)
        {
            if (txtadres.Text.Trim() != "")
            {
                //Teslim adres bilgileri güncellenecek.
                string degisenad = Session["kullaniciAdi"].ToString();
                var degisen = (from user in ent.Kullanicilar
                               where user.KullaniciAdi == degisenad
                               select user).FirstOrDefault();
                degisen.Adres = txtadres.Text;
                degisen.ilce = txtilce.Text;
                degisen.il = txtIl.Text;
                degisen.Telefon = txtTelefon.Text;
                lblmesaj.Text = "Adres bilgileriniz güncellendi.";
                Response.Redirect("TeslimatSekli.aspx");

            }
        }
    }
}
