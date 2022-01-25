using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Departmanlar
{
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.DEPARTMANAD = txtAd.Text;
                db.TBLDEPARTMen.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Departman Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Eklemek İstediğiniz Departman Adını Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
