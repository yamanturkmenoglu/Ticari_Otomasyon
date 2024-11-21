
namespace Ticari_Otomasyon
{
    partial class Frm_Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Urunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_SatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_AlısFiyat = new DevExpress.XtraEditors.TextEdit();
            this.Nur_Adet = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.msk_Yıl = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Marka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Id = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AlısFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nur_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(767, 560);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btn_guncelle);
            this.groupControl1.Controls.Add(this.Btn_Sil);
            this.groupControl1.Controls.Add(this.Btn_Kaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Txt_SatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.Txt_AlısFiyat);
            this.groupControl1.Controls.Add(this.Nur_Adet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.msk_Yıl);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txt_Marka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Txt_Ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txt_Model);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Txt_Id);
            this.groupControl1.Location = new System.Drawing.Point(773, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 560);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Bilgiler";
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_guncelle.Appearance.Options.UseFont = true;
            this.Btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_guncelle.Location = new System.Drawing.Point(98, 509);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(154, 32);
            this.Btn_guncelle.TabIndex = 21;
            this.Btn_guncelle.Text = "GÜNCELLE";
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(97, 471);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(154, 32);
            this.Btn_Sil.TabIndex = 20;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(97, 433);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(154, 32);
            this.Btn_Kaydet.TabIndex = 19;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(47, 283);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Detay:";
            // 
            // RchDetay
            // 
            this.RchDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchDetay.Location = new System.Drawing.Point(98, 283);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(154, 135);
            this.RchDetay.TabIndex = 17;
            this.RchDetay.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(20, 255);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Satış Fiyatı:";
            // 
            // Txt_SatisFiyat
            // 
            this.Txt_SatisFiyat.Location = new System.Drawing.Point(97, 252);
            this.Txt_SatisFiyat.Name = "Txt_SatisFiyat";
            this.Txt_SatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_SatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.Txt_SatisFiyat.Size = new System.Drawing.Size(154, 24);
            this.Txt_SatisFiyat.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(28, 224);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Alış Fiyatı:";
            // 
            // Txt_AlısFiyat
            // 
            this.Txt_AlısFiyat.Location = new System.Drawing.Point(97, 221);
            this.Txt_AlısFiyat.Name = "Txt_AlısFiyat";
            this.Txt_AlısFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_AlısFiyat.Properties.Appearance.Options.UseFont = true;
            this.Txt_AlısFiyat.Size = new System.Drawing.Size(154, 24);
            this.Txt_AlısFiyat.TabIndex = 13;
            // 
            // Nur_Adet
            // 
            this.Nur_Adet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nur_Adet.Location = new System.Drawing.Point(98, 189);
            this.Nur_Adet.Name = "Nur_Adet";
            this.Nur_Adet.Size = new System.Drawing.Size(153, 26);
            this.Nur_Adet.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(58, 191);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Adet:";
            // 
            // msk_Yıl
            // 
            this.msk_Yıl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk_Yıl.Location = new System.Drawing.Point(98, 157);
            this.msk_Yıl.Mask = "0000";
            this.msk_Yıl.Name = "msk_Yıl";
            this.msk_Yıl.Size = new System.Drawing.Size(153, 26);
            this.msk_Yıl.TabIndex = 10;
            this.msk_Yıl.ValidatingType = typeof(int);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(72, 160);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Yıl:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Marka:";
            // 
            // Txt_Marka
            // 
            this.Txt_Marka.Location = new System.Drawing.Point(98, 97);
            this.Txt_Marka.Name = "Txt_Marka";
            this.Txt_Marka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Marka.Properties.Appearance.Options.UseFont = true;
            this.Txt_Marka.Size = new System.Drawing.Size(154, 24);
            this.Txt_Marka.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(71, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ad:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(98, 67);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Ad.Properties.Appearance.Options.UseFont = true;
            this.Txt_Ad.Size = new System.Drawing.Size(154, 24);
            this.Txt_Ad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Model:";
            // 
            // Txt_Model
            // 
            this.Txt_Model.Location = new System.Drawing.Point(98, 127);
            this.Txt_Model.Name = "Txt_Model";
            this.Txt_Model.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Model.Properties.Appearance.Options.UseFont = true;
            this.Txt_Model.Size = new System.Drawing.Size(154, 24);
            this.Txt_Model.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = " KOD:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(98, 37);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Size = new System.Drawing.Size(154, 24);
            this.Txt_Id.TabIndex = 0;
            // 
            // Frm_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Urunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Frm_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AlısFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nur_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_Marka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_Model;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Txt_Id;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txt_SatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit Txt_AlısFiyat;
        private System.Windows.Forms.NumericUpDown Nur_Adet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox msk_Yıl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton Btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
    }
}