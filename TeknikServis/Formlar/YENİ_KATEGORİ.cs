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
    public partial class YENİ_KATEGORİ : MetroFramework.Forms.MetroForm
    {
        public YENİ_KATEGORİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkategoriad.Text != "" && txtkategoriad.Text.Length <= 30)
            {
                TBL_KATEGORI t = new TBL_KATEGORI();
                t.AD = txtkategoriad.Text;
                db.TBL_KATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("LÜTFEN KARAKTER SAYISINI 0-30 ARASINDA GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
       
        private void YENİ_KATEGORİ_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtkategoriad_Click(object sender, EventArgs e)
        {
            txtkategoriad.Text = "";
            txtkategoriad.Focus();
        }
    }
}
