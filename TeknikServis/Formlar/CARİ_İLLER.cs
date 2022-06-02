using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeknikServis.Formlar
{
    public partial class CARİ_İLLER : Form
    {
        public CARİ_İLLER()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-F0TNBP8;Initial Catalog=DbTeknıkServıs;Integrated Security=True");
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void CARİ_İLLER_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_CARI.OrderBy(x => x.IL).
            GroupBy(y => y.IL).
            Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM TBL_CARI group by IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));

            }
            baglanti.Close();
        }
    }
}

