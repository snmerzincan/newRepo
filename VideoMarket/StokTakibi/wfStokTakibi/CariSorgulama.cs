using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfStokTakibi.Model;

namespace wfStokTakibi
{
    public partial class CariSorgulama : Form
    {
        public CariSorgulama()
        {
            InitializeComponent();
        }
        Cari c = new Cari();
        DataTable dt = new DataTable();

        private void CariSorgulama_Load(object sender, EventArgs e)
        {
            if (Genel.caritipi == "Alıcı")
                rbAlicilar.Checked = true;
            else if (Genel.caritipi == "Satıcı")
                rbSaticilar.Checked = true;
            else
                rbTumFirmalar.Checked = true;
        }

        private void txtUnvanaGore_TextChanged(object sender, EventArgs e)
        {
            dt = c.CarileriGetirByUnvanaGore(txtUnvanaGore.Text);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Alıcı";
            dt = c.CarileriGetirByCariTipi(Genel.caritipi);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Satıcı";
            dt = c.CarileriGetirByCariTipi(Genel.caritipi);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            dt = c.CarileriGetir();
            dgvCariler.DataSource = dt;
            dgvCariler.Columns[0].Visible = false;
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.carino = Convert.ToInt16(dgvCariler.SelectedRows[0].Cells[0].Value);
            Genel.cariunvan = dgvCariler.SelectedRows[0].Cells[2].Value.ToString();
            this.Close();
        }


    }
}
