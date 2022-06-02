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
    public partial class FATURA_LİSTESİ : Form
    {
        public FATURA_LİSTESİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void temizle()
        {

            txtıd.Text = "";
            txtseri.Text = "";
            txtsıra.Text = "";
            timeEdit1.Text = "";
            dateTimePicker1.Text = "";
            txtvergidaire.Text = "";
            lkpcarı.Text = "";
            lkppersonel.Text = "";

        }
        void liste()
        {
            var degerler = from u in db.TBL_FATURABILGI
                           select new
                           {

                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBL_CARI.AD + u.TBL_CARI.SOYADI,
                               PERSONEL = u.TBL_PERSONEL.PERSONEL + u.TBL_PERSONEL.SOYADI
                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FATURA_LİSTESİ_Load(object sender, EventArgs e)
        {
            {
               
                liste();

                temizle();
                btnkaydet.Enabled = true;
                var degerler = from u in db.TBL_FATURABILGI
                               select new
                               {

                                   u.ID,
                                   u.SERI,
                                   u.SIRANO,
                                   u.TARIH,
                                   u.SAAT,
                                   u.VERGIDAIRE,
                                   CARI = u.TBL_CARI.AD +" "+ u.TBL_CARI.SOYADI,
                                   PERSONEL = u.TBL_PERSONEL.PERSONEL +" " + u.TBL_PERSONEL.SOYADI
                               };

                gridControl1.DataSource = degerler.ToList();

                lkpcarı.Properties.DataSource = (from x in db.TBL_CARI
                                                     select new
                                                     {
                                                         x.ID,
                                                        AD =x.AD + " " + x.SOYADI

                                                     }).ToList();
                ;
                lkppersonel.Properties.DataSource = (from x in db.TBL_PERSONEL
                                                     select new
                                                     {
                                                         x.ID,
                                                         AD = x.PERSONEL + " " + x.SOYADI

                                                     }).ToList();
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_FATURABILGI
                           select new
                           {

                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               u.TBL_CARI.AD,/* " " + u.TBL_CARI.SOYADI,*/
                               u.TBL_PERSONEL.PERSONEL /*+ " " + u.TBL_PERSONEL.SOYADI,*/

                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtseri.Text !="" && txtsıra.Text != "" && timeEdit1.Text != "" && txtvergidaire.Text != "")
            {
                TBL_FATURABILGI t = new TBL_FATURABILGI();
                t.SIRANO = txtsıra.Text;
                t.SERI = txtseri.Text;
                t.TARIH = Convert.ToDateTime(dateTimePicker1.Text);
                t.SAAT = timeEdit1.Text;
                t.VERGIDAIRE = txtvergidaire.Text;
                t.CARI = int.Parse(lkpcarı.EditValue.ToString());
                t.PERSONEL = short.Parse(lkppersonel.EditValue.ToString());
                db.TBL_FATURABILGI.Add(t);
                db.SaveChanges();
                MessageBox.Show("FATURA SİSTEME KAYDEDİLMİŞTİR,KALEM GİRİŞİ YAPABİLİRSİNİZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            else
            {

                MessageBox.Show("FATURA SİSTEME KAYDEDİLEMEMİŞTİR! LÜTFEN ZORUNLU ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FATURA_KALEM_POPUP fr = new FATURA_KALEM_POPUP();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtseri.Text != "" && txtsıra.Text != "" && timeEdit1.Text != "" && txtvergidaire.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_FATURABILGI.Find(id);
                deger.SERI = txtseri.Text;
                deger.SIRANO = txtsıra.Text;
                deger.TARIH = Convert.ToDateTime(dateTimePicker1.Text);
                deger.SAAT = timeEdit1.Text;
                deger.VERGIDAIRE = txtvergidaire.Text;
                deger.CARI = int.Parse(lkpcarı.EditValue.ToString());
                deger.PERSONEL = short.Parse(lkppersonel.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("FATURA BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                liste();
            }

            else
            {

                MessageBox.Show("FATURA GÜNCELLENEMEDİ LÜTFEN GÜNCELLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtıd.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_FATURABILGI.Find(id);
                db.TBL_FATURABILGI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("FATURA BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                liste();

            }
            else
            {

                MessageBox.Show("FATURA SİLİNEMEDİ LÜTFEN SİLECEĞİNİZ ALANI SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtseri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtsıra.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            timeEdit1.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtvergidaire.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            lkpcarı.Text = gridView1.GetFocusedRowCellValue("CARI").ToString();
            lkppersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            btnkaydet.Enabled = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
            btnkaydet.Enabled = true;
        }
    }
}
