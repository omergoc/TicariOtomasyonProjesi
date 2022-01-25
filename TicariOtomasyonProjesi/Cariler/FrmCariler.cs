using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Cariler
{
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void CariListele()
        {
            gridControl1.DataSource = (from x in db.TBLCARIs
                                       select new
                                       {
                                           x.CARIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                           x.VERGIDAIRESI
                                       }).ToList();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            CariListele();
        } 

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtAdi.Text;
            t.SOYAD = txtSoyadi.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            t.TELEFON = txtTelefon.Text;
            t.ADRES = txtAdresi.Text;
            t.MAIL = txtMail.Text;
            t.TC = txtTc.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            db.TBLCARIs.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Cari Sisteme Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                 }).Where(z=> z.SEHIR == secilen).ToList();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            CariListele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLERs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtCariId.Text = gridView1.GetFocusedRowCellValue("CARIID").ToString();
            txtAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyadi.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            txtTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtAdresi.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();

            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString()
;        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtCariId.Text !="")
            {
                int id = int.Parse(txtCariId.Text);
                var x = db.TBLCARIs.Find(id);
                db.TBLCARIs.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Cari Başarılı Bir Şekilde Silindi","Silme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtCariId.Text !="")
            {
                int id = int.Parse(txtCariId.Text);
                var x = db.TBLCARIs.Find(id);
                x.AD = txtAdi.Text;
                x.SOYAD = txtSoyadi.Text;
                x.IL = lookUpEdit1.Text;
                x.ILCE = lookUpEdit2.Text;
                x.TELEFON = txtTelefon.Text;
                x.ADRES = txtAdresi.Text;
                x.MAIL = txtMail.Text;
                x.TC = txtTc.Text;
                x.VERGIDAIRESI = txtVergiDairesi.Text;
                db.SaveChanges();

                XtraMessageBox.Show("Cari Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARIs
                                       select new
                                       {
                                           x.CARIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                           x.VERGIDAIRESI
                                       }).Where(x=>x.AD == txtAdi.Text || x.IL == lookUpEdit1.Text).ToList();
        }

        private void btnYeniCariListesi_Click(object sender, EventArgs e)
        {
            FrmCariListesi frm = new FrmCariListesi();
            frm.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
