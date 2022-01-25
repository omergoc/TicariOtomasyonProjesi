
namespace TicariOtomasyonProjesi.Firmalar
{
    partial class FrmFirmalar
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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnFirmaYazdir = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnYeniFirmaListesi = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkiliTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkiliTc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkiliUnvan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkiliAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSektor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirmaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirmaTelefon = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaTelefon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(101, 173);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "SEHIR";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(167, 22);
            this.lookUpEdit1.TabIndex = 59;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(396, 173);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "ILCE";
            this.lookUpEdit2.Properties.ValueMember = "ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(167, 22);
            this.lookUpEdit2.TabIndex = 58;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 224);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1242, 262);
            this.gridControl1.TabIndex = 57;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(1002, 168);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(243, 33);
            this.btnIptal.TabIndex = 56;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnFirmaYazdir
            // 
            this.btnFirmaYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaYazdir.Location = new System.Drawing.Point(1002, 117);
            this.btnFirmaYazdir.Name = "btnFirmaYazdir";
            this.btnFirmaYazdir.Size = new System.Drawing.Size(243, 33);
            this.btnFirmaYazdir.TabIndex = 55;
            this.btnFirmaYazdir.Text = "Firmaları Yazdır";
            this.btnFirmaYazdir.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(1002, 66);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(243, 33);
            this.btnAra.TabIndex = 54;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnYeniFirmaListesi
            // 
            this.btnYeniFirmaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniFirmaListesi.Location = new System.Drawing.Point(1002, 15);
            this.btnYeniFirmaListesi.Name = "btnYeniFirmaListesi";
            this.btnYeniFirmaListesi.Size = new System.Drawing.Size(243, 33);
            this.btnYeniFirmaListesi.TabIndex = 53;
            this.btnYeniFirmaListesi.Text = "Yeni Sayfada Firma Listesi";
            this.btnYeniFirmaListesi.UseVisualStyleBackColor = true;
            this.btnYeniFirmaListesi.Click += new System.EventHandler(this.btnYeniFirmaListesi_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(777, 168);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(191, 33);
            this.btnGuncelle.TabIndex = 52;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(777, 117);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(191, 33);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(777, 66);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(191, 33);
            this.btnEkle.TabIndex = 50;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(777, 15);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(191, 33);
            this.btnListele.TabIndex = 49;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(357, 176);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 16);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(75, 176);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(13, 16);
            this.labelControl10.TabIndex = 47;
            this.labelControl10.Text = "İl:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(298, 140);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 16);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Firma Telefon:";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(582, 99);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(167, 22);
            this.txtVergiDairesi.TabIndex = 45;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(290, 102);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 16);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Yetkili Telefon:";
            // 
            // txtYetkiliTelefon
            // 
            this.txtYetkiliTelefon.Location = new System.Drawing.Point(396, 99);
            this.txtYetkiliTelefon.Name = "txtYetkiliTelefon";
            this.txtYetkiliTelefon.Size = new System.Drawing.Size(167, 22);
            this.txtYetkiliTelefon.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(323, 61);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 16);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Yetkili Tc:";
            // 
            // txtYetkiliTc
            // 
            this.txtYetkiliTc.Location = new System.Drawing.Point(396, 58);
            this.txtYetkiliTc.Name = "txtYetkiliTc";
            this.txtYetkiliTc.Size = new System.Drawing.Size(167, 22);
            this.txtYetkiliTc.TabIndex = 41;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(297, 23);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 16);
            this.labelControl8.TabIndex = 40;
            this.labelControl8.Text = "Yetkili Ünvan:";
            // 
            // txtYetkiliUnvan
            // 
            this.txtYetkiliUnvan.Location = new System.Drawing.Point(396, 20);
            this.txtYetkiliUnvan.Name = "txtYetkiliUnvan";
            this.txtYetkiliUnvan.Size = new System.Drawing.Size(167, 22);
            this.txtYetkiliUnvan.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 16);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Yetkili:";
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.Location = new System.Drawing.Point(101, 137);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(167, 22);
            this.txtYetkiliAd.TabIndex = 37;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(40, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 16);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Sektör:";
            // 
            // txtSektor
            // 
            this.txtSektor.Location = new System.Drawing.Point(101, 99);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(167, 22);
            this.txtSektor.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Firma Adı:";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(101, 58);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(167, 22);
            this.txtFirmaAdi.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Firma ID:";
            // 
            // txtFirmaId
            // 
            this.txtFirmaId.Location = new System.Drawing.Point(101, 20);
            this.txtFirmaId.Name = "txtFirmaId";
            this.txtFirmaId.Properties.ReadOnly = true;
            this.txtFirmaId.Size = new System.Drawing.Size(167, 22);
            this.txtFirmaId.TabIndex = 31;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(582, 74);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(82, 16);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Vergi Dairesi";
            // 
            // txtFirmaTelefon
            // 
            this.txtFirmaTelefon.Location = new System.Drawing.Point(396, 134);
            this.txtFirmaTelefon.Name = "txtFirmaTelefon";
            this.txtFirmaTelefon.Size = new System.Drawing.Size(167, 22);
            this.txtFirmaTelefon.TabIndex = 60;
            // 
            // FrmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 500);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtFirmaTelefon);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnFirmaYazdir);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnYeniFirmaListesi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtYetkiliTelefon);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtYetkiliTc);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtYetkiliUnvan);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtYetkiliAd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSektor);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFirmaId);
            this.MaximumSize = new System.Drawing.Size(1284, 547);
            this.MinimumSize = new System.Drawing.Size(1284, 547);
            this.Name = "FrmFirmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.FrmFirmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkiliAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaTelefon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnFirmaYazdir;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYeniFirmaListesi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtYetkiliTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtYetkiliTc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtYetkiliUnvan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtYetkiliAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSektor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFirmaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFirmaId;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtFirmaTelefon;
    }
}