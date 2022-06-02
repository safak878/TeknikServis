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
    public partial class FATURA_KALEM_POPUP : MetroFramework.Forms.MetroForm
    {
        public FATURA_KALEM_POPUP()
        {
            InitializeComponent();
        }
        public int id;
        private void FATURA_KALEM_POPUP_Load(object sender, EventArgs e)
        {
            DbTeknıkServısEntities db = new DbTeknıkServısEntities();
            gridControl1.DataSource = (from u in db.TBL_FATURADETAY
                                       select new
                                       {

                                           u.FATURADETAYID,
                                           u.URUN,
                                           u.ADET,
                                           u.FIYAT,
                                           u.TUTAR,
                                           u.FATURAID
                                       }).Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBL_FATURABILGI.Where(x => x.ID == id).ToList();
        }
  


           
    private void pictureEdit1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            sfd.Filter = "Pdf dosyası(*.pdf)|*.pdf|Tüm dosyalar|*.*";

            sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "DOSYA";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                string path = (sfd.FileName);
                gridControl1.ExportToPdf(path);
            }

       
            

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {

            SaveFileDialog aa = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            aa.Filter = "Excel dosyası(*.xls)|*.xls|Tüm dosyalar|*.*";

            aa.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            aa.FileName = "DOSYA";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = aa.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                string path = (aa.FileName);
                gridControl1.ExportToXlsx(path);
            }

           
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
