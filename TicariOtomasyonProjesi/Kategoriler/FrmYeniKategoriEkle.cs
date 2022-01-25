using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Kategoriler
{
    public partial class FrmYeniKategoriEkle : Form
    {
        public FrmYeniKategoriEkle()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.KATEGORIAD = txtKategoriAd.Text;
                db.TBLKATEGORIs.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Kategori Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata Lütfen Kategori Adını Boş Bırakmayınız veya 20 Karakterden Uzun Kategori Adı Girişi Yapmayınız.");
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
