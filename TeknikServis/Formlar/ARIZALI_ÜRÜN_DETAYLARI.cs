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
    public partial class ARIZALI_ÜRÜN_DETAYLARI : Form
    {
        public ARIZALI_ÜRÜN_DETAYLARI()
        {
            InitializeComponent();
        }

        private void ARIZALI_ÜRÜN_DETAYLARI_Load(object sender, EventArgs e)
        {
            DbTeknıkServısEntities db = new DbTeknıkServısEntities();
            gridControl1.DataSource = (from x in db.TBL_URUNTAKIP
                                       select new
                                       {
                                           x.TAKIPID,
                                           x.SERINO,
                                           x.TARIH,
                                           x.ACIKLAMA

                                       }).ToList() ;
        }
    }
}
