using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Cariler
{
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARIs
                                       select new
                                       {
                                           x.CARIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                           x.VERGIDAIRESI
                                       }).ToList();
        }
    }
}
