using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace TeknikServis.Formlar
{
    public partial class MAIL : MetroFramework.Forms.MetroForm
    {
        public MAIL()
        {
            InitializeComponent();
        }
        string DosyaYolu;
        private void MAIL_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "ŞAFAK TİCARET";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            if (DosyaYolu != null)
            {
                labelControl1.Text = "DOSYA EKLENDİ";
                labelControl1.ForeColor = Color.Green;


            }
            else
            {
                labelControl1.Text = "DOSYA EKLENEMEDİ";
                labelControl1.ForeColor = Color.Red;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string formmail = "safak_101_81@hotmail.com";
            string sifre = "Safak.kusmez81";
            string alıcı = txtmaıladres.Text;
            string konu = txtkonu.Text;
            string mesaj = rxhmesaj.Text;
            mail.From = new MailAddress(formmail);
            mail.To.Add(alıcı);
            mail.Subject = konu;
            mail.Body = mesaj;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.Credentials = new NetworkCredential(formmail, sifre);
            smtp.EnableSsl = true;
            if (DosyaYolu != null)
            {
                mail.Attachments.Add(new Attachment(DosyaYolu));
            }

            smtp.Send(mail);

            MessageBox.Show("Mail gönderildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
