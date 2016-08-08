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
    public partial class frmTahsilatEkranı : Form
    {
        public frmTahsilatEkranı()
        {
            InitializeComponent();
        }

        private void frmTahsilatEkranı_Load(object sender, EventArgs e)
        {
            txtMusteri.Text = Genel.Musteri;
            txtTutar.Text = Genel.Tutar.ToString();
            txtOnOdeme.Text = Genel.OnOdeme.ToString();
            txtKalanOdeme.Text = Genel.Kalan.ToString();
        }

       
    }
}
