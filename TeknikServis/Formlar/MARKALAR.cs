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
    public partial class MARKALAR : Form
    {
        public MARKALAR()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();

      
        private void MARKALAR_Load(object sender, EventArgs e)
        {
       
            var degerler = db.TBL_URUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new

            {

                Marka=z.Key,
                Toplam=z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBL_URUN.Count().ToString();
            labelControl3.Text = (from x in db.TBL_URUN

                                  select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBL_URUN
                                  orderby x.SATISFIYAT descending
                                  select x.MARKA).FirstOrDefault();
            labelControl5.Text = db.MAKSURUNMARKA().FirstOrDefault();

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F0TNBP8;Initial Catalog=DbTeknıkServıs;Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select MARKA,COUNT(*) from TBL_URUN GROUP BY MARKA", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {


                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));


            }
            baglan.Close();


            baglan.Open();
            SqlCommand komut2 = new SqlCommand("select TBL_KATEGORI.AD, COUNT(*) FROM TBL_URUN inner join TBL_KATEGORI on TBL_KATEGORI.ID = TBL_URUN.KATEGORİ GROUP BY TBL_KATEGORI.AD ", baglan);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {


                chartControl2.Series["KATEGORİLER"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));


            }
            baglan.Close();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
