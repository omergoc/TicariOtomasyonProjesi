using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyonProjesi.Entity;

namespace TicariOtomasyonProjesi.Kasa
{
    public partial class FrmKasaGider : Form
    {
        public FrmKasaGider()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            TBLGIDERLER t = new TBLGIDERLER();
            t.TUTAR = decimal.Parse(txtTutar.Text);
            t.ACIKLAMA = txtAciklama.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            db.TBLGIDERLERs.Add(t);
            db.SaveChanges();

            TBLKASA t2 = new TBLKASA();
            t2.TUTAR = decimal.Parse(txtTutar.Text);
            t2.ACIKLAMA = txtAciklama.Text;
            t2.TARIH = DateTime.Parse(txtTarih.Text);
            t2.TUR = "Çıkış";
            db.TBLKASAs.Add(t2);
            db.SaveChanges();

            XtraMessageBox.Show("Gider Sisteme Başarılı Bir Şekilde Eklenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
