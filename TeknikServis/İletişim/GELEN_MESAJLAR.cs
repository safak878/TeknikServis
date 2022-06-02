using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class GELEN_MESAJLAR : Form
    {
        public GELEN_MESAJLAR()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void GELEN_MESAJLAR_Load(object sender, EventArgs e)
        {
            labelControl12.Text = db.TBL_İLETİSİM.Count().ToString();
            labelControl14.Text = db.TBL_İLETİSİM.Where(x=>x.KONU=="TEŞEKKÜR MESAJI").Count().ToString();
            labelControl16.Text = db.TBL_İLETİSİM.Where(x => x.KONU == "RİCA MESAJI").Count().ToString();
            labelControl18.Text = db.TBL_İLETİSİM.Where(x => x.KONU == "ŞİKAYET MESAJI").Count().ToString();
            labelControl1.Text = db.TBL_PERSONEL.Count().ToString();
            labelControl3.Text = db.TBL_CARI.Count().ToString();
            labelControl5.Text = db.TBL_KATEGORI.Count().ToString();
            labelControl7.Text = db.TBL_URUN.Count().ToString();
            //labelControl9.Text = db.TBL_DEPARTMAN.Count().ToString();

            gridControl1.DataSource = (from x in db.TBL_İLETİSİM
                                       select new
                                       {

                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAIL,
                                           x.MESAJ
                                       }).ToList();



        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
    }
}
