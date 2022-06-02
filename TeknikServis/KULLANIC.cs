using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using System.Data.SqlClient;
namespace TeknikServis
{
    public partial class KULLANICI : MaterialForm
    {
        public KULLANICI()
        {
            Thread t = new Thread(new ThreadStart(startform));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
    public void startform()
        {

            Application.Run(new SPLASH());
        }

        private void KULLANIC_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            lollipopTextBox1.Text = Properties.Settings.Default.KULLANICIAD.ToString();
            lollipopTextBox2.Text = Properties.Settings.Default.SIFRE.ToString();
            if (lollipopTextBox1.Text.Count() > 1)
                lollipopCheckBox1.Checked = true;





        }


 

        sqlbaglantısı bgl = new sqlbaglantısı();
        private void lollipopButton1_Click(object sender, EventArgs e)
        {
           
          
            SqlCommand komut = new SqlCommand("select * from TBL_ADMIN where KULLANICIAD=@P1 and SIFRE=@P2", bgl.baglantı());
            komut.Parameters.AddWithValue("@P1", lollipopTextBox1.Text);
            komut.Parameters.AddWithValue("@P2", lollipopTextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (lollipopCheckBox1.Checked == true)
            {

                Properties.Settings.Default.KULLANICIAD = lollipopTextBox1.Text;
                Properties.Settings.Default.SIFRE = lollipopTextBox2.Text;
                Properties.Settings.Default.Save();
            }
            if (lollipopCheckBox1.Checked == false)
            {
                Properties.Settings.Default.KULLANICIAD = "";
                Properties.Settings.Default.SIFRE = "";
                Properties.Settings.Default.Save();
            }
         
            if (dr.Read())
            {
               

                Form2 fr = new Form2();
                fr.kullanıcı = lollipopTextBox1.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            bgl.baglantı().Close();
            
        }
    }
}
