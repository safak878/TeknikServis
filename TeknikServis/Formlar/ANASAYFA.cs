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
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
          

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5
               /* konu6, ad6, konu7, ad7, konu8, ad8, konu9, ad9, konu10, ad10*/;
            konu1 = db.TBL_İLETİSİM.First(x => x.ID == 1).KONU;
            ad1 = db.TBL_İLETİSİM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;

            konu2 = db.TBL_İLETİSİM.First(x => x.ID == 2).KONU;
            ad2 = db.TBL_İLETİSİM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2 + " - " + ad2;

            konu3 = db.TBL_İLETİSİM.First(x => x.ID == 3).KONU;
            ad3 = db.TBL_İLETİSİM.First(x => x.ID == 3).ADSOYAD;
            labelControl4.Text = konu3 + " - " + ad3;

            konu4 = db.TBL_İLETİSİM.First(x => x.ID == 4).KONU;
            ad4 = db.TBL_İLETİSİM.First(x => x.ID == 4).ADSOYAD;
            labelControl3.Text = konu4 + " - " + ad4;

            konu5 = db.TBL_İLETİSİM.First(x => x.ID == 5).KONU;
            ad5 = db.TBL_İLETİSİM.First(x => x.ID == 5).ADSOYAD;
            labelControl8.Text = konu5 + " - " + ad5;

            //konu6 = db.TBL_İLETİSİM.First(x => x.ID == 6).KONU;
            //ad6 = db.TBL_İLETİSİM.First(x => x.ID == 6).ADSOYAD;
            //labelControl6.Text = konu6 + " - " + ad6;

            //konu7 = db.TBL_İLETİSİM.First(x => x.ID == 7).KONU;
            //ad7 = db.TBL_İLETİSİM.First(x => x.ID == 7).ADSOYAD;
            //labelControl7.Text = konu7 + " - " + ad7;

            //konu8 = db.TBL_İLETİSİM.First(x => x.ID == 8).KONU;
            //ad8 = db.TBL_İLETİSİM.First(x => x.ID == 8).ADSOYAD;
            //labelControl5.Text = konu8 + " - " + ad8;

            //konu9 = db.TBL_İLETİSİM.First(x => x.ID == 9).KONU;
            //ad9 = db.TBL_İLETİSİM.First(x => x.ID == 9).ADSOYAD;
            //labelControl10.Text = konu9 + " - " + ad9;

            //konu10 = db.TBL_İLETİSİM.First(x => x.ID == 10).KONU;
            //ad10 = db.TBL_İLETİSİM.First(x => x.ID == 10).ADSOYAD;
            //labelControl9.Text = konu10 + " - " + ad10;
        }
        public string ad;
        private void ANASAYFA_Load_1(object sender, EventArgs e)
        {
            lollipopLabel2.Text = ad;

            gridControl4.DataSource = (from x in db.TBL_URUN
                                       select new
                                       {

                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 50).ToList();

            gridControl6.DataSource = (from y in db.TBL_CARI
                                       select new
                                       {

                                           y.AD,
                                           y.SOYADI,
                                           y.IL
                                       }).ToList();

            gridControl7.DataSource = db.URUNKATEGORİ().ToList();


            DateTime bgn = DateTime.Today;
            var deger = (from x in db.TBL_NOTLAR.OrderBy(y => y.ID)
                         where (x.TARIH == bgn)

                         select new
                         {


                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl8.DataSource = deger.ToList();
        }

        private void gridControl8_Click(object sender, EventArgs e)
        {

        }
    }
}
