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
    public partial class YAZDIR : Form
    {
        public YAZDIR()
        {
            InitializeComponent();
        }

        private void YAZDIR_Load(object sender, EventArgs e)
        {
            using(DbTeknıkServısEntities2 db = new DbTeknıkServısEntities2())
            {


                uRUNResultBindingSource.DataSource = db.URUN().ToList();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<URUN_Result> list = uRUNResultBindingSource.DataSource as List<URUN_Result>;
            if(list != null)
                
                {
                using (PRİNT frm = new PRİNT(list))
                {


                    frm.ShowDialog();
                }

            

            }
        }
    }
}
