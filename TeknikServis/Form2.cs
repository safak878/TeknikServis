using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();



        }
   
    private void BTNKATEGORİLİSTE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
       
    private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void btnyeniurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            Formlar.YENİ_KATEGORİ fr = new Formlar.YENİ_KATEGORİ();
            fr.Show();
        }
      
    private void btnistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
       
    private void btnmarka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }
       
    private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
      
    private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
        
    private void DepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }
        Formlar.YENİ_DEPARTMAN j;
        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (j == null || j.IsDisposed)
            {
                j = new Formlar.YENİ_DEPARTMAN();
                j.Show();
            }
        }
     
    private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        //Formlar.RAPOR t;
        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (t == null || t.IsDisposed)
            //{
            //    t = new Formlar.RAPOR();
            //    //fr.MdiParent = this;
            //    t.Show();
            //}
        }
        
    private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
     
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
       
    private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }
       
    private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
     
    private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
        
    private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
        }
      
    private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    
    private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }
      
    private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void btnhesapmakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
       
    private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
   
    private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        Formlar.YENİ_PERSONEL rt;
        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rt == null || rt.IsDisposed)
            {
                rt = new Formlar.YENİ_PERSONEL();
                rt.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
     
    private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
       
    private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }
        public string kullanıcı;
        Formlar.ANASAYFA fr;
      
        private void Form2_Load(object sender, EventArgs e)
        {


            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.ANASAYFA();
                fr.ad = kullanıcı;
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.ANASAYFA();
                
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
   
    private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
       
    private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }
     
    private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
       
    private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
      
    private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
      
    private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
      
    private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem10_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.KATEGORİ yyy;
        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            if (yyy == null || yyy.IsDisposed)
            {
                yyy = new Formlar.KATEGORİ();
                //yyy.MdiParent = this;
                yyy.Show();
            }
        }
        Formlar.ÜRÜN_LİSTESİ eee;
        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            if (eee == null || eee.IsDisposed)
            {
                eee = new Formlar.ÜRÜN_LİSTESİ();
                eee.MdiParent = this;
                eee.Show();
            }
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.YENİ_ÜRÜN fr = new Formlar.YENİ_ÜRÜN();
            fr.Show();
        }
        Formlar.İSTATİSTİK q;
        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

            if (q == null || q.IsDisposed)
            {
                q = new Formlar.İSTATİSTİK();
                q.MdiParent = this;
                q.Show();
            }
        }
        Formlar.MARKALAR v;
        private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (v == null || v.IsDisposed)
            {
                v = new Formlar.MARKALAR();
                v.MdiParent = this;
                v.Show();
            }
        }
        Formlar.ARIZA_LİSTESİ a;
        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (a == null || a.IsDisposed)
            {
                a = new Formlar.ARIZA_LİSTESİ();
                a.MdiParent = this;
                a.Show();
            }

        }
        Formlar.ARIZALI_ÜRÜN_KAYDI u;
        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (u == null || u.IsDisposed)
            {
                u = new Formlar.ARIZALI_ÜRÜN_KAYDI();
                //fr.MdiParent = this;
                u.Show();
            }
        }
        Formlar.ARIZALI_ÜRÜN_DETAYLARI z;
        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (z == null || z.IsDisposed)
            {
                z = new Formlar.ARIZALI_ÜRÜN_DETAYLARI();
                z.MdiParent = this;
                z.Show();
            }
        }

        Formlar.QRKOD dd;
        private void barButtonItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dd == null || dd.IsDisposed)
            {
                dd = new Formlar.QRKOD();
                //fr.MdiParent = this;
                dd.Show();
            }
        }
        Formlar.BARKOD fc;
        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (fc == null || fc.IsDisposed)
            {
                fc = new Formlar.BARKOD();
                //fr.MdiParent = this;
                fc.Show();
            }
        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.CARİ_EKLE fr = new Formlar.CARİ_EKLE();
            fr.Show();
        }
        Formlar.CARİ i;
        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (i == null || i.IsDisposed)
            {
                i = new Formlar.CARİ();
                i.MdiParent = this;
                i.Show();
            }
        }
        Formlar.CARİ_İLLER x;
        private void barButtonItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (x == null || x.IsDisposed)
            {
                x = new Formlar.CARİ_İLLER();
                x.MdiParent = this;
                x.Show();
            }
        }

        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.ÜRÜN_SATIŞ fr = new Formlar.ÜRÜN_SATIŞ();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.SATISLAR cc;
        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (cc == null || cc.IsDisposed)
            {
                cc = new Formlar.SATISLAR();
                cc.MdiParent = this;
                cc.Show();
            }
        }
        Formlar.FATURA_LİSTESİ b;
        private void barButtonItem62_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (b == null || b.IsDisposed)
            {
                b = new Formlar.FATURA_LİSTESİ();
                b.MdiParent = this;
                b.Show();
            }
        }

        private void barButtonItem63_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FATURA_KALEM ty;
        private void barButtonItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ty == null || ty.IsDisposed)
            {
                ty = new Formlar.FATURA_KALEM();
                ty.MdiParent = this;
                ty.Show();
            }

        }

        Formlar.FATURA_KALEMLERİ d;
        private void barButtonItem65_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (d == null || d.IsDisposed)
            {
                d = new Formlar.FATURA_KALEMLERİ();
                d.MdiParent = this;
                d.Show();
            }
        }

        Formlar.PERSONEL o;
        private void barButtonItem66_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (o == null || o.IsDisposed)
            {
                o = new Formlar.PERSONEL();
                o.MdiParent = this;
                o.Show();
            }
        }
        Formlar.DEPARTMAN p;
        private void barButtonItem67_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (p == null || p.IsDisposed)
            {
                p = new Formlar.DEPARTMAN();
                p.MdiParent = this;
                p.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.NOTLAR bb;
        private void barButtonItem69_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (bb == null || bb.IsDisposed)
            {
                bb = new Formlar.NOTLAR();
                bb.MdiParent = this;
                bb.Show();
            }
        }
        Formlar.KURLAR ff;
        private void barButtonItem70_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (ff == null || ff.IsDisposed)
            {
                ff = new Formlar.KURLAR();
                ff.MdiParent = this;
                ff.Show();
            }
        }
        Formlar.YOUTUBE gg;
        private void barButtonItem71_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       

            if (gg == null || gg.IsDisposed)
            {
                gg = new Formlar.YOUTUBE();
                gg.MdiParent = this;
                gg.Show();
            }
        }

        Formlar.HARİTA aa;
        private void barButtonItem72_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aa == null || aa.IsDisposed)
            {
                aa = new Formlar.HARİTA();
                aa.MdiParent = this;
                aa.Show();
            }
        }
       
        private void barButtonItem74_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
          
        }
       
        private void barButtonItem75_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

          
        }
       
        private void barButtonItem76_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
        
        private void barButtonItem78_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
           
        }
       
        private void barButtonItem79_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        
        }

        private void barButtonItem81_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            System.Diagnostics.Process.Start("Calc.exe");
            System.Windows.Forms.FormStartPosition.CenterScreen.ToString();
        }
       
    private void barButtonItem87_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
       
    private void barButtonItem86_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem85_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        İletişim.GELEN_MESAJLAR ss;
        private void barButtonItem84_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ss == null || ss.IsDisposed)
            {
                ss = new İletişim.GELEN_MESAJLAR();
                ss.MdiParent = this;
                ss.Show();
            }
        }
        Formlar.MAIL uub;
        private void barButtonItem83_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (uub == null || uub.IsDisposed)
            {
                uub = new Formlar.MAIL();
                uub.Show();
            }
        }
        İletişim.REHBER zz;
        private void barButtonItem82_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (zz == null || zz.IsDisposed)
            {
                zz = new İletişim.REHBER();
                zz.MdiParent = this;
                zz.Show();
            }
        }

        private void barButtonItem89_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem92_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem94_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Yedekleme.YEDEK gh;
        private void barButtonItem95_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (gh == null || gh.IsDisposed)
            {
                gh = new Yedekleme.YEDEK();
                gh.Show();
            }
        }
    
        private void barButtonItem94_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        Formlar.AYARLAR yu;
        private void barButtonItem96_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (yu == null || yu.IsDisposed)
            {
                yu = new Formlar.AYARLAR();
                yu.Show();
            }
        }
        Formlar.YAZDIR re;
        private void barButtonItem97_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (re == null || re.IsDisposed)
            {
                re = new Formlar.YAZDIR();
                re.MdiParent = this;
                re.Show();
            }
        }
    }
}
