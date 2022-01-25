using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Cariler
{
    public partial class FrmCariIstatistikler : Form
    {
        public FrmCariIstatistikler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariIstatistikler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARIs.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            var degerler = db.TBLCARIs.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            foreach (var x in degerler)
            {
                chartControl1.Series["iller"].Points.AddPoint(x.IL, short.Parse(x.TOPLAM.ToString()));
            }
        }
    }
}
