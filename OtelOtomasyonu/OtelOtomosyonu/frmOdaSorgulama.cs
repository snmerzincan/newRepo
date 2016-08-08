using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu
{
    public partial class frmOdaSorgulama : Form
    {
        public frmOdaSorgulama()
        {
            InitializeComponent();
        }


        Odalar oda = new Odalar();
        

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            btn1001.BackColor = Color.Aqua;
        }

      
        private void btn1001_Click(object sender, EventArgs e)
        {

            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.RoyalRoom;

            oda.OdaNoyaGoreOdaBilgileri("1001",lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("1001", txtAciklama);
          
        }

        private void btn901_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.RoyalRoom;
            oda.OdaNoyaGoreOdaBilgileri("901", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("901", txtAciklama);
            
        }

        private void btn802_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.DeluxeRoom;
            oda.OdaNoyaGoreOdaBilgileri("802", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("802", txtAciklama);
          
        }

        private void btn801_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.DeluxeRoom;
            oda.OdaNoyaGoreOdaBilgileri("801", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("801", txtAciklama);
            
        }

        private void btn702_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.DeluxeRoom;
            oda.OdaNoyaGoreOdaBilgileri("702", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("702", txtAciklama);
            
        }

        private void btn701_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.DeluxeRoom;
            oda.OdaNoyaGoreOdaBilgileri("701", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("701", txtAciklama);
          
           
        }

        private void btn603_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("603", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("603", txtAciklama);
           
        }

        private void btn602_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoSuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("602", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("602", txtAciklama);
          
        }

        private void btn601_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("601", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("601", txtAciklama);
           
        }

        private void btn504_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoSuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("504", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("504", txtAciklama);
            
        }

        private void btn503_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("503", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("503", txtAciklama);
           
       
        }

        private void btn502_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("502", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("502", txtAciklama);
            
        }

        private void btn501_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("501", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("501", txtAciklama);
            
        }

        private void btn404_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoSuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("404", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("404", txtAciklama);
           
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("304", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("304", txtAciklama);
          
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoRoom;
            oda.OdaNoyaGoreOdaBilgileri("303", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("303", txtAciklama);
            
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("302", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("302", txtAciklama);
            
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoRoom;
            oda.OdaNoyaGoreOdaBilgileri("301", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("301", txtAciklama);
           
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoSuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("205", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("205", txtAciklama);
           
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("204", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("204", txtAciklama);
            
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoRoom;
            oda.OdaNoyaGoreOdaBilgileri("203", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("203", txtAciklama);
           
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoRoom;
            oda.OdaNoyaGoreOdaBilgileri("201", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("201", txtAciklama);
            
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.EcoSuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("305", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("305", txtAciklama);
           
        }

        private void btn401_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("401", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("401", txtAciklama);
            
        }

        private void btn402_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("402", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("402", txtAciklama);
            

        }

        private void btn202_Click_1(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.SuitRoom;
            oda.OdaNoyaGoreOdaBilgileri("202", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("202", txtAciklama);
           

        }

        private void btn403_Click(object sender, EventArgs e)
        {
            pbOda.Visible = true;
            pbOda.Image = Properties.Resources.FamilyRoom;
            oda.OdaNoyaGoreOdaBilgileri("403", lwOdaBilgileri);
            if (Convert.ToBoolean(lwOdaBilgileri.Items[0].SubItems[3].Text) == false) lwOdaBilgileri.Items[0].SubItems[3].Text = "Boş";
            else lwOdaBilgileri.Items[0].SubItems[3].Text = "Dolu";
            oda.Aciklama("403", txtAciklama);
            
        }

        private void frmOdaSorgulama_Load(object sender, EventArgs e)
        {
            txtBosOdaSayisi.Text = oda.BosOdaSayisi().ToString();
            txtDoluOdaSayisi.Text = oda.DoluOdaSayisi().ToString();
            txtCikacakOdaSayisi.Text = oda.CikacakOdaSayisi().ToString();
            oda.CikacakListesi(lbCikacakOdalar);
            oda.OdaRenk(btn1001, 1001);
            oda.OdaRenk(btn901, 901);
            oda.OdaRenk(btn802, 802);
            oda.OdaRenk(btn801, 801);
            oda.OdaRenk(btn702, 702);
            oda.OdaRenk(btn701, 701);
            oda.OdaRenk(btn603, 603);
            oda.OdaRenk(btn602, 602);
            oda.OdaRenk(btn601, 601);
            oda.OdaRenk(btn504, 504);
            oda.OdaRenk(btn503, 503);
            oda.OdaRenk(btn502, 502);
            oda.OdaRenk(btn501, 501);
            oda.OdaRenk(btn404, 404);
            oda.OdaRenk(btn403, 403);
            oda.OdaRenk(btn402, 402);
            oda.OdaRenk(btn401, 401);
            oda.OdaRenk(btn305, 305);
            oda.OdaRenk(btn304, 304);
            oda.OdaRenk(btn303, 303);
            oda.OdaRenk(btn302, 302);
            oda.OdaRenk(btn301, 301);
            oda.OdaRenk(btn205, 205);
            oda.OdaRenk(btn204, 204);
            oda.OdaRenk(btn203, 203);
            oda.OdaRenk(btn202, 202);
            oda.OdaRenk(btn201, 201);
            oda.CikarilacakOdaRenk(btn1001,1001);
            oda.CikarilacakOdaRenk(btn901,901);
            oda.CikarilacakOdaRenk(btn802,802);
            oda.CikarilacakOdaRenk(btn801,801);
            oda.CikarilacakOdaRenk(btn702,702);
            oda.CikarilacakOdaRenk(btn701,701);
            oda.CikarilacakOdaRenk(btn603,603);
            oda.CikarilacakOdaRenk(btn602,602);
            oda.CikarilacakOdaRenk(btn601,601);
            oda.CikarilacakOdaRenk(btn504,504);
            oda.CikarilacakOdaRenk(btn503,503);
            oda.CikarilacakOdaRenk(btn502,502);
            oda.CikarilacakOdaRenk(btn501,501);
            oda.CikarilacakOdaRenk(btn404,404);
            oda.CikarilacakOdaRenk(btn403,403);
            oda.CikarilacakOdaRenk(btn402,402);
            oda.CikarilacakOdaRenk(btn401,401);
            oda.CikarilacakOdaRenk(btn305,305);
            oda.CikarilacakOdaRenk(btn304,304);
            oda.CikarilacakOdaRenk(btn303,303);
            oda.CikarilacakOdaRenk(btn302,302);
            oda.CikarilacakOdaRenk(btn301,301);
            oda.CikarilacakOdaRenk(btn205,205);
            oda.CikarilacakOdaRenk(btn204,204);
            oda.CikarilacakOdaRenk(btn203,203);
            oda.CikarilacakOdaRenk(btn202,202);
            oda.CikarilacakOdaRenk(btn201,201);
         
             
             
          
            

        }

        
        private void lwOdaBilgileri_DoubleClick(object sender, EventArgs e)
        {
            
            Genel.OdaNumarasi = lwOdaBilgileri.Items[0].SubItems[1].Text;
            Genel.Kat = lwOdaBilgileri.Items[0].SubItems[2].Text;
            Genel.OdaId = Convert.ToInt32(lwOdaBilgileri.Items[0].SubItems[0].Text);
            this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOdaDuzenleme frm = new frmOdaDuzenleme();
            frm.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckOut frm = new frmCheckOut();
            frm.Show();

        }

    
     
       

     
        
        
    }
}
