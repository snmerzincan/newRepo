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
    public partial class MusteriCariEkstre : Form
    {
        public MusteriCariEkstre()
        {
            InitializeComponent();
        }
        CariHareket ch = new CariHareket();
        Cari c = new Cari();
        DataTable dt = new DataTable();

        private void MusteriCariEkstre_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            dtpIlkTarih.Value = DateTime.Now.AddMonths(-1);
            rbTumFirmalar.Checked = true;
        }

        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Alıcı";
            dt = c.CarilerGetirByCariTipi(Genel.caritipi);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns["Bakiye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCariler.Columns["CariTipi"].Width = 70;
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Satıcı";
            dt = c.CarilerGetirByCariTipi(Genel.caritipi);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns["Bakiye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCariler.Columns["CariTipi"].Width = 70;
        }

        private void rbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "";
            dt = c.CarilerGetirByCariTipi(Genel.caritipi);
            dgvCariler.DataSource = dt;
            dgvCariler.Columns["Bakiye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCariler.Columns["CariTipi"].Width = 70;
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.carino = Convert.ToInt32(dgvCariler.SelectedRows[0].Cells["CariNo"].Value);
            dgvCariEkstre.DataSource = ch.CariEkstreGetirByTarihlerArasiAndCari(dtpIlkTarih.Value, dtpSonTarih.Value, Genel.carino);
        }

        private void dtpIlkTarih_ValueChanged(object sender, EventArgs e)
        {
            dgvCariEkstre.DataSource = ch.CariEkstreGetirByTarihlerArasiAndCari(dtpIlkTarih.Value, dtpSonTarih.Value, Genel.carino);
        }

        private void dtpSonTarih_ValueChanged(object sender, EventArgs e)
        {
            dgvCariEkstre.DataSource = ch.CariEkstreGetirByTarihlerArasiAndCari(dtpIlkTarih.Value, dtpSonTarih.Value, Genel.carino);
        }
    }
}
