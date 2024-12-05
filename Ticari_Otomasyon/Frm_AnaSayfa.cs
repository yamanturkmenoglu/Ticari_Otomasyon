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

 
        Frm_Urunler Frm;
        private void Btn_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
              if(Frm == null || Frm.IsDisposed)
            {
                Frm = new Frm_Urunler();
                Frm.MdiParent = this;
                Frm.Show();
            }
           
        }
        Frm_Musteriler Frm2;
        private void Btn_Musterler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          if(Frm2 == null || Frm2.IsDisposed)
            {
                Frm2 = new Frm_Musteriler();
                Frm2.MdiParent = this;
                Frm2.Show();
            }
        }
        Frm_Firmalar Frm3;
        private void Btn_Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frm3 == null || Frm3.IsDisposed)
            {
                Frm3 = new Frm_Firmalar();
                Frm3.MdiParent = this;
                Frm3.Show();
            }
        }
        Frm_Personeller Frm4;
        private void Btn_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if(Frm4 == null || Frm4.IsDisposed)
            {
                Frm4 = new Frm_Personeller();
                Frm4.MdiParent = this;
                Frm4.Show();
            }
        }
        Frm_Rehber Frm5;
        private void Btn_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frm5 == null || Frm5.IsDisposed)
            {
                Frm5 = new Frm_Rehber();
                Frm5.MdiParent = this;
                Frm5.Show();
            } 
        }
        Frm_Giderler Frm6;
        private void Btn_Giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frm6 == null || Frm6.IsDisposed)
            {
                Frm6 = new Frm_Giderler();
                Frm6.MdiParent = this;
                Frm6.Show();
            }
        }
    }
   
}
