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
    public partial class YENİ_ÜRÜN : MetroFramework.Forms.MetroForm
    {
        public YENİ_ÜRÜN()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void YENİ_ÜRÜN_Load(object sender, EventArgs e)
        {
            lkpdepartman.Properties.DataSource = (from x in db.TBL_KATEGORI
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            ;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txturunad.Text != "" && txtmarka.Text != "" && txtalısfıyat.Text != "" && txtsatısfıyat.Text != "" && txtstok.Text != "")
            {
                TBL_URUN t = new TBL_URUN();
                t.AD = txturunad.Text;
                t.ALISFIYAT = decimal.Parse(txtalısfıyat.Text);
                t.SATISFIYAT = decimal.Parse(txtsatısfıyat.Text);
                t.STOK = short.Parse(txtstok.Text);
                t.KATEGORİ = byte.Parse(lkpdepartman.EditValue.ToString());
                t.MARKA = txtmarka.Text;
                db.TBL_URUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                MessageBox.Show("KAYIT BAŞARISIZ! LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txturunad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmarka_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtkategori_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtalısfıyat_EditValueChanged(object sender, EventArgs e)
        {

         
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsatısfıyat_EditValueChanged(object sender, EventArgs e)
        {

            
        }

        private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtstok_EditValueChanged(object sender, EventArgs e)
        {

           
        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txturunad_Click(object sender, EventArgs e)
        {
            txturunad.Text = "";
            txturunad.Focus();

        }

        private void txtmarka_Click(object sender, EventArgs e)
        {

            txtmarka.Text = "";
            txtmarka.Focus();
        }

        private void txtalısfıyat_Click(object sender, EventArgs e)
        {

            txtalısfıyat.Text = "";
            txtalısfıyat.Focus();
        }

        private void txtsatısfıyat_Click(object sender, EventArgs e)
        {
            txtsatısfıyat.Text = "";
            txtsatısfıyat.Focus();
        }

        private void txtstok_Click(object sender, EventArgs e)
        {
            txtstok.Text = "";
            txtstok.Focus();
        }

        private void lkpdepartman_Click(object sender, EventArgs e)
        {
         
        }
    }
}
