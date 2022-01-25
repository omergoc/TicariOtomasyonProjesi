using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Anasayfa
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            var urunStok = from x in db.TBLURUNs
                           select new
                           {
                               x.URUNAD,
                               x.STOK
                           };
            gridUrunStok.DataSource = urunStok.ToList();

            var sonSatislar = from x in db.TBLCARIHAREKETs
                              select new
                              {
                                  x.TBLURUN.URUNAD,
                                  x.ADET,
                                  x.TOPLAM,
                                  x.SATISID
                              };
            gridSon5Satis.DataSource = sonSatislar.OrderByDescending(x => x.SATISID).Take(5).ToList();


            var cariler = from x in db.TBLCARIs
                          select new
                          {
                              x.CARIID,
                              x.AD
                          };
            gridCariListesi.DataSource = cariler.ToList();

            var firmalar = from x in db.TBLFIRMAs
                           select new
                           {
                               x.FIRMAID,
                               x.AD,
                               x.SEKTOR
                           };
            gridFirmaListesi.DataSource = firmalar.ToList();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }
    }
}
