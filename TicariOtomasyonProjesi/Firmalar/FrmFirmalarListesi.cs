using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Firmalar
{
    public partial class FrmFirmalarListesi : Form
    {
        public FrmFirmalarListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmFirmalarListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFIRMAs
                                       select new
                                       {
                                           x.FIRMAID,
                                           x.AD,
                                           x.SEKTOR,
                                           x.IL,
                                           x.ILCE,
                                           x.YETKILI,
                                           x.YETKILISTATU,
                                           x.YETKILITC,
                                           x.YETKILITELEFON,
                                           x.FIRMATELEFON,
                                           x.VERGIDAIRESI
                                       }).ToList();
        }
    }
}
