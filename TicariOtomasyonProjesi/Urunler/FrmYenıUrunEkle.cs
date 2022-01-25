using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Urunler
{
    public partial class FrmYenıUrunEkle : Form
    {
        public FrmYenıUrunEkle()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != "" || txtAlisFiyati.Text != "" || txtSatisFiyati.Text != "" || txtStok.Text != "" || lookUpEdit1.Text != "")
            {
                TBLURUN t = new TBLURUN();
                t.URUNAD = txtUrunAdi.Text;
                t.STOK = short.Parse(txtStok.Text);
                t.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
                t.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
                t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUNs.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün Ekleme İşlem Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Boş alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmYenıUrunEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORIs
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.KATEGORIAD
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
