
namespace Ticari_Otomasyon
{
    partial class Frm_mail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mail));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Mail = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Konu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Rch_Mesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Gönder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Konu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.Location = new System.Drawing.Point(91, 136);
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Mail.Properties.Appearance.Options.UseFont = true;
            this.Txt_Mail.Size = new System.Drawing.Size(327, 22);
            this.Txt_Mail.TabIndex = 1;
            // 
            // Txt_Konu
            // 
            this.Txt_Konu.Location = new System.Drawing.Point(91, 159);
            this.Txt_Konu.Name = "Txt_Konu";
            this.Txt_Konu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Konu.Properties.Appearance.Options.UseFont = true;
            this.Txt_Konu.Size = new System.Drawing.Size(327, 22);
            this.Txt_Konu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // Rch_Mesaj
            // 
            this.Rch_Mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rch_Mesaj.Location = new System.Drawing.Point(91, 185);
            this.Rch_Mesaj.Name = "Rch_Mesaj";
            this.Rch_Mesaj.Size = new System.Drawing.Size(327, 257);
            this.Rch_Mesaj.TabIndex = 4;
            this.Rch_Mesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj:";
            // 
            // Btn_Gönder
            // 
            this.Btn_Gönder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Gönder.Appearance.Options.UseFont = true;
            this.Btn_Gönder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Gönder.ImageOptions.Image")));
            this.Btn_Gönder.Location = new System.Drawing.Point(182, 493);
            this.Btn_Gönder.Name = "Btn_Gönder";
            this.Btn_Gönder.Size = new System.Drawing.Size(94, 34);
            this.Btn_Gönder.TabIndex = 6;
            this.Btn_Gönder.Text = "Gönder";
            this.Btn_Gönder.Click += new System.EventHandler(this.Btn_Gönder_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 100);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Gönderme Paneli ";
            // 
            // Frm_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Gönder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rch_Mesaj);
            this.Controls.Add(this.Txt_Konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Mail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            this.Load += new System.EventHandler(this.Frm_mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Konu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit Txt_Mail;
        private DevExpress.XtraEditors.TextEdit Txt_Konu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Rch_Mesaj;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton Btn_Gönder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}