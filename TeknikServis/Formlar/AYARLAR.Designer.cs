namespace TeknikServis.Formlar
{
    partial class AYARLAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AYARLAR));
            this.lollipopButton3 = new LollipopButton();
            this.lollipopButton2 = new LollipopButton();
            this.tBLADMINBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.colSIFRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKULLANICIAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLADMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lollipopButton4 = new LollipopButton();
            this.lollipopButton1 = new LollipopButton();
            this.tBLADMINBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tBLADMINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource2)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lollipopButton3
            // 
            this.lollipopButton3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton3.BGColor = "#508ef5";
            this.lollipopButton3.FontColor = "#ffffff";
            this.lollipopButton3.Location = new System.Drawing.Point(501, 203);
            this.lollipopButton3.Name = "lollipopButton3";
            this.lollipopButton3.Size = new System.Drawing.Size(163, 34);
            this.lollipopButton3.TabIndex = 22;
            this.lollipopButton3.Text = "KAYDET";
            this.lollipopButton3.Click += new System.EventHandler(this.lollipopButton3_Click);
            // 
            // lollipopButton2
            // 
            this.lollipopButton2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton2.BGColor = "#508ef5";
            this.lollipopButton2.FontColor = "#ffffff";
            this.lollipopButton2.Location = new System.Drawing.Point(670, 203);
            this.lollipopButton2.Name = "lollipopButton2";
            this.lollipopButton2.Size = new System.Drawing.Size(165, 34);
            this.lollipopButton2.TabIndex = 21;
            this.lollipopButton2.Text = "GÜNCELLE";
            this.lollipopButton2.Click += new System.EventHandler(this.lollipopButton2_Click);
            // 
            // tBLADMINBindingSource3
            // 
            this.tBLADMINBindingSource3.DataMember = "TBL_ADMIN";
            // 
            // colSIFRE
            // 
            this.colSIFRE.FieldName = "SIFRE";
            this.colSIFRE.Name = "colSIFRE";
            this.colSIFRE.Visible = true;
            this.colSIFRE.VisibleIndex = 2;
            // 
            // colKULLANICIAD
            // 
            this.colKULLANICIAD.FieldName = "KULLANICIAD";
            this.colKULLANICIAD.Name = "colKULLANICIAD";
            this.colKULLANICIAD.Visible = true;
            this.colKULLANICIAD.VisibleIndex = 1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKULLANICIAD,
            this.colSIFRE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLADMINBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(501, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(334, 134);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // tBLADMINBindingSource
            // 
            this.tBLADMINBindingSource.DataSource = typeof(TeknikServis.TBL_ADMIN);
            // 
            // lollipopButton4
            // 
            this.lollipopButton4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton4.BGColor = "#508ef5";
            this.lollipopButton4.FontColor = "#ffffff";
            this.lollipopButton4.Location = new System.Drawing.Point(501, 243);
            this.lollipopButton4.Name = "lollipopButton4";
            this.lollipopButton4.Size = new System.Drawing.Size(165, 34);
            this.lollipopButton4.TabIndex = 23;
            this.lollipopButton4.Text = "SİL";
            this.lollipopButton4.Click += new System.EventHandler(this.lollipopButton4_Click);
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(672, 243);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(163, 34);
            this.lollipopButton1.TabIndex = 19;
            this.lollipopButton1.Text = "VAZGEÇ";
            this.lollipopButton1.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // tBLADMINBindingSource2
            // 
            this.tBLADMINBindingSource2.DataMember = "TBL_ADMIN";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(100, 162);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(55, 17);
            this.lollipopLabel2.TabIndex = 7;
            this.lollipopLabel2.Text = "ŞİFRE :";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(44, 133);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(111, 17);
            this.lollipopLabel1.TabIndex = 5;
            this.lollipopLabel1.Text = "KULLANICI ADI :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureEdit1);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.lollipopLabel2);
            this.metroPanel1.Controls.Add(this.lollipopLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(472, 205);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(151, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(181, 109);
            this.pictureEdit1.TabIndex = 10;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLADMINBindingSource, "SIFRE", true));
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(161, 162);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(227, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLADMINBindingSource, "KULLANICIAD", true));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(161, 133);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(227, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBLADMINBindingSource1
            // 
            this.tBLADMINBindingSource1.DataSource = typeof(TeknikServis.TBL_ADMIN);
            // 
            // AYARLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 306);
            this.Controls.Add(this.lollipopButton3);
            this.Controls.Add(this.lollipopButton2);
            this.Controls.Add(this.lollipopButton4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AYARLAR";
            this.Resizable = false;
            this.Text = "AYARLAR";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AYARLAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource2)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLADMINBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopButton lollipopButton3;
        private LollipopButton lollipopButton2;
        private System.Windows.Forms.BindingSource tBLADMINBindingSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colSIFRE;
        private DevExpress.XtraGrid.Columns.GridColumn colKULLANICIAD;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tBLADMINBindingSource;
        private LollipopButton lollipopButton4;
        private LollipopButton lollipopButton1;
        private System.Windows.Forms.BindingSource tBLADMINBindingSource2;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.BindingSource tBLADMINBindingSource1;
    }
}