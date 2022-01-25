using System.Windows.Forms;
using TicariOtomasyonProjesi.Anasayfa;
using TicariOtomasyonProjesi.Araclar;
using TicariOtomasyonProjesi.Cariler;
using TicariOtomasyonProjesi.Departmanlar;
using TicariOtomasyonProjesi.Doviz;
using TicariOtomasyonProjesi.Firmalar;
using TicariOtomasyonProjesi.Kasa;
using TicariOtomasyonProjesi.Kategoriler;
using TicariOtomasyonProjesi.Personeller;
using TicariOtomasyonProjesi.Urunler;

namespace TicariOtomasyonProjesi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            FrmAnasayfa frm = new FrmAnasayfa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategoriEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniKategoriEkle frm = new FrmYeniKategoriEkle();
            frm.Show();
        }

        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunIstatistikleri frm = new FrmUrunIstatistikleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategoriIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriIstatistik frm = new FrmKategoriIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYenıUrunEkle frm = new FrmYenıUrunEkle();
            frm.Show();
        }

        private void btnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariler frm = new FrmCariler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniCariKart frm = new FrmYeniCariKart();
            frm.Show();
        }

        private void btnFirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmalar frm = new FrmFirmalar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFirmaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniFirmaKart frm = new FrmYeniFirmaKart();
            frm.Show();
        }

        private void btnCariIstatistikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariIstatistikler frm = new FrmCariIstatistikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFirmaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmaIstatistikler frm = new FrmFirmaIstatistikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCariHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariHareketler frm = new FrmCariHareketler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFirmaHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmaHareketler frm = new FrmFirmaHareketler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniPersonelKarti frm = new FrmYeniPersonelKarti();
            frm.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartmanlar frm = new FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniDepartman frm = new FrmYeniDepartman();
            frm.Show();
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaListesi frm = new FrmKasaListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaGider frm = new FrmKasaGider();
            frm.Show();
        }

        private void btnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKurlar frm = new FrmKurlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDovizDonusumleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizHesapla frm = new FrmDovizHesapla();
            frm.Show();
        }

        private void btnAnasSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnasayfa frm = new FrmAnasayfa();
            if(frm.IsDisposed || frm == null)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
