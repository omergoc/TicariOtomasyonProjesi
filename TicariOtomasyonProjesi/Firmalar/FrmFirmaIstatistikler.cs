using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Firmalar
{
    public partial class FrmFirmaIstatistikler : Form
    {
        public FrmFirmaIstatistikler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmFirmaIstatistikler_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLFIRMAs.OrderBy(x => x.IL).GroupBy(y => y.IL).
            Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            var degerler = db.TBLFIRMAs.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new { IL = z.Key, TOPLAM = z.Count() }).ToList();

            foreach (var x in degerler)
            {
                chartControl1.Series["iller"].Points.AddPoint(x.IL, short.Parse(x.TOPLAM.ToString()));
            }
        }
    }
}
