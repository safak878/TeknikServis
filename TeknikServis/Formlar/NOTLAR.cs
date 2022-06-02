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
    public partial class NOTLAR : Form
    {
        public NOTLAR()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        void temizle(){
            txtıd.Text = "";
            txtbaslık.Text = "";
            txtıcerık.Text = "";

        }

    private void NOTLAR_Load(object sender, EventArgs e)
            
        {
          
            gridControl1.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == true).ToList();
            temizle();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtbaslık.Text != "" && txtıcerık.Text != "")
            {
                TBL_NOTLAR t = new TBL_NOTLAR();
                t.BASLIK = txtbaslık.Text;
                t.ICERIK = txtıcerık.Text;
                t.DURUM = false;
                t.TARIH = DateTime.Parse(dtmtarih.Text);
                db.TBL_NOTLAR.Add(t);
                db.SaveChanges();
                MessageBox.Show("NOT BAŞARIYLA KAYDEDİLDİ", "BASLIK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == false).ToList();
                gridControl2.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == true).ToList();
                temizle();
            }
            else
            {
                MessageBox.Show("LÜTFEN ZORUNLU ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (OKUNDU.Checked == true)
            {
                try
                {
                    int id = int.Parse(txtıd.Text);
                    var deger = db.TBL_NOTLAR.Find(id);
                    deger.DURUM = true;
                    db.SaveChanges();
                    gridControl1.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == false).ToList();
                    gridControl2.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == true).ToList();
                    MessageBox.Show("NOT DURUMU DEĞİŞTİRİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OKUNDU.Checked = false;
                    temizle();
                }

                catch
                {

                    MessageBox.Show("İD ALANI BOŞ OLAMAZ", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtbaslık.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            txtıcerık.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            dtmtarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
        }

        private void OKUNDU_Click(object sender, EventArgs e)
        {



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBL_NOTLAR.Find(id);
                db.TBL_NOTLAR.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("NOT BAŞARIYLA SİLİNDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == false).ToList();
                gridControl2.DataSource = db.TBL_NOTLAR.Where(x => x.DURUM == true).ToList();
                temizle();
            }
            catch
            {
                MessageBox.Show("LÜTFEN SİLECEĞİNİZ ALANI SEÇİN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            txtbaslık.Text = gridView2.GetFocusedRowCellValue("BASLIK").ToString();
            txtıcerık.Text = gridView2.GetFocusedRowCellValue("ICERIK").ToString();
            dtmtarih.Text = gridView2.GetFocusedRowCellValue("TARIH").ToString();
        }
    }
}
