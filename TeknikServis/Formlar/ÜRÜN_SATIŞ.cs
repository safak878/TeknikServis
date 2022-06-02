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
    public partial class ÜRÜN_SATIŞ : MetroFramework.Forms.MetroForm
    {
        public ÜRÜN_SATIŞ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {


            try
            {

                TBL_HAREKET t = new TBL_HAREKET();
                t.URUN = int.Parse(lkpurun.EditValue.ToString());
                t.MUSTERI = int.Parse(lkpcari.EditValue.ToString());
                t.PERSONEL = short.Parse(lkppersonel.EditValue.ToString());
                t.TARIH = DateTime.Parse(dateEdit1.Text);
                t.ADET = short.Parse(txtadet.Text);
                t.FIYAT = decimal.Parse(txtsatısfıyat.Text);
                t.URUNSERINO = txtsrıno.Text;
                db.TBL_HAREKET.Add(t);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN SATIŞI YAPILDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            catch
            {
                MessageBox.Show("ÜRÜN SATIŞI YAPILAMADI! LÜTFEN GEREKLİ ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void ÜRÜN_SATIŞ_Load(object sender, EventArgs e)
        {
            lkpurun.Properties.DataSource = (from x in db.TBL_URUN
                                             select new
                                             {
                                                 x.ID,
                                                 x.AD
                                             }).ToList();

            lkpcari.Properties.DataSource = (from x in db.TBL_CARI
                                             select new
                                             {
                                                 x.ID,
                                                 AD = x.AD + " " + x.SOYADI
                                             }).ToList();

            lkppersonel.Properties.DataSource = (from x in db.TBL_PERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.PERSONEL + " " + x.SOYADI
                                                 }).ToList();
            ;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkpurun_Click(object sender, EventArgs e)
        {
            lkpurun.Text = "";
            lkpurun.Focus();
        }

        private void lkpcari_Click(object sender, EventArgs e)
        {
            lkpcari.Text = "";
            lkpcari.Focus();
        }

        private void txtsrıno_Click(object sender, EventArgs e)
        {
            txtsrıno.Text = "";
            txtsrıno.Focus();
        }

        private void txtsatısfıyat_Click(object sender, EventArgs e)
        {
            txtsatısfıyat.Text = "";
            txtsatısfıyat.Focus();
        }

        private void txtadet_Click(object sender, EventArgs e)
        {
            txtadet.Text = "";
            txtadet.Focus();
        }

        private void lkppersonel_Click(object sender, EventArgs e)
        {
            lkppersonel.Text = "";
            lkppersonel.Focus();
        }
    }
}
