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
    public partial class KATEGORİ : MetroFramework.Forms.MetroForm
    {
        public KATEGORİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void temizle()
        {

            txtad.Text = "";
            txtıd.Text = "";
        }
        void liste()
        {

            var degerler = from k in db.TBL_KATEGORI
                           select new
                           {

                               k.ID,
                               k.AD,

                           };




            gridControl1.DataSource = degerler.ToList();
        }
        private void KATEGORİ_Load(object sender, EventArgs e)
        {

            
            liste();
            temizle();
        }
    

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtad.Text.Length <= 30)
            {
                TBL_KATEGORI t = new TBL_KATEGORI();
                t.AD = txtad.Text;
                db.TBL_KATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("KATEGORİ BAŞARIYLA KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            else
            {


                MessageBox.Show("KATEGORİ ADI BOŞ GEÇİLEMEZ VE KATEFORİ ADI 30 KARAKTERDEN FAZLA OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_KATEGORI.Find(id);
                db.TBL_KATEGORI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("KATEGORİ BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                liste();
                temizle();
            }
            else
            {
                MessageBox.Show("LÜTFEN SİLECEĞİNİZ KATEGORİYİ SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_KATEGORI.Find(id);
                deger.AD = txtad.Text;
                db.SaveChanges();
                MessageBox.Show("KATEGORİ BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                liste();
                temizle();

            }
            else
            {
                MessageBox.Show("LÜTFEN GÜNCELLECEĞİNİZ KATEGORİYİ SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
    }

