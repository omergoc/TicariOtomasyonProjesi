using System;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Kasa
{
    public partial class FrmKasaListesi : Form
    {
        public FrmKasaListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            var kasaListesi = db.TBLKASAs.ToList();
            gridControl1.DataSource = kasaListesi;
        }
    }
}
