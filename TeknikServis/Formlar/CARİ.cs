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
    public partial class CARİ : Form
    {
        public CARİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void temizle()
        {
            txtıd.Text="";
            txtad.Text="";
            txtsoyad.Text = "";
            lookUpEdit2.Text = "";
            lookUpEdit3.Text = "";


        }
        int secilen;
        void liste()
        {

            var degelerler = from x in db.TBL_CARI
                             select new
                             {

                                 x.ID,
                                 x.AD,
                                 x.SOYADI,
                                 x.IL,
                                 x.ILCE

                             };
            gridControl1.DataSource = degelerler.ToList();
        }
        private void CARİ_Load(object sender, EventArgs e)
        {
           
            liste();
            temizle();


            var degelerler = from x in db.TBL_CARI
                             select new
                             {

                                 x.ID,
                                 x.AD,
                                 x.SOYADI,
                                 x.IL,
                                 x.ILCE

                             };
            gridControl1.DataSource = degelerler.ToList();
            labelControl12.Text = db.TBL_CARI.Count().ToString();
            lookUpEdit3.Properties.DataSource = (from x in db.İL
                                                 select new
                                                 {

                                                     x.id,
                                                     x.sehir
                                                 }).ToList();

            labelControl16.Text = db.TBL_CARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl18.Text = db.TBL_CARI.Select(x => x.ILCE).Distinct().Count().ToString();
            labelControl14.Text = db.MAXIL().FirstOrDefault();

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit3.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.İLCE
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir

                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && lookUpEdit3.Text != "" && lookUpEdit2.Text != "")
            {
                TBL_CARI t = new TBL_CARI();
                t.AD = txtad.Text;
                t.SOYADI = txtsoyad.Text;
                t.IL = lookUpEdit3.Text;
                t.ILCE = lookUpEdit2.Text;
                db.TBL_CARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("CARİ SİSTEME BAŞARILI BİR ŞEKİLDE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
                temizle();
            }
            else
            {

                MessageBox.Show(" LÜTFEN ZORUNLU ALANLARI BOŞ GEÇMEYİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
       
          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("SOYADI").ToString();
            lookUpEdit3.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_CARI.Find(id);
                db.TBL_CARI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("CARİ BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                liste();
                temizle();

            }
            else
            {

                MessageBox.Show("CARİ SİLİNEMEDİ LÜTFEN SİLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            if (txtıd.Text != "" && txtad.Text != "" && txtsoyad.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_CARI.Find(id);
                deger.AD = txtad.Text;
                deger.SOYADI = txtsoyad.Text;
                deger.IL = lookUpEdit3.Text;
                deger.ILCE = lookUpEdit2.Text;
                db.SaveChanges();
                MessageBox.Show("CARİ BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                liste();
                temizle();
            }

            else
            {

                MessageBox.Show("CARİ GÜNCELLENEMEDİ LÜTFEN GÜNCELLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
