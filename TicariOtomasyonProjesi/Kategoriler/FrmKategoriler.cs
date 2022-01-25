using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void KategoriListele()
        {
            var kategoriler = from x in db.TBLKATEGORIs
                              select new
                              {
                                  x.ID,
                                  x.KATEGORIAD
                              };
            gridControl1.DataSource = kategoriler.ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.KATEGORIAD = txtAd.Text;
                db.TBLKATEGORIs.Add(t);
                db.SaveChanges();
                KategoriListele();
                XtraMessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Eklemek İstediğiniz Kategori Adını Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtId.Text !="")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLKATEGORIs.Find(id);
                db.TBLKATEGORIs.Remove(x);
                db.SaveChanges();
                KategoriListele();
                XtraMessageBox.Show("Kategori Başarılı Bir Şekilde Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLKATEGORIs.Find(id);
                x.KATEGORIAD = txtAd.Text;
                db.SaveChanges();
                KategoriListele();
                XtraMessageBox.Show("Verileriniz Başarılı Bir Şekilde Güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            string kategoriId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtId.Text = kategoriId;

            string kategoriAd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KATEGORIAD").ToString();
            txtAd.Text = kategoriAd;
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
        }
    }
}
