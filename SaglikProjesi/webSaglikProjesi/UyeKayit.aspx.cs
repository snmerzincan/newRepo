using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSaglikProjesi
{
    public partial class UyeKayit : System.Web.UI.Page
    {
        DataModel.SaglikUrunleriEntities ent = new DataModel.SaglikUrunleriEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //checkbox  //email kullanıcı kayıt //kaydet
        }


        private bool EmailKontrol(string email)
        {
            var varmi = (from mail in ent.Kullanicilar
                         where mail.kullaniciad == email && mail.silindi == false
                         select mail).FirstOrDefault();

            if (User != null) return true;
            return false;

        }

        protected void btnKayit_Click1(object sender, EventArgs e)
        {
            if (cbxSozlesme.Checked == false)
            {
                lblMesaj.Text = "Sözleşmeyi okudum işaretlemelisiniz.";
            }
            else
            {
                if (EmailKontrol(txtEmail.Text))
                {
                    lblMesaj.Text = "Girdiğiniz Email önceden kayıtlı!";
                    txtEmail.Focus();
                }
                else
                {
                    DataModel.Kullanicilar k = new DataModel.Kullanicilar();
                    k.kullaniciad = txtEmail.Text;
                    k.sifre = txtSifre.Text;//md5 gibi yöntemlerle şifrelenerek veritabanına kayıt edilebilir.
                    k.ad = txtAdi.Text;
                    k.soyad = txtSoyadi.Text;
                    k.telefon = txtTelefon.Text;
                    k.adres = txtAdres.Text;
                    k.il = txtIl.Text;
                    k.ilce = txtIlce.Text;
                    ent.Kullanicilar.Add(k);
                    try
                    {
                        ent.SaveChanges();
                        lblMesaj.Text = "Üye kayit işleminiz gerçekleşmiştir.";
                        // Response.Redirect("Adres.aspx");
                        btnKayit.Visible = false;
                        btnDevam.Visible = true;
                    }
                    catch (Exception ex)
                    {

                        string hata = ex.Message;
                    }

                }
            }
        }
    }
}