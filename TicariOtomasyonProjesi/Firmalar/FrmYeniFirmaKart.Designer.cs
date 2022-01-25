
namespace TicariOtomasyonProjesi.Firmalar
{
    partial class FrmYeniFirmaKart
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
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCariIptal = new System.Windows.Forms.Button();
            this.btnCariEkle = new System.Windows.Forms.Button();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYetkiliTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYetkiliTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYetkiliUnvan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSektor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmaTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(215, 158);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "ILCE";
            this.lookUpEdit2.Properties.ValueMember = "ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(221, 22);
            this.lookUpEdit2.TabIndex = 43;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(215, 118);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "SEHIR";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(221, 22);
            this.lookUpEdit1.TabIndex = 42;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // btnCariIptal
            // 
            this.btnCariIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariIptal.Location = new System.Drawing.Point(209, 481);
            this.btnCariIptal.Name = "btnCariIptal";
            this.btnCariIptal.Size = new System.Drawing.Size(223, 31);
            this.btnCariIptal.TabIndex = 41;
            this.btnCariIptal.Text = "İptal";
            this.btnCariIptal.UseVisualStyleBackColor = true;
            this.btnCariIptal.Click += new System.EventHandler(this.btnCariIptal_Click);
            // 
            // btnCariEkle
            // 
            this.btnCariEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariEkle.Location = new System.Drawing.Point(209, 444);
            this.btnCariEkle.Name = "btnCariEkle";
            this.btnCariEkle.Size = new System.Drawing.Size(223, 31);
            this.btnCariEkle.TabIndex = 40;
            this.btnCariEkle.Text = "Ekle";
            this.btnCariEkle.UseVisualStyleBackColor = true;
            this.btnCariEkle.Click += new System.EventHandler(this.btnCariEkle_Click);
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(215, 394);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(221, 22);
            this.txtVergiDairesi.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(78, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Vergi Dairesi:";
            // 
            // txtYetkiliTelefon
            // 
            this.txtYetkiliTelefon.Location = new System.Drawing.Point(214, 356);
            this.txtYetkiliTelefon.Name = "txtYetkiliTelefon";
            this.txtYetkiliTelefon.Size = new System.Drawing.Size(221, 22);
            this.txtYetkiliTelefon.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Yetkili Telefon:";
            // 
            // txtYetkiliTc
            // 
            this.txtYetkiliTc.Location = new System.Drawing.Point(215, 313);
            this.txtYetkiliTc.Name = "txtYetkiliTc";
            this.txtYetkiliTc.Size = new System.Drawing.Size(221, 22);
            this.txtYetkiliTc.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(110, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Yetkili Tc:";
            // 
            // txtYetkiliUnvan
            // 
            this.txtYetkiliUnvan.Location = new System.Drawing.Point(215, 274);
            this.txtYetkiliUnvan.Name = "txtYetkiliUnvan";
            this.txtYetkiliUnvan.Size = new System.Drawing.Size(221, 22);
            this.txtYetkiliUnvan.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(79, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Yetkili Ünvan:";
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.Location = new System.Drawing.Point(215, 238);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(221, 22);
            this.txtYetkiliAdi.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(105, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Yetkili Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(159, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(179, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "İl:";
            // 
            // txtSektor
            // 
            this.txtSektor.Location = new System.Drawing.Point(215, 75);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(221, 22);
            this.txtSektor.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sektör:";
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(215, 36);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(221, 22);
            this.txtFirmaAd.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Firma Ad:";
            // 
            // txtFirmaTelefon
            // 
            this.txtFirmaTelefon.Location = new System.Drawing.Point(215, 196);
            this.txtFirmaTelefon.Name = "txtFirmaTelefon";
            this.txtFirmaTelefon.Size = new System.Drawing.Size(221, 22);
            this.txtFirmaTelefon.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(73, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Firma Telefon:";
            // 
            // FrmYeniFirmaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 558);
            this.Controls.Add(this.txtFirmaTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.btnCariIptal);
            this.Controls.Add(this.btnCariEkle);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYetkiliTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYetkiliTc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYetkiliUnvan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYetkiliAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSektor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(566, 605);
            this.MinimumSize = new System.Drawing.Size(566, 605);
            this.Name = "FrmYeniFirmaKart";
            this.Text = "Yeni Firma Ekle";
            this.Load += new System.EventHandler(this.FrmYeniFirmaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Button btnCariIptal;
        private System.Windows.Forms.Button btnCariEkle;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYetkiliTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYetkiliTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYetkiliUnvan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYetkiliAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSektor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmaTelefon;
        private System.Windows.Forms.Label label6;
    }
}