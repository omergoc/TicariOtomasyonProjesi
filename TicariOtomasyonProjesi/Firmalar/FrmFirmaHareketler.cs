using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Firmalar
{
    public partial class FrmFirmaHareketler : Form
    {
        public FrmFirmaHareketler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmFirmaHareketler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFIRMAHAREKETs
                                       select new
                                       {

                                           x.SATISID,
                                           x.TBLURUN.URUNAD,
                                           Firma = x.TBLFIRMA.AD,
                                           Personel = x.TBLPERSONEL.PERSONELAD + " " + x.TBLPERSONEL.PERSONELSOYAD,
                                           x.TARIH,
                                           x.BIRIMFIYAT,
                                           x.ADET,
                                           x.TOPLAM
                                       }).ToList();

            lblToplamSatis.Text = db.TBLFIRMAHAREKETs.Count().ToString();

            DateTime bugun = new DateTime();
            bugun = DateTime.Today;
            lblBugunkuSatis.Text = db.TBLFIRMAHAREKETs.Where(x => x.TARIH == bugun).Count().ToString();

            var deger = db.TBLFIRMAHAREKETs.GroupBy(x => x.URUN).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            lblEnFazlaSatilanUrun.Text = db.TBLURUNs.Where(x => x.URUNID == deger).Select(y => y.URUNAD).FirstOrDefault().ToString();

            var deger2 = db.TBLFIRMAHAREKETs.GroupBy(x => x.FIRMA).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblEnFazlaAlimYapanFirma.Text = db.TBLFIRMAs.Where(x => x.FIRMAID == deger2).Select(y => y.AD).FirstOrDefault().ToString();
        }
    }
}
