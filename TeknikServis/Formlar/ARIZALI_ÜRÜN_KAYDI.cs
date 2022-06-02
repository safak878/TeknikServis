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
    public partial class ARIZALI_ÜRÜN_KAYDI : MetroFramework.Forms.MetroForm
    {
        public ARIZALI_ÜRÜN_KAYDI()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (lkppersonel.Text != "" && txtseri.Text != "" && dateEdit1.Text != "")
            {
               
                TBL_URUNKABUL t = new TBL_URUNKABUL();
                t.CARI = int.Parse(lkpdepartman.EditValue.ToString());
                t.GELISTARIH = DateTime.Parse(dateEdit1.Text);
                t.PERSONEL = short.Parse(lkppersonel.EditValue.ToString());
                t.URUNSERINO = txtseri.Text;
                t.DURUMDETAY = "ÜRÜN KAYDOLDU";
                db.TBL_URUNKABUL.Add(t);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN ARIZA GİRİŞİ YAPILDI","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ARIZA GİRİŞİ YAPILAMADI! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void ARIZALI_ÜRÜN_KAYDI_Load(object sender, EventArgs e)
        {
            lkpdepartman.Properties.DataSource = (from x in db.TBL_CARI
                                                  select new
                                                  {
                                                      x.ID,
                                                      AD = x.AD + " " + x.SOYADI


                                                  }).ToList();
            ;
            lkppersonel.Properties.DataSource = (from x in db.TBL_PERSONEL
                                                  select new
                                                  {
                                                      x.ID,
                                                      AD = x.PERSONEL + " " + x.SOYADI


                                                  }).ToList();
            ;
            //lookUpEdit1.Properties.DataSource = (from x in db.TBL_HAREKET
            //                                     select new
            //                                     {
            //                                         x.HAREKETID,
            //                                         x.URUNSERINO


            //                                     }).ToList();
            //;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtıd_Click(object sender, EventArgs e)
        {
         
        }

        private void txtpersonel_Click(object sender, EventArgs e)
        {

        }
        private void txttrıh_Click(object sender, EventArgs e)
        {
           
        }

        private void txtseri_Click(object sender, EventArgs e)
        {
            txtseri.Text = "";
            txtseri.Focus();
        }
    }
}
