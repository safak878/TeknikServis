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
    public partial class ARIZA_DETAY : MetroFramework.Forms.MetroForm
    {
        public ARIZA_DETAY()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtseri.Text != "" && dateTimePicker1.Text != "" )
            {
                DbTeknıkServısEntities db = new DbTeknıkServısEntities();
                TBL_URUNTAKIP t = new TBL_URUNTAKIP();
                t.ACIKLAMA = rchdetay.Text;
                t.SERINO = txtseri.Text;
                t.TARIH = DateTime.Parse(dateTimePicker1.Text);
                db.TBL_URUNTAKIP.Add(t);
                db.SaveChanges();


                TBL_URUNKABUL tb = new TBL_URUNKABUL();
                int urunid = int.Parse(id.ToString());
                var deger = db.TBL_URUNKABUL.Find(urunid);
                deger.DURUMDETAY = comboBox1.Text;
                db.SaveChanges();
                MessageBox.Show("ÜRÜN ARIZA DETAYLARI GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("ÜRÜN ARIZA DETAYLARI GÜNCELLENEMEDİ! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string id, serino;
        private void ARIZA_DETAY_Load(object sender, EventArgs e)
        {
            txtseri.Text = serino;

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
