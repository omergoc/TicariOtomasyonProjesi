using System;
using System.Windows.Forms;

namespace TicariOtomasyonProjesi.Doviz
{
    public partial class FrmDovizHesapla : Form
    {
        public FrmDovizHesapla()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar = 0;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtMiktar.Text = tutar.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
