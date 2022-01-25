using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Personeller
{
    public partial class FrmYeniPersonelKarti : Form
    {
        public FrmYeniPersonelKarti()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" || txtPersonelSoyad.Text != "" || lookUpEdit1.Text != "")
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.PERSONELAD = txtPersonelAd.Text;
                t.PERSONELSOYAD = txtPersonelSoyad.Text;
                t.PERSONELDEPARTMAN = int.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLPERSONELs.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Personel Ekleme İşlem Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Boş alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
