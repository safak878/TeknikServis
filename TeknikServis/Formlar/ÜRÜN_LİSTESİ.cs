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
    public partial class ÜRÜN_LİSTESİ : Form
    {
        public ÜRÜN_LİSTESİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void metot1()
        {

            var degerler = from u in db.TBL_URUN
                           select new
                           {

                               u.ID,
                               u.AD,
                               u.MARKA,
                               u.STOK,
                               KATEGORİ=u.TBL_KATEGORI.AD,
                               u.ALISFIYAT,
                               u.SATISFIYAT
                           };


                gridControl1.DataSource = degerler.ToList(); }
        private void ÜRÜN_LİSTESİ_Load(object sender, EventArgs e)
        {

          
            //LİSTELEME TOLİST ADD REMOVE

            //var degerler = db.TBL_URUN.ToList();
            metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_KATEGORI
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            ;
            txtalısfıyat.Text = "";
            txtıd.Text = "";
            txturunmarka.Text = "";
            txtsatısfıyat.Text = "";
            txtstok.Text = "";
            txturunad.Text = "";
        }
        

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txturunad.Text != "" && txturunmarka.Text != "" && txtalısfıyat.Text != "" && txtsatısfıyat.Text != "" && txtstok.Text != "")
            {
                TBL_URUN t = new TBL_URUN();
                t.AD = txturunad.Text;
                t.MARKA = txturunmarka.Text;
                t.ALISFIYAT = decimal.Parse(txtalısfıyat.Text);
                t.SATISFIYAT = decimal.Parse(txtsatısfıyat.Text);
                t.STOK = short.Parse(txtstok.Text);
                t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.DURUM = false;
                db.TBL_URUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            else
            {

                MessageBox.Show("KAYIT BAŞARISIZ! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txturunad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txturunmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                txtalısfıyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                txtsatısfıyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                txtstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORİ").ToString();

              
            }
            catch
            {

                MessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_URUN.Find(id);
                db.TBL_URUN.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                metot1();
            }
            else
            {
                MessageBox.Show("ÜRÜN SİLİNEMEDİ! LÜTFEN SİLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "") { 
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_URUN.Find(id);
                deger.AD = txturunad.Text;
                deger.STOK = short.Parse(txtstok.Text);
                deger.MARKA = txturunmarka.Text;
                deger.ALISFIYAT = decimal.Parse(txtalısfıyat.Text);
                deger.SATISFIYAT = decimal.Parse(txtsatısfıyat.Text);
                deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            else
            {
                MessageBox.Show("ÜRÜN GÜNCELLENEMEDİ! LÜTFEN GÜNCELLİYECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtalısfıyat.Text = "";
            txtıd.Text = "";
            txturunmarka.Text = "";
            txtsatısfıyat.Text = "";
            txtstok.Text = "";
            txturunad.Text = "";
           
           

        }
    }
}
