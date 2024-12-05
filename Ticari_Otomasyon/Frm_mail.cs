using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DevExpress.XtraEditors;

namespace Ticari_Otomasyon
{
    public partial class Frm_mail : Form
    {
        public Frm_mail()
        {
            InitializeComponent();
        }
        public string Mail;
        private void Frm_mail_Load(object sender, EventArgs e)
        {
           Txt_Mail.Text = Mail;
        }

        private void Btn_Gönder_Click(object sender, EventArgs e)
        {
            try
            {
                
                MailMessage mesajim = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("yaman.turkmenoglu@mefapex.com", "G/812241232642um");
                istemci.Port = 587;
                istemci.Host = "smtp.office365.com";
                istemci.EnableSsl = true;

               
                mesajim.To.Add(Txt_Mail.Text);
                mesajim.From = new MailAddress("yaman.turkmenoglu@mefapex.com");
                mesajim.Subject = Txt_Konu.Text;
                mesajim.Body = Rch_Mesaj.Text;

                
                istemci.Send(mesajim);

                
                XtraMessageBox.Show("E-posta başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                Txt_Konu.Text = string.Empty;
                Rch_Mesaj.Text = string.Empty;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("E-posta gönderilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
