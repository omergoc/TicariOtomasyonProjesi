using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Cariler
{
    public partial class FrmYeniCariKart : Form
    {
        public FrmYeniCariKart()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmYeniCariKart_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLERs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();

        }

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

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtCariAd.Text;
            t.SOYAD = txtCariSoyad.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            t.TELEFON = txtCariTelefon.Text;
            t.ADRES = txtCariAdres.Text;
            t.MAIL = txtCariMail.Text;
            t.TC = txtCariTc.Text;
            t.VERGIDAIRESI = txtCariVergiDairesi.Text;

            db.TBLCARIs.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Cari Sisteme Başarılı Bir Şekilde Eklendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCariIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
