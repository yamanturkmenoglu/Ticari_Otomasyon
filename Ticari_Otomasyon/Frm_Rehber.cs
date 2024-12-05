using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Ticari_Otomasyon
{
    public partial class Frm_Rehber : Form
    {
        public Frm_Rehber()
        {
            InitializeComponent();
        }

        SqlConnectionClass bgl = new SqlConnectionClass();

        void musteri_Rehber_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AD,SOYAD,TELEFON,TELEFON2,MAIL FROM TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void firma_Rehber_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        private void Frm_Rehber_Load(object sender, EventArgs e)
        {
            musteri_Rehber_Listele();
            firma_Rehber_Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_mail Frm = new Frm_mail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Frm.Mail = dr["MAIL"].ToString();
            }
            Frm.Show();
        }
    }
}
