using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Departmanlar
{
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void DepartmanListele()
        {
            var departmanlar = from x in db.TBLDEPARTMen
                              select new
                              {
                                  x.ID,
                                  x.DEPARTMANAD
                              };
            gridControl1.DataSource = departmanlar.ToList();
        }
        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {
            DepartmanListele();
            var degerler = db.TBLPERSONELs.OrderBy(x => x.TBLDEPARTMAN.DEPARTMANAD).GroupBy(y => y.TBLDEPARTMAN.DEPARTMANAD).
                Select(z => new { Ad = z.Key, Toplam = z.Count() }).ToList();

            foreach (var item in degerler)
            {
                chartControl1.Series["Departmanlar"].Points.AddPoint(item.Ad, short.Parse(item.Toplam.ToString()));
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            string departmanId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            txtId.Text = departmanId;

            string departmanAd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DEPARTMANAD").ToString();
            txtAd.Text = departmanAd;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DepartmanListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.DEPARTMANAD = txtAd.Text;
                db.TBLDEPARTMen.Add(t);
                db.SaveChanges();
                DepartmanListele();
                XtraMessageBox.Show("Departman Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Eklemek İstediğiniz Departman Adını Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLDEPARTMen.Find(id);
                x.DEPARTMANAD = txtAd.Text;
                db.SaveChanges();
                DepartmanListele();
                XtraMessageBox.Show("Verileriniz Başarılı Bir Şekilde Güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var x = db.TBLDEPARTMen.Find(id);
                db.TBLDEPARTMen.Remove(x);
                db.SaveChanges();
                DepartmanListele();
                XtraMessageBox.Show("Departman Başarılı Bir Şekilde Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
