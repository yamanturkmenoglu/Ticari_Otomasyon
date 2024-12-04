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
    public partial class Frm_Musteriler : Form
    {
        public Frm_Musteriler()
        {
            InitializeComponent();
        }
        SqlConnectionClass bgl = new SqlConnectionClass();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["ID"].Caption = "MÜŞTERİ Kodu";
        }
        private void Frm_Musteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirler(); 
        }

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

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TBL_MUSTERILER (AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, ADRES, VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                cmd.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@p3", msk_Telefon1.Text);
                cmd.Parameters.AddWithValue("@p4", msk_Telefon2.Text);
                cmd.Parameters.AddWithValue("@p5", msk_TC.Text);
                cmd.Parameters.AddWithValue("@p6", Txt_Mail.Text);
                cmd.Parameters.AddWithValue("@p7", com_IL.Text);
                cmd.Parameters.AddWithValue("@p8", com_ILCE.Text);
                cmd.Parameters.AddWithValue("@p9", Rch_Adres.Text);
                cmd.Parameters.AddWithValue("@p10", Txt_VD.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();

                XtraMessageBox.Show("Müşteri başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                listele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void temizle()
        {
            Txt_Ad.Text = ""; 
            Txt_Soyad.Text = ""; 
            msk_Telefon1.Text = ""; 
            msk_Telefon2.Text = ""; 
            msk_TC.Text = ""; 
            Txt_Mail.Text = "";
            com_IL.Text = ""; 
            com_ILCE.Text = "";
            Rch_Adres.Text = "";
            Txt_VD.Text = ""; 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txt_Id.Text = dr["ID"].ToString();
                Txt_Ad.Text = dr["AD"].ToString();
                Txt_Soyad.Text = dr["SOYAD"].ToString();
                msk_Telefon1.Text = dr["TELEFON"].ToString();
                msk_Telefon2.Text = dr["TELEFON2"].ToString();
                msk_TC.Text = dr["TC"].ToString();
                Txt_Mail.Text = dr["MAIL"].ToString();
                com_IL.Text = dr["IL"].ToString();
                com_ILCE.Text = dr["ILCE"].ToString();
                Rch_Adres.Text = dr["ADRES"].ToString();
                Txt_VD.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int selectedID = -1;
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                selectedID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));


                DialogResult result = XtraMessageBox.Show(
                    "Seçilen Müşteriyi silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM TBL_MUSTERILER WHERE ID = @ID", bgl.baglanti());

                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();

                        XtraMessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                XtraMessageBox.Show("Lütfen silmek için bir Müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update TBL_MUSTERILER set AD=@p1, SOYAD=@p2, TELEFON=@p3, TELEFON2=@p4, TC=@p5, MAIL=@p6, IL=@p7, ILCE=@p8, ADRES=@p9, VERGIDAIRE=@p10 where ID=@p11", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                cmd.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
                cmd.Parameters.AddWithValue("@p3", msk_Telefon1.Text);
                cmd.Parameters.AddWithValue("@p4", msk_Telefon2.Text);
                cmd.Parameters.AddWithValue("@p5", msk_TC.Text);
                cmd.Parameters.AddWithValue("@p6", Txt_Mail.Text);
                cmd.Parameters.AddWithValue("@p7", com_IL.Text); 
                cmd.Parameters.AddWithValue("@p8", com_ILCE.Text);
                cmd.Parameters.AddWithValue("@p9", Rch_Adres.Text);
                cmd.Parameters.AddWithValue("@p10", Txt_VD.Text);
                cmd.Parameters.AddWithValue("@p11", Txt_Id.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();


                XtraMessageBox.Show("Müşteri başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
