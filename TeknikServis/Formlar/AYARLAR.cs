using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeknikServis.Formlar
{
    public partial class AYARLAR : MetroFramework.Forms.MetroForm
    {
        public AYARLAR()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN", bgl.baglantı());
            bgl.baglantı();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void AYARLAR_Load(object sender, EventArgs e)
        {
            listele();
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
          
        }

        private void lollipopButton3_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text !="" && metroTextBox2.Text != "") { 
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values(@p1,@p2)", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", metroTextBox1.Text);
                komut.Parameters.AddWithValue("@p2", metroTextBox2.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Yeni kullanıcı sisteme kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
            }
            else
            {

                MessageBox.Show("KAYIT KAYDEDİLEMEDİ LÜTFEN ZORUNLU ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            gridControl1.Enabled = true;
            metroPanel1.Enabled = true;
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
        }

        private void lollipopButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("KULLANICIYI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
                {
                    SqlCommand komutsil3 = new SqlCommand("Delete from TBL_ADMIN where KULLANICIAD=@p1", bgl.baglantı());
                    komutsil3.Parameters.AddWithValue("@p1", metroTextBox1.Text);
                    komutsil3.ExecuteNonQuery();
                    bgl.baglantı().Close();
                    listele();
                }
                else
                {
                    MessageBox.Show("LÜTFEN SİLİCEĞİNİZ KULLANICIYI SEÇİNİZ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    listele();
                }

            }
        }

        private void lollipopButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                gridControl1.Enabled = true;
                metroPanel1.Enabled = true;
                SqlCommand komut1 = new SqlCommand("update TBL_ADMIN set SIFRE=@P2 where KULLANICIAD=@P1", bgl.baglantı());
                komut1.Parameters.AddWithValue("@p1", metroTextBox1.Text);
                komut1.Parameters.AddWithValue("@p2", metroTextBox2.Text);
                komut1.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Kayıt güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            else
            {
                MessageBox.Show("KAYIT GÜNCELLENEMEDİ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                metroTextBox1.Text = dr["KULLANICIAD"].ToString();
                metroTextBox2.Text = dr["SIFRE"].ToString();
            }
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
           
            }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
    }
    }
}
