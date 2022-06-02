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
    public partial class DEPARTMAN : Form
    {
        public DEPARTMAN()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
    
        private void DEPARTMAN_Load(object sender, EventArgs e)
        {
      
            labelControl12.Text = db.TBL_DEPARTMAN.Count().ToString();
            labelControl14.Text = db.TBL_PERSONEL.Count().ToString();
            labelControl16.Text = db.MAKSDEPARTMAN().FirstOrDefault();
            labelControl18.Text = db.MİNDEPARTMAN().FirstOrDefault();
            var degerler = from u in db.TBL_DEPARTMAN
                           select new
                           {

                               u.ID,
                               u.AD
                             

                           };

            gridControl1.DataSource = degerler.ToList();

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-F0TNBP8;Initial Catalog=DbTeknıkServıs;Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT TBL_DEPARTMAN.AD,COUNT(TBL_PERSONEL.DEPARTMAN) AS 'TOPLAM' FROM TBL_PERSONEL INNER JOIN TBL_DEPARTMAN ON TBL_DEPARTMAN.ID = TBL_PERSONEL.DEPARTMAN GROUP BY TBL_DEPARTMAN.AD ORDER BY TOPLAM", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {


                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));


            }
            baglan.Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            TBL_DEPARTMAN t = new TBL_DEPARTMAN();
            if(txtad.Text.Length<=50 && txtad.Text!="") { 
            t.AD = txtad.Text;
            t.ACIKLAMA = richTextBox1.Text;
            db.TBL_DEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("DEPARTMAN KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("KAYIT YAPILAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_DEPARTMAN.Find(id);
                db.TBL_DEPARTMAN.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("DEPARTMAN BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

                MessageBox.Show("DEPARTMAN SİLİNEMEDİ! LÜTFEN SİLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_DEPARTMAN
                           select new
                           {

                               u.ID,
                               u.AD


                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_DEPARTMAN.Find(id);
                deger.AD = txtad.Text;

                // deger.ACIKLAMA =richTextBox1.Text;
                db.SaveChanges();
                MessageBox.Show("DEPARTMAN BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("DEPARTMAN GÜNCELLENEMEDİ! LÜTFEN GÜNCELLİCEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            //richTextBox1.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
