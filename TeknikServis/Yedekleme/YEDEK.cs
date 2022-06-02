using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
using System.IO;
namespace TeknikServis.Yedekleme
{
    public partial class YEDEK : MetroFramework.Forms.MetroForm
    {


        public YEDEK()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            try
            {


                Server dbServer = new Server(new ServerConnection(txtserver.Text, txtuser.Text, txtpassword.Text));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = txtdatabase.Text };
                dbBackup.Devices.AddDevice(@"D:\projeyedek\otomasyon.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += dbBackup_PercentComplate;
                dbBackup.Complete += dbBackup_Complate;
                dbBackup.SqlBackupAsync(dbServer);

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dbBackup_Complate(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbldurum.Invoke((MethodInvoker)delegate
               {
                   lbldurum.Text = e.Error.Message;
               });

            }
        }
        private void dbBackup_PercentComplate(object sender, PercentCompleteEventArgs e)
        {
            progressBarControl1.Invoke((MethodInvoker)delegate
            {


                progressBarControl1.EditValue = e.Percent;
                progressBarControl1.Update();
            });
            lblyüzde.Invoke((MethodInvoker)delegate
            {
                lblyüzde.Text = $"{e.Percent}%";
            });
        }

        private void YEDEK_Load(object sender, EventArgs e)
        {

        }
    }
}
