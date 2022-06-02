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
    public partial class İSTATİSTİK : Form
    {
        public İSTATİSTİK()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void İSTATİSTİK_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBL_URUN.Count().ToString();
            labelControl3.Text = db.TBL_KATEGORI.Count().ToString();
            labelControl5.Text = db.TBL_URUN.Sum(x=>x.STOK).ToString();
            labelControl7.Text = "10";
            labelControl16.Text = (from x in db.TBL_URUN
                                   
                                   orderby x.STOK descending
                                  select x.AD).FirstOrDefault();

            labelControl14.Text = (from x in db.TBL_URUN

                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBL_URUN

                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl19.Text = (from x in db.TBL_URUN

                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl29.Text = db.TBL_URUN.Count(x => x.KATEGORİ == 4).ToString();

            labelControl23.Text = db.TBL_URUN.Count(x => x.KATEGORİ == 1).ToString();
            labelControl21.Text = db.TBL_URUN.Count(x => x.KATEGORİ == 3).ToString();
            labelControl39.Text = (from x in db.TBL_URUN

                                   select x.MARKA).Distinct().Count().ToString();

            labelControl35.Text = db.TBL_URUNKABUL.Count().ToString();

            labelControl11.Text = db.MAKSKATEGORİ().FirstOrDefault();
        }
    }
}
