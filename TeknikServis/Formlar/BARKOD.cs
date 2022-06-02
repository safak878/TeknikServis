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
    public partial class BARKOD : MetroFramework.Forms.MetroForm
    {
        public BARKOD()
        {
            InitializeComponent();
        }

        private void BARKOD_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureEdit1.Image = brc.Draw(textEdit1.Text,35);
        }
    }
}
