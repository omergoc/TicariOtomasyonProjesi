using System;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;
namespace TicariOtomasyonProjesi.Urunler
{
    public partial class FrmUrunIstatistikleri : Form
    {
        public FrmUrunIstatistikleri()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmUrunIstatistikleri_Load(object sender, EventArgs e)
        {
            lblUrunSayisi.Text = db.TBLURUNs.Count().ToString();
            lblKategoriSayisi.Text = db.TBLKATEGORIs.Count().ToString();
            lblMusteriSayisi.Text = db.TBLCARIs.Count().ToString();
            lblPersonelSayisi.Text = db.TBLPERSONELs.Count().ToString();

            lblToplamStok.Text = db.TBLURUNs.Sum(x => x.STOK).ToString();
            lblBeyazEsya.Text = db.TBLURUNs.Where(x => x.KATEGORI == 1).Sum(y => y.STOK).ToString();
            lblKucukEvAleti.Text = db.TBLURUNs.Where(x => x.KATEGORI == 4).Sum(y => y.STOK).ToString();
            lblKritikSeviye.Text = db.TBLURUNs.Count(x => x.KRITIKSEVIYE == true).ToString();

            lblEnYuksekFiyat.Text = db.TBLURUNs.OrderByDescending(x => x.SATISFIYAT).Select(y => y.URUNAD).FirstOrDefault().ToString();
            lblEnDusukFiyat.Text = db.TBLURUNs.OrderBy(x => x.SATISFIYAT).Select(y => y.URUNAD).FirstOrDefault().ToString();
            lblEnYuksekStok.Text = db.TBLURUNs.OrderByDescending(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault().ToString();
            lblEnDusukStok.Text = db.TBLURUNs.OrderBy(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault().ToString();
        }
    }
}
