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
    public partial class REHBER : Form
    {
        public REHBER()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void REHBER_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_CARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYADI,
                                           x.TELEFON,
                                           x.MAIL
                                       }).ToList();
        }
    }
}
