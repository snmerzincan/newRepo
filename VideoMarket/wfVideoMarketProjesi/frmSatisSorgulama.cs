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

namespace wfVideoMarketProjesi
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(cGenel.connStr);

        private void btnGetir_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            cFilmSatis fs = new cFilmSatis();
            dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvSatislar.DataSource = dt;
            dgvSatislar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            int TAdet = 0;
            double TTutar = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TAdet += Convert.ToInt32(dr["Adet"]);
                TTutar += Convert.ToDouble(dr["Tutar"]);
            }
            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }

        private void frmSatisSorgulama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VideoMarketDataSet.vw_DetayliSatis' table. You can move, or remove it, as needed.

        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            this.VideoMarketDataSet.vw_DetayliSatis.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select Convert(Date, Tarih, 104) as IslemTarihi, MusteriAd + ' ' + MusteriSoyad as Musteri, FilmAd, BirimFiyat, Adet, Adet*BirimFiyat as Tutar from FilmSatis fs inner join Musteriler m on fs.MusteriNo=m.MusteriNo inner join Filmler f on fs.FilmNo = f.FilmNo where fs.Silindi=0 and Convert(Date, Tarih, 104) between Convert(Date, @Tarih1, 104) and Convert(Date, @Tarih2, 104) order by SatisNo desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = dtpTarih1.Value;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = dtpTarih2.Value;
            try
            {
                da.Fill(this.VideoMarketDataSet.vw_DetayliSatis);
                this.reportViewer1.Visible = true;
                this.reportViewer1.Top = 100;
                this.reportViewer1.Left = 60;
                this.reportViewer1.Height = 400;
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            //this.vw_DetayliSatisTableAdapter.Fill(this.VideoMarketDataSet.vw_DetayliSatis);

        }
    }
}
