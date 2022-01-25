using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Firmalar
{
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FirmaListele()
        {
            gridControl1.DataSource = (from x in db.TBLFIRMAs
                                       select new
                                       {
                                           x.FIRMAID,
                                           x.AD,
                                           x.SEKTOR,
                                           x.IL,
                                           x.ILCE,
                                           x.YETKILI,
                                           x.YETKILISTATU,
                                           x.YETKILITC,
                                           x.YETKILITELEFON,
                                           x.FIRMATELEFON,
                                           x.VERGIDAIRESI
                                       }).ToList();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLERs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.SEHIR
                                                 }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FirmaListele();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtFirmaId.Text != "")
            {
                int id = int.Parse(txtFirmaId.Text);
                var x = db.TBLFIRMAs.Find(id);
                db.TBLFIRMAs.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Firma Başarılı Bir Şekilde Silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Silmek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLFIRMA t = new TBLFIRMA();
            t.AD = txtFirmaAdi.Text;
            t.SEKTOR = txtSektor.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            t.YETKILI = txtYetkiliAd.Text;
            t.YETKILISTATU = txtYetkiliUnvan.Text;
            t.YETKILITC = txtYetkiliTc.Text;
            t.YETKILITELEFON = txtYetkiliTelefon.Text;
            t.FIRMATELEFON = txtFirmaTelefon.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            db.TBLFIRMAs.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Firma Sisteme Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFirmaId.Text != "")
            {
                int id = int.Parse(txtFirmaId.Text);
                var x = db.TBLFIRMAs.Find(id);
                x.AD = txtFirmaAdi.Text;
                x.SEKTOR = txtSektor.Text;
                x.IL = lookUpEdit1.Text;
                x.ILCE = lookUpEdit2.Text;
                x.FIRMATELEFON = txtFirmaTelefon.Text;
                x.YETKILITELEFON = txtYetkiliTelefon.Text;
                x.YETKILISTATU = txtYetkiliUnvan.Text;
                x.YETKILITC = txtYetkiliTc.Text;
                x.YETKILI = txtYetkiliAd.Text;
                x.VERGIDAIRESI = txtVergiDairesi.Text;
                db.SaveChanges();

                XtraMessageBox.Show("Firma Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Verileri Listeledikten Sonra Bir Satıra Tıklayıp Güncellemek İstediğiniz Kaydı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtFirmaId.Text = gridView1.GetFocusedRowCellValue("FIRMAID").ToString();
            txtFirmaAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSektor.Text = gridView1.GetFocusedRowCellValue("SEKTOR").ToString();
            txtFirmaTelefon.Text = gridView1.GetFocusedRowCellValue("FIRMATELEFON").ToString();
            txtYetkiliTelefon.Text = gridView1.GetFocusedRowCellValue("YETKILITELEFON").ToString();
            txtYetkiliTc.Text = gridView1.GetFocusedRowCellValue("YETKILITC").ToString();
            txtYetkiliAd.Text = gridView1.GetFocusedRowCellValue("YETKILI").ToString();
            txtYetkiliUnvan.Text = gridView1.GetFocusedRowCellValue("YETKILISTATU").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();

            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
        }

        private void btnYeniFirmaListesi_Click(object sender, EventArgs e)
        {
            FrmFirmalarListesi frm = new FrmFirmalarListesi();
            frm.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFIRMAs
                                       select new
                                       {
                                        x.FIRMAID,
                                        x.AD,
                                        x.SEKTOR,
                                        x.IL,
                                        x.ILCE,
                                        x.YETKILI,
                                        x.YETKILISTATU,
                                        x.YETKILITC,
                                        x.YETKILITELEFON,
                                        x.FIRMATELEFON,
                                        x.VERGIDAIRESI
                                    }).Where(x => x.AD == txtFirmaAdi.Text || x.IL == lookUpEdit1.Text).ToList();
        }
    }
}
