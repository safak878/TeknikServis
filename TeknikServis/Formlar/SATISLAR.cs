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
    public partial class SATISLAR : Form
    {
        public SATISLAR()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void SATISLAR_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_HAREKET
                           select new{

                               x.HAREKETID,
                               x.TBL_URUN.AD,
                               MUSTERI=x.TBL_CARI.AD+" "+x.TBL_CARI.SOYADI,
                               PERSONEL=x.TBL_PERSONEL.PERSONEL+" "+x.TBL_PERSONEL.SOYADI,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO



            };

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
