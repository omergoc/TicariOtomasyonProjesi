using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Cariler
{
    public partial class FrmCariHareketler : Form
    {
        public FrmCariHareketler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariHareketler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARIHAREKETs
                                       select new
                                       {

                                           x.SATISID,
                                           x.TBLURUN.URUNAD,
                                           Cari = x.TBLCARI.AD +" "+ x.TBLCARI.SOYAD,
                                           Personel = x.TBLPERSONEL.PERSONELAD+" " + x.TBLPERSONEL.PERSONELSOYAD,
                                           x.TARIH,
                                           x.BIRIMFIYAT,
                                           x.ADET,
                                           x.TOPLAM
                                       }).ToList();

            lblToplamSatis.Text = db.TBLCARIHAREKETs.Count().ToString();

            DateTime bugun = new DateTime();
            bugun = DateTime.Today;
            lblBugunkuSatis.Text = db.TBLCARIHAREKETs.Where(x => x.TARIH == bugun).Count().ToString();

            var deger = db.TBLCARIHAREKETs.GroupBy(x => x.URUN).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            lblEnFazlaSatilanUrun.Text = db.TBLURUNs.Where(x => x.URUNID == deger).Select(y => y.URUNAD).FirstOrDefault().ToString();

            var deger2 = db.TBLCARIHAREKETs.GroupBy(x => x.CARI).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblEnFazlaAlimYapanCari.Text = db.TBLCARIs.Where(x => x.CARIID == deger2).Select(y => y.AD + " " + y.SOYAD).FirstOrDefault().ToString();
        }
    }
}
