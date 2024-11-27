using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_Urunler : Form
    {
        public Frm_Urunler()
        {
            InitializeComponent();
        }
        SqlConnectionClass bgl = new SqlConnectionClass();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;



            gridView1.Columns["URUNAD"].Caption = "ÜRÜN ADI";
            gridView1.Columns["ID"].Caption = "ÜRÜN Kodu";
            gridView1.Columns["ALISFIYATI"].Caption = "ALIŞ FİYATI";
            gridView1.Columns["SATISFIYATI"].Caption = "SATIŞ FİYATI";
      
        }

        private void Frm_Urunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYATI,SATISFIYATI,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                cmd.Parameters.AddWithValue("@p2", Txt_Marka.Text);
                cmd.Parameters.AddWithValue("@p3", Txt_Model.Text);
                cmd.Parameters.AddWithValue("@p4", msk_Yıl.Text);
                cmd.Parameters.AddWithValue("@p5", int.Parse((Nur_Adet.Value).ToString()));
                cmd.Parameters.AddWithValue("@p6", decimal.Parse(Txt_AlısFiyat.Text));
                cmd.Parameters.AddWithValue("@p7", decimal.Parse(Txt_SatisFiyat.Text));
                cmd.Parameters.AddWithValue("@p8", RchDetay.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();

               
              XtraMessageBox.Show("Ürün başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                listele();
            }
            catch (Exception ex)
            {
               XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void temizle()
        {
            Txt_Ad.Text = string.Empty;
            Txt_Marka.Text = string.Empty;
            Txt_Model.Text = string.Empty;
            msk_Yıl.Text = string.Empty;
            Nur_Adet.Value = 0; 
            Txt_AlısFiyat.Text = string.Empty;
            Txt_SatisFiyat.Text = string.Empty;
            RchDetay.Text = string.Empty;
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            
            int selectedID = -1; 
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                selectedID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                
                DialogResult result = XtraMessageBox.Show(
                    "Seçilen ürünü silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {

                        try
                        {
                        SqlCommand cmd = new SqlCommand("DELETE FROM TBL_URUNLER WHERE ID = @ID", bgl.baglanti());

                        cmd.Parameters.AddWithValue("@ID", selectedID);
                            cmd.ExecuteNonQuery();

                            XtraMessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                XtraMessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            Txt_Id.Text = dr["ID"].ToString();
            Txt_Ad.Text = dr["URUNAD"].ToString();
            Txt_Marka.Text = dr["MARKA"].ToString();
            Txt_Model.Text = dr["MODEL"].ToString();
            msk_Yıl.Text = dr["YIL"].ToString();
            Nur_Adet.Value = decimal.Parse(dr["ADET"].ToString());
            Txt_AlısFiyat.Text = dr["ALISFIYATI"].ToString();
            Txt_SatisFiyat.Text = dr["SATISFIYATI"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYATI=@p6,SATISFIYATI=@p7,DETAY=@p8 where ID=@p9", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                cmd.Parameters.AddWithValue("@p2", Txt_Marka.Text);
                cmd.Parameters.AddWithValue("@p3", Txt_Model.Text);
                cmd.Parameters.AddWithValue("@p4", msk_Yıl.Text);
                cmd.Parameters.AddWithValue("@p5", int.Parse((Nur_Adet.Value).ToString()));
                cmd.Parameters.AddWithValue("@p6", decimal.Parse(Txt_AlısFiyat.Text));
                cmd.Parameters.AddWithValue("@p7", decimal.Parse(Txt_SatisFiyat.Text));
                cmd.Parameters.AddWithValue("@p8", RchDetay.Text);
                cmd.Parameters.AddWithValue("@p9", Txt_Id.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();


                XtraMessageBox.Show("Ürün başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                listele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
