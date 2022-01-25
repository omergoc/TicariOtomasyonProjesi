
namespace TicariOtomasyonProjesi.Anasayfa
{
    partial class FrmAnasayfa
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
            this.gridUrunStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSon5Satis = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridFirmaListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCariListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSon5Satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirmaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUrunStok
            // 
            this.gridUrunStok.Location = new System.Drawing.Point(12, 12);
            this.gridUrunStok.MainView = this.gridView1;
            this.gridUrunStok.Name = "gridUrunStok";
            this.gridUrunStok.Size = new System.Drawing.Size(400, 227);
            this.gridUrunStok.TabIndex = 0;
            this.gridUrunStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridUrunStok;
            this.gridView1.Name = "gridView1";
            // 
            // gridSon5Satis
            // 
            this.gridSon5Satis.Location = new System.Drawing.Point(12, 245);
            this.gridSon5Satis.MainView = this.gridView2;
            this.gridSon5Satis.Name = "gridSon5Satis";
            this.gridSon5Satis.Size = new System.Drawing.Size(400, 243);
            this.gridSon5Satis.TabIndex = 1;
            this.gridSon5Satis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridSon5Satis;
            this.gridView2.Name = "gridView2";
            // 
            // gridFirmaListesi
            // 
            this.gridFirmaListesi.Location = new System.Drawing.Point(433, 245);
            this.gridFirmaListesi.MainView = this.gridView3;
            this.gridFirmaListesi.Name = "gridFirmaListesi";
            this.gridFirmaListesi.Size = new System.Drawing.Size(400, 243);
            this.gridFirmaListesi.TabIndex = 3;
            this.gridFirmaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridFirmaListesi;
            this.gridView3.Name = "gridView3";
            // 
            // gridCariListesi
            // 
            this.gridCariListesi.Location = new System.Drawing.Point(433, 12);
            this.gridCariListesi.MainView = this.gridView4;
            this.gridCariListesi.Name = "gridCariListesi";
            this.gridCariListesi.Size = new System.Drawing.Size(400, 227);
            this.gridCariListesi.TabIndex = 2;
            this.gridCariListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridCariListesi;
            this.gridView4.Name = "gridView4";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(839, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(415, 476);
            this.webBrowser1.TabIndex = 4;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 500);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gridFirmaListesi);
            this.Controls.Add(this.gridCariListesi);
            this.Controls.Add(this.gridSon5Satis);
            this.Controls.Add(this.gridUrunStok);
            this.Name = "FrmAnasayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSon5Satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirmaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUrunStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridSon5Satis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridFirmaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridCariListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}