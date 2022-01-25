using System;
using System.Windows.Forms;

namespace TicariOtomasyonProjesi.Araclar
{
    public partial class FrmKurlar : Form
    {
        public FrmKurlar()
        {
            InitializeComponent();
        }

        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }
    }
}
