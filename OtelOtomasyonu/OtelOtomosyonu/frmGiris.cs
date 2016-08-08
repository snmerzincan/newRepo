using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Genel.connStr);

        private void frmGiris_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.CenterScreen;
            
            this.Top = 150;
            this.Left = 460;
            txtKullaniciAdi.Focus();
            
           
        }
        public string yetki;
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            try
            {
                bool kontrol = false;

                SqlCommand comm = new SqlCommand("select * from Kullanicilar where KullaniciAdi=@KullaniciAdi and KullaniciSifre= @KullaniciSifre ", conn);
                comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                comm.Parameters.Add("@KullaniciSifre", SqlDbType.VarChar).Value = txtKullaniciSifre.Text;


                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataReader dr = comm.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        kontrol = true;
                        yetki = dr["YetkiID"].ToString();
                    }
                }
                conn.Close();
                if ((txtKullaniciAdi.Text).Trim() != " " || (txtKullaniciSifre.Text).Trim() != " ")
                {
                    if (kontrol == true)

                    {
                        frmAnasayfa frm = new frmAnasayfa();
                        frm.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiniz!");

                    }
                }
                else
                {

                    MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "DİKKAT!",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

    }
}
    