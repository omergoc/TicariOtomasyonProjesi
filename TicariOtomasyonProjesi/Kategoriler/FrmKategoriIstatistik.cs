using System;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;
using System.Linq;

namespace TicariOtomasyonProjesi.Kategoriler
{
    public partial class FrmKategoriIstatistik : Form
    {
        public FrmKategoriIstatistik()
        {
            InitializeComponent();
        }

        private void FrmKategoriIstatistik_Load(object sender, EventArgs e)
        {
            DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

            gridControl1.DataSource = (from x in db.TBLKATEGORIs
                                       select new
                                       {
                                           x.ID,
                                           x.KATEGORIAD
                                       }).ToList();

            lblKategoriSayisi.Text = db.TBLKATEGORIs.Count().ToString();
            lblSonEklenenKategori.Text = db.TBLKATEGORIs.OrderByDescending(x => x.ID).Select(y => y.KATEGORIAD).FirstOrDefault().ToString();
            var deger = db.TBLURUNs.GroupBy(x => x.KATEGORI).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblEnFazlaUrunSahipKategori.Text = db.TBLKATEGORIs.Where(x => x.ID == deger).Select(y => y.KATEGORIAD).FirstOrDefault().ToString();

            var degerler = db.TBLURUNs.ToList();
            foreach (var item in degerler)
            {
                chartControl1.Series["ürün-stok"].Points.AddPoint(item.URUNAD, short.Parse(item.STOK.ToString()));
            }
        }
    }
}
