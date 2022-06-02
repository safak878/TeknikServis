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
    public partial class FATURA_KALEMLERİ : Form
    {
        public FATURA_KALEMLERİ()
        {
            InitializeComponent();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtfaturaıd.Text);
                var degerler = (from u in db.TBL_FATURADETAY
                                select new
                                {

                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID
                                }).Where(x => x.FATURAID == id);

                gridControl1.DataSource = degerler.ToList();
            }
            catch
            {

                MessageBox.Show("EKSİK VEYA YANLIŞ BİLGİ GİRDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
