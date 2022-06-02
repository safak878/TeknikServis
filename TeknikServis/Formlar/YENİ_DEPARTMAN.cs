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
    public partial class YENİ_DEPARTMAN : MetroFramework.Forms.MetroForm
    {
        public YENİ_DEPARTMAN()
        {
            InitializeComponent();
        }

        private void YENİ_DEPARTMAN_Load(object sender, EventArgs e)
        {

        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtdepartmantad.Text != "")
            {

                TBL_DEPARTMAN t = new TBL_DEPARTMAN();
                t.AD = txtdepartmantad.Text;
                db.TBL_DEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("DEPARTMAN BAŞARIYLA KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("DEPARTMAN  KAYDEDİLEMEDİ! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtdepartmantad_Click(object sender, EventArgs e)
        {
            txtdepartmantad.Text = "";
            txtdepartmantad.Focus();
        }
    }
}
