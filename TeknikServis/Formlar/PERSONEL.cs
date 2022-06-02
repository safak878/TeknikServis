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
    public partial class PERSONEL : Form
    {
        public PERSONEL()
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
                               u.TELEFON
                           };

            gridControl1.DataSource = degerler.ToList();

   
        }
        private void PERSONEL_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_PERSONEL
                           select new
                           {

                               u.ID,
                               u.PERSONEL,
                               u.SOYADI,
                               u.MAIL,
                               u.TELEFON
                           };

            gridControl1.DataSource = degerler.ToList();

          

            string ad1, soyad1,ad2,soyad2,ad3,soyad3,ad4,soyad4;
            ad1 = db.TBL_PERSONEL.First(x => x.ID == 1).PERSONEL;
            soyad1 = db.TBL_PERSONEL.First(x => x.ID == 1).SOYADI;
            labelControl9.Text = db.TBL_PERSONEL.First(x => x.ID == 1).MAIL;
            labelControl11.Text = db.TBL_PERSONEL.First(x => x.ID == 1).TBL_DEPARTMAN.AD;
            labelControl14.Text = ad1 + " " + soyad1;


            ad2 = db.TBL_PERSONEL.First(x => x.ID == 2).PERSONEL;
            soyad2 = db.TBL_PERSONEL.First(x => x.ID == 2).SOYADI;
            labelControl6.Text = db.TBL_PERSONEL.First(x => x.ID == 2).MAIL;
            labelControl4.Text = db.TBL_PERSONEL.First(x => x.ID == 2).TBL_DEPARTMAN.AD;
            labelControl3.Text = ad2 + " " + soyad2;



            ad3 = db.TBL_PERSONEL.First(x => x.ID == 3).PERSONEL;
            soyad3 = db.TBL_PERSONEL.First(x => x.ID == 3).SOYADI;
            labelControl16.Text = db.TBL_PERSONEL.First(x => x.ID == 3).MAIL;
            labelControl18.Text = db.TBL_PERSONEL.First(x => x.ID == 3).TBL_DEPARTMAN.AD;
            labelControl20.Text = ad3 + " " + soyad3;


            ad4 = db.TBL_PERSONEL.First(x => x.ID == 4).PERSONEL;
            soyad4 = db.TBL_PERSONEL.First(x => x.ID == 4).SOYADI;
            labelControl28.Text = db.TBL_PERSONEL.First(x => x.ID == 4).MAIL;
            labelControl30.Text = db.TBL_PERSONEL.First(x => x.ID == 4).TBL_DEPARTMAN.AD;
            labelControl32.Text = ad4 + " " + soyad4;



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
         
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
          
        }

        private void labelControl23_Click(object sender, EventArgs e)
        {

        }

        private void txttel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtfoto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void labelControl24_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtıd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }

        private void txtmaıl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkpdepartman_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void labelControl22_Click(object sender, EventArgs e)
        {

        }
    }
}
