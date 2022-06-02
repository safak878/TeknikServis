using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class PRİNT : Form
    {
        List<URUN_Result> list;
        public PRİNT(List<URUN_Result> list)
        {
            InitializeComponent();
        this.list=list;
        }

        private void PRİNT_Load(object sender, EventArgs e)
        {
            CrystalReport11.SetDataSource(list);
            crystalReportViewer1.Refresh();
        }
    }
}
