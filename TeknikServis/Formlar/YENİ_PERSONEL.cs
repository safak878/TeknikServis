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
    public partial class YENİ_PERSONEL : MetroFramework.Forms.MetroForm
    {
        public YENİ_PERSONEL()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void liste()
        {
            var degerler = from u in db.TBL_PERSONEL
                           select new
                           {

                               u.ID,
                               u.PERSONEL,
                               u.SOYADI,
                               u.MAIL,
                               u.TELEFON,
                               u.TBL_DEPARTMAN.AD
                           };

            gridControl1.DataSource = degerler.ToList();
            lkpdepartman.Properties.DataSource = (from x in db.TBL_DEPARTMAN
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            ;
        }

        private void YENİ_PERSONEL_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void txtstok_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(txtad.Text !="" && txtsoyad.Text !="" && txttel.Text !="")
            {

                TBL_PERSONEL t = new TBL_PERSONEL();
                t.PERSONEL = txtad.Text;
                t.SOYADI = txtsoyad.Text;
                t.DEPARTMAN = byte.Parse(lkpdepartman.EditValue.ToString());
                t.TELEFON = txttel.Text;
                t.MAIL = txtmaıl.Text;
                db.TBL_PERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("PERSONEL SİSTEME EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();

            }
            else
            {
                MessageBox.Show("LÜTFEN  ZORUNLU ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("SOYADI").ToString();
            txttel.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtmaıl.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            lkpdepartman.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_PERSONEL.Find(id);
                db.TBL_PERSONEL.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("PERSONEL BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                liste();
            }
            else
            {
                MessageBox.Show("LÜTFEN  SİLECEĞİNİZ ALANI SEÇİNİZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && txttel.Text != "")
            {

                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_PERSONEL.Find(id);
                deger.PERSONEL = txtad.Text;
                deger.SOYADI = txtsoyad.Text;
                deger.DEPARTMAN = byte.Parse(lkpdepartman.EditValue.ToString());
                deger.TELEFON = txttel.Text;
                deger.MAIL = txtmaıl.Text;
                db.SaveChanges();
                MessageBox.Show("DEPARTMAN BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                liste();
            }
            else
            {

                MessageBox.Show("LÜTFEN  GÜNCELLECEĞİNİZ ALANLARI BOŞ BIRAKMAYIN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtad_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtad.Focus();
        }

        private void txtsoyad_Click(object sender, EventArgs e)
        {
            txtsoyad.Text = "";
            txtsoyad.Focus();
        }

        private void txtfoto_Click(object sender, EventArgs e)
        {
            txtfoto.Text = "";
            txtfoto.Focus();
        }

        private void txtmaıl_Click(object sender, EventArgs e)
        {
            txtmaıl.Text = "";
            txtmaıl.Focus();
        }

        private void txttel_Click(object sender, EventArgs e)
        {
            txtmaıl.Text = "";
            txtmaıl.Focus();
        }
    }
}
