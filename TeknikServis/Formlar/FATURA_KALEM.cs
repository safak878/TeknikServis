using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FATURA_KALEM : Form
    {
        public FATURA_KALEM()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void temizle(){

            txtıd.Text = "";
            lookUpEdit1.Text = "";
            txtadet.Text = "";
            txtfiyat.Text = "";
            txttutar.Text = "";
            lookUpEdit2.Text = ""; }


     
                
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "" && txtadet.Text != "" && txtfiyat.Text != "" && txttutar.Text != "" && lookUpEdit2.Text != "")
            {
                TBL_FATURADETAY t = new TBL_FATURADETAY();
                t.URUN = lookUpEdit1.Text;
                t.ADET = short.Parse(txtadet.Text);
                t.FIYAT = decimal.Parse(txtfiyat.Text);
                t.TUTAR = decimal.Parse(txttutar.Text);
                t.FATURAID = int.Parse(lookUpEdit2.Text);
                db.TBL_FATURADETAY.Add(t);
                db.SaveChanges();
                MessageBox.Show("FATURAYA AİT KALEM GİRİŞİ BAŞARI İLE YAPILDI ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                temizle();
            }
            else
            {

                MessageBox.Show("FATURAYA AİT KALEM GİRİŞİ YAPILAMADI! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FATURA_KALEM_Load(object sender, EventArgs e)
        {
            temizle();
            txttutar.Enabled = false;
      
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_URUN
                                                 select new
                                                 {
                                                     x.ID,
                                                  AD = x.MARKA+" "+ x.AD,
                                                   
                                                    

                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_FATURABILGI
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD= x.TBL_CARI.AD+" "+x.TBL_CARI.SOYADI



                                                 }).ToList();

            var degerler = from u in db.TBL_FATURADETAY
                           select new
                           {

                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            
            var degerler = from u in db.TBL_FATURADETAY
                           select new
                           {

                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            txtadet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            txtfiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            txttutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }
    
        private void txttutar_EditValueChanged(object sender, EventArgs e)
        {
          
        }
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
       
        }
  
        private void txttutar_Click(object sender, EventArgs e)
        {
        }
      
        private void txtadet_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtfiyat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtadet_Click(object sender, EventArgs e)
        {

            decimal s2;
            int s1;
            s1 = Convert.ToInt32(txtadet.Text);
            s2 = Convert.ToDecimal(txtfiyat.Text);
            txttutar.Text = Convert.ToDecimal(s1 * s2).ToString();
        }

        private void txtfiyat_Click(object sender, EventArgs e)
        {

            decimal s2;
            int s1;
            s1 = Convert.ToInt32(txtadet.Text);
            s2 = Convert.ToDecimal(txtfiyat.Text);
            txttutar.Text = Convert.ToDecimal(s1 * s2).ToString();
        }

        private void txtfaaturaıd_Click(object sender, EventArgs e)
        {

            decimal s2;
            int s1;
            s1 = Convert.ToInt32(txtadet.Text);
            s2 = Convert.ToDecimal(txtfiyat.Text);
            txttutar.Text = Convert.ToDecimal(s1 * s2).ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            }
        }
    }
}
