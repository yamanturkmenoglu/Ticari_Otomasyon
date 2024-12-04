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
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
        {
            InitializeComponent();
        }
        SqlConnectionClass bgl = new SqlConnectionClass();

        void sehirler()
        {
            SqlCommand komut = new SqlCommand("SELECT sehir FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                com_IL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void com_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            com_ILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT ilce FROM TBL_ILCELER WHERE sehir = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", com_IL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                com_ILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["ID"].Caption = "FİRMA KODU";
        }
        private void Frm_Firmalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirler();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txt_Id.Text = dr["ID"].ToString();
                Txt_Ad.Text = dr["AD"].ToString();
                Txt_Sektor.Text = dr["SEKTOR"].ToString();
                Txt_Yetkili.Text = dr["YETKILIADSOYAD"].ToString();
                Txt_YGorev.Text = dr["YETKILISTATU"].ToString();
                Msk_TC.Text = dr["YETKILITC"].ToString();
                msk_Telefon1.Text = dr["TELEFON1"].ToString();
                msk_Telefon2.Text = dr["TELEFON2"].ToString();
                msk_Telefon3.Text = dr["TELEFON3"].ToString();
                Txt_Mail.Text = dr["MAIL"].ToString();
                msk_Fax.Text = dr["FAX"].ToString();
                com_IL.Text = dr["IL"].ToString();
                com_ILCE.Text = dr["ILCE"].ToString();
                Txt_VD.Text = dr["VERGIDAIRE"].ToString();
                Rch_Adres.Text = dr["ADRES"].ToString();
                Txt_OzelKod1.Text = dr["OZELKOD1"].ToString();
                Txt_OzelKod2.Text = dr["OZELKOD2"].ToString();
                Txt_OzelKod3.Text = dr["OZELKOD3"].ToString();

            }
        }
        void temizle()
        {
            Txt_Id.Text = "";
            Txt_Ad.Text = "";
            Txt_YGorev.Text = "";
            Txt_Yetkili.Text = "";
            Msk_TC.Text = "";
            Txt_Sektor.Text = "";
            msk_Telefon1.Text = "";
            msk_Telefon2.Text = "";
            msk_Telefon3.Text = "";
            Txt_Mail.Text = "";
            msk_Fax.Text = "";
            com_IL.Text = "";
            com_ILCE.Text = "";
            Txt_VD.Text = "";
            Rch_Adres.Text = "";
            Txt_OzelKod1.Text = "";
            Txt_OzelKod2.Text = "";
            Txt_OzelKod3.Text = "";
        }
        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update TBL_FIRMALAR set AD=@p1, YETKILISTATU=@p2, YETKILIADSOYAD=@p3, YETKILITC=@p4, SEKTOR=@p5, TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, MAIL=@p9, FAX=@p10, IL=@p11, ILCE=@p12, VERGIDAIRE=@p13, ADRES=@p14, OZELKOD1=@p15, OZELKOD2=@p16, OZELKOD3=@p17 where ID=@p18", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                cmd.Parameters.AddWithValue("@p2", Txt_YGorev.Text);
                cmd.Parameters.AddWithValue("@p3", Txt_Yetkili.Text);
                cmd.Parameters.AddWithValue("@p4", Msk_TC.Text);
                cmd.Parameters.AddWithValue("@p5", Txt_Sektor.Text);
                cmd.Parameters.AddWithValue("@p6", msk_Telefon1.Text);
                cmd.Parameters.AddWithValue("@p7", msk_Telefon2.Text);
                cmd.Parameters.AddWithValue("@p8", msk_Telefon3.Text);
                cmd.Parameters.AddWithValue("@p9", Txt_Mail.Text);
                cmd.Parameters.AddWithValue("@p10", msk_Fax.Text);
                cmd.Parameters.AddWithValue("@p11", com_IL.Text);
                cmd.Parameters.AddWithValue("@p12", com_ILCE.Text);
                cmd.Parameters.AddWithValue("@p13", Txt_VD.Text);
                cmd.Parameters.AddWithValue("@p14", Rch_Adres.Text);
                cmd.Parameters.AddWithValue("@p15", Txt_OzelKod1.Text);
                cmd.Parameters.AddWithValue("@p16", Txt_OzelKod2.Text);
                cmd.Parameters.AddWithValue("@p17", Txt_OzelKod3.Text);
                cmd.Parameters.AddWithValue("@p18", Txt_Id.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();


                XtraMessageBox.Show("Firmayı başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_FIRMALAR" +
               "( [AD], [YETKILISTATU], [YETKILIADSOYAD], [YETKILITC], [SEKTOR], [TELEFON1], [TELEFON2], [TELEFON3], [MAIL], [FAX], [IL], [ILCE], [VERGIDAIRE], [ADRES], [OZELKOD1], [OZELKOD2], [OZELKOD3]) " +
               "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                komut.Parameters.AddWithValue("@p2", Txt_YGorev.Text);
                komut.Parameters.AddWithValue("@p3", Txt_Yetkili.Text);
                komut.Parameters.AddWithValue("@p4", Msk_TC.Text);
                komut.Parameters.AddWithValue("@p5", Txt_Sektor.Text);
                komut.Parameters.AddWithValue("@p6", msk_Telefon1.Text);
                komut.Parameters.AddWithValue("@p7", msk_Telefon2.Text);
                komut.Parameters.AddWithValue("@p8", msk_Telefon3.Text);
                komut.Parameters.AddWithValue("@p9", Txt_Mail.Text);
                komut.Parameters.AddWithValue("@p10", msk_Fax.Text);
                komut.Parameters.AddWithValue("@p11", com_IL.Text);
                komut.Parameters.AddWithValue("@p12", com_ILCE.Text);
                komut.Parameters.AddWithValue("@p13", Txt_VD.Text);
                komut.Parameters.AddWithValue("@p14", Rch_Adres.Text);
                komut.Parameters.AddWithValue("@p15", Txt_OzelKod1.Text);
                komut.Parameters.AddWithValue("@p16", Txt_OzelKod2.Text);
                komut.Parameters.AddWithValue("@p17", Txt_OzelKod3.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                XtraMessageBox.Show("Firma başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            listele();
             }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int selectedID = -1;
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                selectedID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));


                DialogResult result = XtraMessageBox.Show(
                    "Seçilen firmayi silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM TBL_FIRMALAR WHERE ID = @ID", bgl.baglanti());

                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();

                        XtraMessageBox.Show("Firma başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listele();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen silmek için bir Firma seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
