using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void UrunListele()
        {
            gridControl1.DataSource = (from x in db.TBLURUNs
                                       select new
                                       {
                                           x.URUNID,
                                           x.URUNAD,
                                           x.STOK,
                                           x.ALISFIYAT,
                                           x.SATISFIYAT,
                                           x.TBLKATEGORI.KATEGORIAD,
                                       }).ToList();
        }
        private void Temizle()
        {
            txtId.Text = "";
            txtUrunAdi.Text = "";
            txtAlisFiyati.Text = "";
            txtSatisFiyati.Text = "";
            txtStok.Text = "";
            txtStok.Text = "";
            lookUpEdit1.Text = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORIs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.KATEGORIAD
                                                 }).ToList();
            UrunListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != "" || txtAlisFiyati.Text != "" || txtSatisFiyati.Text != "" ||txtStok.Text !="" || lookUpEdit1.Text != "")
            {
                TBLURUN t = new TBLURUN();
                t.URUNAD = txtUrunAdi.Text;
                t.STOK = short.Parse(txtStok.Text);
                t.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
                t.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
                t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUNs.Add(t);
                db.SaveChanges();
                UrunListele();
                XtraMessageBox.Show("Ürün Ekleme İşlem Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Boş alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLURUNs.Find(id);
                db.TBLURUNs.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün Başarılı Bir Şekilde Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLURUNs.Find(id);
                x.URUNAD = txtUrunAdi.Text;
                x.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
                x.SATISFIYAT = short.Parse(txtStok.Text);
                x.STOK = short.Parse(txtStok.Text);
                x.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();

                XtraMessageBox.Show("Verilerinizi Başarılı Bir Şekilde Güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("URUNID").ToString();
            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("URUNAD").ToString();
            txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyati.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORIAD").ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
