using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Firmalar
{
    public partial class FrmYeniFirmaKart : Form
    {
        public FrmYeniFirmaKart()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLİLCELER
                                                 select new
                                                 {
                                                     y.ID,
                                                     y.ILCE,
                                                     y.SEHIR,
                                                 }).Where(z => z.SEHIR == secilen).ToList();
        }

        private void FrmYeniFirmaKart_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLERs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();
        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            TBLFIRMA t = new TBLFIRMA();
            t.AD = txtFirmaAd.Text;
            t.SEKTOR = txtSektor.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            t.YETKILI = txtYetkiliAdi.Text;
            t.YETKILISTATU = txtYetkiliUnvan.Text;
            t.YETKILITC = txtYetkiliTc.Text;
            t.YETKILITELEFON = txtYetkiliTelefon.Text;
            t.FIRMATELEFON = txtFirmaTelefon.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            db.TBLFIRMAs.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Firma Sisteme Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCariIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

