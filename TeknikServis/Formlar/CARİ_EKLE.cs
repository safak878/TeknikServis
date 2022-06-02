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
    public partial class CARİ_EKLE : MetroFramework.Forms.MetroForm
    {
        public CARİ_EKLE()
        {
            InitializeComponent();
        }

        private void CARİ_EKLE_Load(object sender, EventArgs e)
        {
            lookUpEdit3.Properties.DataSource = (from x in db.İL
                                                 select new
                                                 {

                                                     x.id,
                                                     x.sehir
                                                     
                                                 }).ToList();
        }
        DbTeknıkServısEntities db = new DbTeknıkServısEntities();
        int secilen;
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (txtad.Text !="" && txtsoyad.Text != "" && lookUpEdit3.Text != "" && lookUpEdit2.Text != "" && txtmaıl.Text != "" && txtbanka.Text != "" && txtvergıdaıre.Text != "" && txtvergıno.Text != "")
            { 

                TBL_CARI t = new TBL_CARI();
                t.AD = txtad.Text;
                t.SOYADI = txtsoyad.Text;
                t.IL = lookUpEdit3.Text;
                t.ILCE = lookUpEdit2.Text;
                t.MAIL = txtmaıl.Text;
                t.ADRES = txtadres.Text;
                t.BANKA = txtbanka.Text;
                t.STATU = txtstatu.Text;
                t.VERGIDAIRE = txtvergıdaıre.Text;
                t.VERGINO = txtvergıno.Text;
                t.ACIKLAMA = txtacıklama.Text;
                db.TBL_CARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("YENİ CARİ SİSTEME BAŞARILI BİR ŞEKİLDE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           else
            {
                MessageBox.Show("LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit14_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit3.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.İLCE
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir

                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void txtad_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtad.Focus();
        }

        private void txtsoyad_Click(object sender, EventArgs e)
        {
            txtsoyad.Text = "";
            txtsoyad.Focus();
        }

        private void txttel_Click(object sender, EventArgs e)
        {
            txttel.Text = "";
            txttel.Focus();
        }

        private void txtmaıl_Click(object sender, EventArgs e)
        {
            txtmaıl.Text = "";
            txtmaıl.Focus();
        }

        private void txtbanka_Click(object sender, EventArgs e)
        {
            txtbanka.Text = "";
            txtbanka.Focus();
        }

        private void txtvergıdaıre_Click(object sender, EventArgs e)
        {
            txtvergıdaıre.Text = "";
            txtvergıdaıre.Focus();
        }

        private void txtvergıno_Click(object sender, EventArgs e)
        {
            txtvergıno.Text = "";
            txtvergıno.Focus();
        }

        private void txtstatu_Click(object sender, EventArgs e)
        {
            txtstatu.Text = "";
            txtstatu.Focus();
        }

        private void txtadres_Click(object sender, EventArgs e)
        {
            txtadres.Text = "";
            txtadres.Focus();
        }

        private void txtacıklama_Click(object sender, EventArgs e)
        {
            txtacıklama.Text = "";
            txtacıklama.Focus();
        }
    }
}
