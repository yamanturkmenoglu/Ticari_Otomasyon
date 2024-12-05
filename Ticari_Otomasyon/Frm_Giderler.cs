using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
namespace Ticari_Otomasyon
{
    public partial class Frm_Giderler : Form
    {
        public Frm_Giderler()
        {
            InitializeComponent();
        }
        SqlConnectionClass bgl = new SqlConnectionClass();
        void temizle()
        {
            Txt_Id.Text = "";
            Txt_Ekstra.Text = "";
            Txt_Dogalgaz.Text = "";
            Txt_Elekitrik.Text = "";
            Txt_Internet.Text = "";
            Txt_Maas.Text = "";
            com_Ay.Text = "";
            com_Yıl.Text = "";
            Txt_Su.Text = "";
            Rch_Notlar.Text = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txt_Id.Text = dr["ID"].ToString();
                Txt_Ekstra.Text = dr["EKSTRA"].ToString();
                Txt_Dogalgaz.Text = dr["DOGALGAZ"].ToString();
                Txt_Elekitrik.Text = dr["ELEKITRIK"].ToString();
                Txt_Internet.Text = dr["INTERNET"].ToString();
                Txt_Maas.Text = dr["MAASLAR"].ToString();
                Txt_Su.Text = dr["SU"].ToString();
                Rch_Notlar.Text = dr["NOTLAR"].ToString();
                com_Ay.Text = dr["AY"].ToString();
                com_Yıl.Text = dr["YIL"].ToString();

            }
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns["ID"].Caption = "Gider Kodu";

        }
        private void Frm_Giderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER  (AY, YIL, ELEKITRIK, SU, DOGALGAZ, INTERNET, MAASLAR, EKSTRA, NOTLAR)" +
                " values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", com_Ay.Text);
                komut.Parameters.AddWithValue("@P2", com_Yıl.Text);
                komut.Parameters.AddWithValue("@P3", decimal.Parse(Txt_Elekitrik.Text));
                komut.Parameters.AddWithValue("@P4", decimal.Parse(Txt_Su.Text));
                komut.Parameters.AddWithValue("@P5", decimal.Parse(Txt_Dogalgaz.Text));
                komut.Parameters.AddWithValue("@P6", decimal.Parse (Txt_Internet.Text));
                komut.Parameters.AddWithValue("@P7", decimal.Parse(Txt_Maas.Text));
                komut.Parameters.AddWithValue("@P8", decimal.Parse(Txt_Ekstra.Text));
                komut.Parameters.AddWithValue("@P9",Rch_Notlar.Text);
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
                    "Seçilen Gider Bilgisi silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM TBL_GIDERLER WHERE ID = @ID", bgl.baglanti());

                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();

                        XtraMessageBox.Show("Gider Bilgisi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temizle();
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
                XtraMessageBox.Show("Lütfen silmek için bir Gider Bilgisi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Update TBL_GIDERLER set AY=@p1, YIL=@p2, ELEKITRIK=@p3, SU=@p4, DOGALGAZ=@p5, INTERNET=@p6, MAASLAR=@p7, EKSTRA=@p8, NOTLAR=@p9  where ID=@p11", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", com_Ay.Text);
                cmd.Parameters.AddWithValue("@p2", com_Yıl.Text);
                cmd.Parameters.AddWithValue("@p3", decimal.Parse( Txt_Elekitrik.Text));
                cmd.Parameters.AddWithValue("@p4", decimal.Parse( Txt_Su.Text));
                cmd.Parameters.AddWithValue("@p5", decimal.Parse( Txt_Dogalgaz.Text));
                cmd.Parameters.AddWithValue("@p6", decimal.Parse(Txt_Internet.Text));
                cmd.Parameters.AddWithValue("@p7", decimal.Parse(Txt_Maas.Text));
                cmd.Parameters.AddWithValue("@p8", decimal.Parse(Txt_Ekstra.Text));
                cmd.Parameters.AddWithValue("@p9", Rch_Notlar.Text);
                
                cmd.Parameters.AddWithValue("@p11", Txt_Id.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                temizle()

                XtraMessageBox.Show("Gider Bilgisi başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

