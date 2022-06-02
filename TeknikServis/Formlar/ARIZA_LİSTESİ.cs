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
    public partial class ARIZA_LİSTESİ : Form
    {
        public ARIZA_LİSTESİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void ARIZA_LİSTESİ_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_URUNKABUL
                           select new
                           {

                               x.ISLEMID,
                               CARIAD= x.TBL_CARI.AD,
                               CARISOYAD=x.TBL_CARI.SOYADI,
                               PERSONELAD=x.TBL_PERSONEL.PERSONEL,
                               PERSONELSOYAD = x.TBL_PERSONEL.SOYADI,
                               x.GELISTARIH,
                               x.CIKISITARIH,
                               x.URUNSERINO,
                               x.DURUMDETAY

                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl5.Text = db.TBL_URUNKABUL.Count(x=> x.URUNDURUM==true).ToString();
            labelControl3.Text = db.TBL_URUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl14.Text = db.TBL_URUN.Count().ToString();
            labelControl7.Text = db.TBL_URUNKABUL.Count(X => X.DURUMDETAY == "PARÇA BEKLİYOR").ToString();
            labelControl12.Text = db.TBL_URUNKABUL.Count(X => X.DURUMDETAY == "MESAJ BEKLİYOR").ToString();
            labelControl10.Text = db.TBL_URUNKABUL.Count(X => X.DURUMDETAY == "İPTAL BEKLİYOR").ToString();

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F0TNBP8;Initial Catalog=DbTeknıkServıs;Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select DURUMDETAY,COUNT(*) from TBL_URUNKABUL GROUP BY DURUMDETAY", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {


                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));


            }
            baglan.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ARIZA_DETAY fr = new ARIZA_DETAY();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
