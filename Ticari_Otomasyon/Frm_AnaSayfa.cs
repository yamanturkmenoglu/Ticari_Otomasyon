using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_AnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        Frm_Urunler Frm;
        private void Btn_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
                Frm = new Frm_Urunler();
                Frm.MdiParent = this;
                Frm.Show();
           
        }
        Frm_Musteriler Frm2;
        private void Btn_Musterler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm2 = new Frm_Musteriler();
            Frm2.MdiParent = this;
            Frm2.Show();
        }
        Frm_Firmalar Frm3;
        private void Btn_Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm3 = new Frm_Firmalar();
            Frm3.MdiParent = this;
            Frm3.Show();
        }
        Frm_Personeller Frm4;
        private void Btn_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm4 = new Frm_Personeller();
            Frm4.MdiParent = this;
            Frm4.Show();
        }
        Frm_Rehber Frm5;
        private void Btn_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm5 = new Frm_Rehber();
            Frm5.MdiParent = this;
            Frm5.Show();
        }
    }
   
}
