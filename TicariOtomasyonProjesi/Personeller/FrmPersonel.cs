using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Personeller
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void PersonelListele()
        {
            var personeller = from x in db.TBLPERSONELs
                              select new
                              {
                                  x.PERSONELID,
                                  x.PERSONELAD,
                                  x.PERSONELSOYAD,
                                  x.TBLDEPARTMAN.DEPARTMANAD
                              };
            gridControl1.DataSource = personeller.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            PersonelListele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMen
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.DEPARTMANAD
                                                 }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text != "")
            {
                int id = int.Parse(txtPersonelID.Text);
                var x = db.TBLPERSONELs.Find(id);
                db.TBLPERSONELs.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Personel Başarılı Bir Şekilde Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text != "")
            {
                int id = int.Parse(txtPersonelID.Text);
                var x = db.TBLPERSONELs.Find(id);
                x.PERSONELAD = txtPersonelAd.Text;
                x.PERSONELSOYAD = txtPersonelAd.Text;
                x.PERSONELDEPARTMAN = int.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();

                XtraMessageBox.Show("Verileriniz Başarılı Bir Şekilde Güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
                PersonelListele();
                XtraMessageBox.Show("Personel Ekleme İşlem Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Boş alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtPersonelID.Text = gridView1.GetFocusedRowCellValue("PERSONELID").ToString();
            txtPersonelAd.Text = gridView1.GetFocusedRowCellValue("PERSONELAD").ToString();
            txtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("PERSONELSOYAD").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMANAD").ToString();
        }
    }
}
