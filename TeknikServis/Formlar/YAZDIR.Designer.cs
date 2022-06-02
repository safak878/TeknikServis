namespace TeknikServis.Formlar
{
    partial class YAZDIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YAZDIR));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.uRUNResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.uRUNResultBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1910, 791);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // uRUNResultBindingSource
            // 
            this.uRUNResultBindingSource.DataSource = typeof(TeknikServis.URUN_Result);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAD,
            this.colMARKA,
            this.colALISFIYAT,
            this.colSATISFIYAT,
            this.colSTOK});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            // 
            // colMARKA
            // 
            this.colMARKA.FieldName = "MARKA";
            this.colMARKA.Name = "colMARKA";
            this.colMARKA.Visible = true;
            this.colMARKA.VisibleIndex = 2;
            // 
            // colALISFIYAT
            // 
            this.colALISFIYAT.FieldName = "ALISFIYAT";
            this.colALISFIYAT.Name = "colALISFIYAT";
            this.colALISFIYAT.Visible = true;
            this.colALISFIYAT.VisibleIndex = 3;
            // 
            // colSATISFIYAT
            // 
            this.colSATISFIYAT.FieldName = "SATISFIYAT";
            this.colSATISFIYAT.Name = "colSATISFIYAT";
            this.colSATISFIYAT.Visible = true;
            this.colSATISFIYAT.VisibleIndex = 4;
            // 
            // colSTOK
            // 
            this.colSTOK.FieldName = "STOK";
            this.colSTOK.Name = "colSTOK";
            this.colSTOK.Visible = true;
            this.colSTOK.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1650, 798);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(262, 34);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "RAPOR OLUŞTUR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // YAZDIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 941);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "YAZDIR";
            this.Text = "YAZDIR";
            this.Load += new System.EventHandler(this.YAZDIR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource uRUNResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMARKA;
        private DevExpress.XtraGrid.Columns.GridColumn colALISFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK;
    }
}