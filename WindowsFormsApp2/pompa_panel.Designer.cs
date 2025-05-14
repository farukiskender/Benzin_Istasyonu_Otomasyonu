namespace WindowsFormsApp2
{
    partial class pompa_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pompa_panel));
            this.combobox_yakit_turu = new System.Windows.Forms.ComboBox();
            this.txtbox_arac_plakasi = new System.Windows.Forms.TextBox();
            this.PP_kullanici = new System.Windows.Forms.Label();
            this.PP_cikis_btn = new System.Windows.Forms.Button();
            this.lstbox_fiyat = new System.Windows.Forms.ListBox();
            this.txtbox_yakit_miktari = new System.Windows.Forms.TextBox();
            this.lbl_toptutar = new System.Windows.Forms.Label();
            this.lbl_yakitturu = new System.Windows.Forms.Label();
            this.lbl_yakit_miktari = new System.Windows.Forms.Label();
            this.lbl_arac_plakasi = new System.Windows.Forms.Label();
            this.lbl_toplam_tutar = new System.Windows.Forms.Label();
            this.radbtn_nakit = new System.Windows.Forms.RadioButton();
            this.radbtn_kredi_karti = new System.Windows.Forms.RadioButton();
            this.lbl_odeme_turu = new System.Windows.Forms.Label();
            this.lstbox_islem_ozeti = new System.Windows.Forms.ListBox();
            this.listbox_depodurumu = new System.Windows.Forms.ListBox();
            this.btn_islemgecmisi = new System.Windows.Forms.Button();
            this.btn_yeni_islem = new System.Windows.Forms.Button();
            this.btn_doldur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_yakit_turu
            // 
            this.combobox_yakit_turu.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.combobox_yakit_turu.Location = new System.Drawing.Point(34, 62);
            this.combobox_yakit_turu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_yakit_turu.Name = "combobox_yakit_turu";
            this.combobox_yakit_turu.Size = new System.Drawing.Size(160, 24);
            this.combobox_yakit_turu.TabIndex = 12;
            this.combobox_yakit_turu.SelectedIndexChanged += new System.EventHandler(this.yakit_turu_SelectedIndexChanged);
            // 
            // txtbox_arac_plakasi
            // 
            this.txtbox_arac_plakasi.Location = new System.Drawing.Point(34, 159);
            this.txtbox_arac_plakasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_arac_plakasi.Name = "txtbox_arac_plakasi";
            this.txtbox_arac_plakasi.Size = new System.Drawing.Size(160, 22);
            this.txtbox_arac_plakasi.TabIndex = 2;
            this.txtbox_arac_plakasi.TextChanged += new System.EventHandler(this.arac_plakasi_TextChanged);
            // 
            // PP_kullanici
            // 
            this.PP_kullanici.AutoSize = true;
            this.PP_kullanici.Location = new System.Drawing.Point(445, 14);
            this.PP_kullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PP_kullanici.Name = "PP_kullanici";
            this.PP_kullanici.Size = new System.Drawing.Size(56, 16);
            this.PP_kullanici.TabIndex = 6;
            this.PP_kullanici.Text = "Kullanıcı";
            this.PP_kullanici.Click += new System.EventHandler(this.label1_Click);
            // 
            // PP_cikis_btn
            // 
            this.PP_cikis_btn.Location = new System.Drawing.Point(500, 4);
            this.PP_cikis_btn.Margin = new System.Windows.Forms.Padding(4);
            this.PP_cikis_btn.Name = "PP_cikis_btn";
            this.PP_cikis_btn.Size = new System.Drawing.Size(92, 32);
            this.PP_cikis_btn.TabIndex = 7;
            this.PP_cikis_btn.Text = "Çıkış Yap";
            this.PP_cikis_btn.UseVisualStyleBackColor = true;
            this.PP_cikis_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstbox_fiyat
            // 
            this.lstbox_fiyat.FormattingEnabled = true;
            this.lstbox_fiyat.ItemHeight = 16;
            this.lstbox_fiyat.Items.AddRange(new object[] {
            ""});
            this.lstbox_fiyat.Location = new System.Drawing.Point(419, 43);
            this.lstbox_fiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbox_fiyat.Name = "lstbox_fiyat";
            this.lstbox_fiyat.Size = new System.Drawing.Size(173, 100);
            this.lstbox_fiyat.TabIndex = 8;
            this.lstbox_fiyat.SelectedIndexChanged += new System.EventHandler(this.lstbox_fiyat_SelectedIndexChanged);
            // 
            // txtbox_yakit_miktari
            // 
            this.txtbox_yakit_miktari.Location = new System.Drawing.Point(34, 108);
            this.txtbox_yakit_miktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_yakit_miktari.Name = "txtbox_yakit_miktari";
            this.txtbox_yakit_miktari.Size = new System.Drawing.Size(160, 22);
            this.txtbox_yakit_miktari.TabIndex = 10;
            this.txtbox_yakit_miktari.TextChanged += new System.EventHandler(this.yakit_miktari_TextChanged);
            // 
            // lbl_toptutar
            // 
            this.lbl_toptutar.AutoSize = true;
            this.lbl_toptutar.Location = new System.Drawing.Point(36, 221);
            this.lbl_toptutar.Name = "lbl_toptutar";
            this.lbl_toptutar.Size = new System.Drawing.Size(33, 16);
            this.lbl_toptutar.TabIndex = 13;
            this.lbl_toptutar.Text = "0 TL";
            // 
            // lbl_yakitturu
            // 
            this.lbl_yakitturu.AutoSize = true;
            this.lbl_yakitturu.Location = new System.Drawing.Point(36, 43);
            this.lbl_yakitturu.Name = "lbl_yakitturu";
            this.lbl_yakitturu.Size = new System.Drawing.Size(67, 16);
            this.lbl_yakitturu.TabIndex = 15;
            this.lbl_yakitturu.Text = "Yakıt Türü";
            // 
            // lbl_yakit_miktari
            // 
            this.lbl_yakit_miktari.AutoSize = true;
            this.lbl_yakit_miktari.Location = new System.Drawing.Point(34, 92);
            this.lbl_yakit_miktari.Name = "lbl_yakit_miktari";
            this.lbl_yakit_miktari.Size = new System.Drawing.Size(100, 16);
            this.lbl_yakit_miktari.TabIndex = 16;
            this.lbl_yakit_miktari.Text = "Yakıt Miktarı (Lt)";
            // 
            // lbl_arac_plakasi
            // 
            this.lbl_arac_plakasi.AutoSize = true;
            this.lbl_arac_plakasi.Location = new System.Drawing.Point(34, 139);
            this.lbl_arac_plakasi.Name = "lbl_arac_plakasi";
            this.lbl_arac_plakasi.Size = new System.Drawing.Size(83, 16);
            this.lbl_arac_plakasi.TabIndex = 17;
            this.lbl_arac_plakasi.Text = "Araç Plakası";
            // 
            // lbl_toplam_tutar
            // 
            this.lbl_toplam_tutar.AutoSize = true;
            this.lbl_toplam_tutar.Location = new System.Drawing.Point(31, 194);
            this.lbl_toplam_tutar.Name = "lbl_toplam_tutar";
            this.lbl_toplam_tutar.Size = new System.Drawing.Size(88, 16);
            this.lbl_toplam_tutar.TabIndex = 18;
            this.lbl_toplam_tutar.Text = "Toplam Tutar";
            // 
            // radbtn_nakit
            // 
            this.radbtn_nakit.AutoSize = true;
            this.radbtn_nakit.Location = new System.Drawing.Point(36, 263);
            this.radbtn_nakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radbtn_nakit.Name = "radbtn_nakit";
            this.radbtn_nakit.Size = new System.Drawing.Size(59, 20);
            this.radbtn_nakit.TabIndex = 19;
            this.radbtn_nakit.TabStop = true;
            this.radbtn_nakit.Text = "Nakit";
            this.radbtn_nakit.UseVisualStyleBackColor = true;
            this.radbtn_nakit.CheckedChanged += new System.EventHandler(this.radbtn_nakit_CheckedChanged);
            // 
            // radbtn_kredi_karti
            // 
            this.radbtn_kredi_karti.AutoSize = true;
            this.radbtn_kredi_karti.Location = new System.Drawing.Point(36, 290);
            this.radbtn_kredi_karti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radbtn_kredi_karti.Name = "radbtn_kredi_karti";
            this.radbtn_kredi_karti.Size = new System.Drawing.Size(88, 20);
            this.radbtn_kredi_karti.TabIndex = 20;
            this.radbtn_kredi_karti.TabStop = true;
            this.radbtn_kredi_karti.Text = "Kredi Kartı";
            this.radbtn_kredi_karti.UseVisualStyleBackColor = true;
            this.radbtn_kredi_karti.CheckedChanged += new System.EventHandler(this.radbtn_kredi_karti_CheckedChanged);
            // 
            // lbl_odeme_turu
            // 
            this.lbl_odeme_turu.AutoSize = true;
            this.lbl_odeme_turu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_odeme_turu.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_odeme_turu.Location = new System.Drawing.Point(863, 391);
            this.lbl_odeme_turu.Name = "lbl_odeme_turu";
            this.lbl_odeme_turu.Size = new System.Drawing.Size(0, 16);
            this.lbl_odeme_turu.TabIndex = 21;
            // 
            // lstbox_islem_ozeti
            // 
            this.lstbox_islem_ozeti.FormattingEnabled = true;
            this.lstbox_islem_ozeti.ItemHeight = 16;
            this.lstbox_islem_ozeti.Items.AddRange(new object[] {
            "İşlem Özeti"});
            this.lstbox_islem_ozeti.Location = new System.Drawing.Point(220, 43);
            this.lstbox_islem_ozeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbox_islem_ozeti.Name = "lstbox_islem_ozeti";
            this.lstbox_islem_ozeti.Size = new System.Drawing.Size(173, 260);
            this.lstbox_islem_ozeti.TabIndex = 22;
            // 
            // listbox_depodurumu
            // 
            this.listbox_depodurumu.FormattingEnabled = true;
            this.listbox_depodurumu.ItemHeight = 16;
            this.listbox_depodurumu.Items.AddRange(new object[] {
            ""});
            this.listbox_depodurumu.Location = new System.Drawing.Point(419, 194);
            this.listbox_depodurumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbox_depodurumu.Name = "listbox_depodurumu";
            this.listbox_depodurumu.Size = new System.Drawing.Size(173, 100);
            this.listbox_depodurumu.TabIndex = 23;
            this.listbox_depodurumu.SelectedIndexChanged += new System.EventHandler(this.listbox_depodurumu_SelectedIndexChanged);
            // 
            // btn_islemgecmisi
            // 
            this.btn_islemgecmisi.Image = ((System.Drawing.Image)(resources.GetObject("btn_islemgecmisi.Image")));
            this.btn_islemgecmisi.Location = new System.Drawing.Point(419, 333);
            this.btn_islemgecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_islemgecmisi.Name = "btn_islemgecmisi";
            this.btn_islemgecmisi.Size = new System.Drawing.Size(173, 83);
            this.btn_islemgecmisi.TabIndex = 24;
            this.btn_islemgecmisi.UseVisualStyleBackColor = true;
            this.btn_islemgecmisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_yeni_islem
            // 
            this.btn_yeni_islem.Image = ((System.Drawing.Image)(resources.GetObject("btn_yeni_islem.Image")));
            this.btn_yeni_islem.Location = new System.Drawing.Point(220, 333);
            this.btn_yeni_islem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_yeni_islem.Name = "btn_yeni_islem";
            this.btn_yeni_islem.Size = new System.Drawing.Size(173, 83);
            this.btn_yeni_islem.TabIndex = 14;
            this.btn_yeni_islem.UseVisualStyleBackColor = true;
            this.btn_yeni_islem.Click += new System.EventHandler(this.btn_yeni_islem_Click);
            // 
            // btn_doldur
            // 
            this.btn_doldur.Image = ((System.Drawing.Image)(resources.GetObject("btn_doldur.Image")));
            this.btn_doldur.Location = new System.Drawing.Point(30, 333);
            this.btn_doldur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doldur.Name = "btn_doldur";
            this.btn_doldur.Size = new System.Drawing.Size(173, 83);
            this.btn_doldur.TabIndex = 11;
            this.btn_doldur.UseVisualStyleBackColor = true;
            this.btn_doldur.Click += new System.EventHandler(this.btn_doldur_Click);
            // 
            // pompa_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.btn_islemgecmisi);
            this.Controls.Add(this.listbox_depodurumu);
            this.Controls.Add(this.lstbox_islem_ozeti);
            this.Controls.Add(this.lbl_odeme_turu);
            this.Controls.Add(this.radbtn_kredi_karti);
            this.Controls.Add(this.radbtn_nakit);
            this.Controls.Add(this.lbl_toplam_tutar);
            this.Controls.Add(this.lbl_arac_plakasi);
            this.Controls.Add(this.lbl_yakit_miktari);
            this.Controls.Add(this.lbl_yakitturu);
            this.Controls.Add(this.btn_yeni_islem);
            this.Controls.Add(this.lbl_toptutar);
            this.Controls.Add(this.btn_doldur);
            this.Controls.Add(this.txtbox_yakit_miktari);
            this.Controls.Add(this.lstbox_fiyat);
            this.Controls.Add(this.PP_cikis_btn);
            this.Controls.Add(this.PP_kullanici);
            this.Controls.Add(this.txtbox_arac_plakasi);
            this.Controls.Add(this.combobox_yakit_turu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pompa_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pompa Paneli";
            this.Load += new System.EventHandler(this.pompa_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_yakit_turu;
        private System.Windows.Forms.TextBox txtbox_arac_plakasi;
        private System.Windows.Forms.Label PP_kullanici;
        private System.Windows.Forms.Button PP_cikis_btn;
        private System.Windows.Forms.ListBox lstbox_fiyat;
        private System.Windows.Forms.TextBox txtbox_yakit_miktari;
        private System.Windows.Forms.Button btn_doldur;
        private System.Windows.Forms.Label lbl_toptutar;
        private System.Windows.Forms.Button btn_yeni_islem;
        private System.Windows.Forms.Label lbl_yakitturu;
        private System.Windows.Forms.Label lbl_yakit_miktari;
        private System.Windows.Forms.Label lbl_arac_plakasi;
        private System.Windows.Forms.Label lbl_toplam_tutar;
        private System.Windows.Forms.RadioButton radbtn_nakit;
        private System.Windows.Forms.RadioButton radbtn_kredi_karti;
        private System.Windows.Forms.Label lbl_odeme_turu;
        private System.Windows.Forms.ListBox lstbox_islem_ozeti;
        private System.Windows.Forms.ListBox listbox_depodurumu;
        private System.Windows.Forms.Button btn_islemgecmisi;
    }
}