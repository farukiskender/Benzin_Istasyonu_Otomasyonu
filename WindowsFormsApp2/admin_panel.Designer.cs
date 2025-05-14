namespace WindowsFormsApp2
{
    partial class admin_panel
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
            System.Windows.Forms.Button btn_kullanici_sil;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.AP_cıkıs_btn = new System.Windows.Forms.Button();
            this.AP_kullanici = new System.Windows.Forms.Label();
            this.TESTMODE_EXITALLPANEL = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_anasayfa = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_benzin = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_DepoLPGMiktari = new System.Windows.Forms.Label();
            this.PB_dizel = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.PB_lpg = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_DepoBenzinMiktari = new System.Windows.Forms.Label();
            this.lbl_DepoDizelMiktari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_yenifiyat = new System.Windows.Forms.TextBox();
            this.combobox_yakit_turu = new System.Windows.Forms.ComboBox();
            this.btn_fiyatGuncelle = new System.Windows.Forms.Button();
            this.listbox_fiyat = new System.Windows.Forms.ListBox();
            this.tp_kullaniciListesi = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_kullanicilar = new System.Windows.Forms.DataGridView();
            this.txtbox_personelIletisim = new System.Windows.Forms.TextBox();
            this.txtbox_personelTc = new System.Windows.Forms.TextBox();
            this.btn_kullanici_listele = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txtbox_personelAdi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_yeni_kullanici = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_yeni_kullanici_adı = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbox_yeni_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combobox_yeni_kullanici_yetki = new System.Windows.Forms.ComboBox();
            this.tp_satisgecmisi = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_dgvguncelle = new System.Windows.Forms.Button();
            this.dgv_satisgecmisi = new System.Windows.Forms.DataGridView();
            this.btn_islem_sil = new System.Windows.Forms.Button();
            this.tp_alisgecmisi = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgv_alisGecmisi = new System.Windows.Forms.DataGridView();
            btn_kullanici_sil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_anasayfa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tp_kullaniciListesi.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanicilar)).BeginInit();
            this.tp_satisgecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satisgecmisi)).BeginInit();
            this.tp_alisgecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kullanici_sil
            // 
            btn_kullanici_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_sil.Image")));
            btn_kullanici_sil.Location = new System.Drawing.Point(55, 392);
            btn_kullanici_sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_kullanici_sil.Name = "btn_kullanici_sil";
            btn_kullanici_sil.Size = new System.Drawing.Size(266, 54);
            btn_kullanici_sil.TabIndex = 19;
            btn_kullanici_sil.UseVisualStyleBackColor = true;
            btn_kullanici_sil.Click += new System.EventHandler(this.btn_kullanici_sil_Click);
            // 
            // AP_cıkıs_btn
            // 
            this.AP_cıkıs_btn.Location = new System.Drawing.Point(1180, 9);
            this.AP_cıkıs_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AP_cıkıs_btn.Name = "AP_cıkıs_btn";
            this.AP_cıkıs_btn.Size = new System.Drawing.Size(92, 32);
            this.AP_cıkıs_btn.TabIndex = 9;
            this.AP_cıkıs_btn.Text = "Çıkış Yap";
            this.AP_cıkıs_btn.UseVisualStyleBackColor = true;
            this.AP_cıkıs_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AP_kullanici
            // 
            this.AP_kullanici.AutoSize = true;
            this.AP_kullanici.Location = new System.Drawing.Point(1126, 18);
            this.AP_kullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AP_kullanici.Name = "AP_kullanici";
            this.AP_kullanici.Size = new System.Drawing.Size(56, 16);
            this.AP_kullanici.TabIndex = 8;
            this.AP_kullanici.Text = "Kullanıcı";
            // 
            // TESTMODE_EXITALLPANEL
            // 
            this.TESTMODE_EXITALLPANEL.Location = new System.Drawing.Point(1087, 62);
            this.TESTMODE_EXITALLPANEL.Margin = new System.Windows.Forms.Padding(4);
            this.TESTMODE_EXITALLPANEL.Name = "TESTMODE_EXITALLPANEL";
            this.TESTMODE_EXITALLPANEL.Size = new System.Drawing.Size(172, 73);
            this.TESTMODE_EXITALLPANEL.TabIndex = 10;
            this.TESTMODE_EXITALLPANEL.Text = "Programı Kapat";
            this.TESTMODE_EXITALLPANEL.UseVisualStyleBackColor = true;
            this.TESTMODE_EXITALLPANEL.Visible = false;
            this.TESTMODE_EXITALLPANEL.Click += new System.EventHandler(this.TESTMODE_EXITALLPANEL_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_anasayfa);
            this.tabControl1.Controls.Add(this.tp_kullaniciListesi);
            this.tabControl1.Controls.Add(this.tp_satisgecmisi);
            this.tabControl1.Controls.Add(this.tp_alisgecmisi);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1312, 579);
            this.tabControl1.TabIndex = 13;
            // 
            // tp_anasayfa
            // 
            this.tp_anasayfa.Controls.Add(this.panel2);
            this.tp_anasayfa.Controls.Add(this.panel1);
            this.tp_anasayfa.Controls.Add(this.TESTMODE_EXITALLPANEL);
            this.tp_anasayfa.Controls.Add(this.AP_cıkıs_btn);
            this.tp_anasayfa.Controls.Add(this.AP_kullanici);
            this.tp_anasayfa.ForeColor = System.Drawing.Color.Black;
            this.tp_anasayfa.Location = new System.Drawing.Point(4, 25);
            this.tp_anasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.tp_anasayfa.Name = "tp_anasayfa";
            this.tp_anasayfa.Size = new System.Drawing.Size(1304, 550);
            this.tp_anasayfa.TabIndex = 2;
            this.tp_anasayfa.Text = "Ana Sayfa";
            this.tp_anasayfa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PB_benzin);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbl_DepoLPGMiktari);
            this.panel2.Controls.Add(this.PB_dizel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.PB_lpg);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_DepoBenzinMiktari);
            this.panel2.Controls.Add(this.lbl_DepoDizelMiktari);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(24, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 196);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Güncel Depo Durumu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lpg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Depo Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dizel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Benzin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PB_benzin
            // 
            this.PB_benzin.Location = new System.Drawing.Point(76, 38);
            this.PB_benzin.Margin = new System.Windows.Forms.Padding(4);
            this.PB_benzin.Maximum = 25000;
            this.PB_benzin.Name = "PB_benzin";
            this.PB_benzin.Size = new System.Drawing.Size(284, 28);
            this.PB_benzin.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "15.000Lt";
            // 
            // lbl_DepoLPGMiktari
            // 
            this.lbl_DepoLPGMiktari.AutoSize = true;
            this.lbl_DepoLPGMiktari.Location = new System.Drawing.Point(370, 113);
            this.lbl_DepoLPGMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoLPGMiktari.Name = "lbl_DepoLPGMiktari";
            this.lbl_DepoLPGMiktari.Size = new System.Drawing.Size(17, 16);
            this.lbl_DepoLPGMiktari.TabIndex = 41;
            this.lbl_DepoLPGMiktari.Text = " 0";
            // 
            // PB_dizel
            // 
            this.PB_dizel.Location = new System.Drawing.Point(76, 74);
            this.PB_dizel.Margin = new System.Windows.Forms.Padding(4);
            this.PB_dizel.Maximum = 40000;
            this.PB_dizel.Name = "PB_dizel";
            this.PB_dizel.Size = new System.Drawing.Size(284, 28);
            this.PB_dizel.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "/";
            // 
            // PB_lpg
            // 
            this.PB_lpg.Location = new System.Drawing.Point(76, 109);
            this.PB_lpg.Margin = new System.Windows.Forms.Padding(4);
            this.PB_lpg.Maximum = 15000;
            this.PB_lpg.Name = "PB_lpg";
            this.PB_lpg.Size = new System.Drawing.Size(284, 30);
            this.PB_lpg.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "40.000Lt";
            // 
            // lbl_DepoBenzinMiktari
            // 
            this.lbl_DepoBenzinMiktari.AutoSize = true;
            this.lbl_DepoBenzinMiktari.Location = new System.Drawing.Point(372, 42);
            this.lbl_DepoBenzinMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoBenzinMiktari.Name = "lbl_DepoBenzinMiktari";
            this.lbl_DepoBenzinMiktari.Size = new System.Drawing.Size(14, 16);
            this.lbl_DepoBenzinMiktari.TabIndex = 35;
            this.lbl_DepoBenzinMiktari.Text = "0";
            // 
            // lbl_DepoDizelMiktari
            // 
            this.lbl_DepoDizelMiktari.AutoSize = true;
            this.lbl_DepoDizelMiktari.Location = new System.Drawing.Point(370, 79);
            this.lbl_DepoDizelMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoDizelMiktari.Name = "lbl_DepoDizelMiktari";
            this.lbl_DepoDizelMiktari.Size = new System.Drawing.Size(17, 16);
            this.lbl_DepoDizelMiktari.TabIndex = 38;
            this.lbl_DepoDizelMiktari.Text = " 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "25.000Lt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "/";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbox_yenifiyat);
            this.panel1.Controls.Add(this.combobox_yakit_turu);
            this.panel1.Controls.Add(this.btn_fiyatGuncelle);
            this.panel1.Controls.Add(this.listbox_fiyat);
            this.panel1.Location = new System.Drawing.Point(600, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 140);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yakıt Fiyat Güncelleme";
            // 
            // txtbox_yenifiyat
            // 
            this.txtbox_yenifiyat.Location = new System.Drawing.Point(9, 73);
            this.txtbox_yenifiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_yenifiyat.Name = "txtbox_yenifiyat";
            this.txtbox_yenifiyat.Size = new System.Drawing.Size(121, 22);
            this.txtbox_yenifiyat.TabIndex = 3;
            this.txtbox_yenifiyat.Text = " ";
            // 
            // combobox_yakit_turu
            // 
            this.combobox_yakit_turu.FormattingEnabled = true;
            this.combobox_yakit_turu.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.combobox_yakit_turu.Location = new System.Drawing.Point(9, 42);
            this.combobox_yakit_turu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_yakit_turu.Name = "combobox_yakit_turu";
            this.combobox_yakit_turu.Size = new System.Drawing.Size(121, 24);
            this.combobox_yakit_turu.TabIndex = 2;
            this.combobox_yakit_turu.Text = " ";
            // 
            // btn_fiyatGuncelle
            // 
            this.btn_fiyatGuncelle.Location = new System.Drawing.Point(9, 103);
            this.btn_fiyatGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fiyatGuncelle.Name = "btn_fiyatGuncelle";
            this.btn_fiyatGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btn_fiyatGuncelle.TabIndex = 1;
            this.btn_fiyatGuncelle.Text = "Fiyatı Güncelle";
            this.btn_fiyatGuncelle.UseVisualStyleBackColor = true;
            this.btn_fiyatGuncelle.Click += new System.EventHandler(this.btn_fiyatGuncelle_Click);
            // 
            // listbox_fiyat
            // 
            this.listbox_fiyat.FormattingEnabled = true;
            this.listbox_fiyat.ItemHeight = 16;
            this.listbox_fiyat.Location = new System.Drawing.Point(136, 42);
            this.listbox_fiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbox_fiyat.Name = "listbox_fiyat";
            this.listbox_fiyat.Size = new System.Drawing.Size(121, 84);
            this.listbox_fiyat.TabIndex = 0;
            this.listbox_fiyat.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tp_kullaniciListesi
            // 
            this.tp_kullaniciListesi.Controls.Add(this.panel3);
            this.tp_kullaniciListesi.Location = new System.Drawing.Point(4, 25);
            this.tp_kullaniciListesi.Margin = new System.Windows.Forms.Padding(4);
            this.tp_kullaniciListesi.Name = "tp_kullaniciListesi";
            this.tp_kullaniciListesi.Padding = new System.Windows.Forms.Padding(4);
            this.tp_kullaniciListesi.Size = new System.Drawing.Size(1304, 550);
            this.tp_kullaniciListesi.TabIndex = 0;
            this.tp_kullaniciListesi.Text = "Kullanıcı Listesi";
            this.tp_kullaniciListesi.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.dgv_kullanicilar);
            this.panel3.Controls.Add(this.txtbox_personelIletisim);
            this.panel3.Controls.Add(this.txtbox_personelTc);
            this.panel3.Controls.Add(this.btn_kullanici_listele);
            this.panel3.Controls.Add(btn_kullanici_sil);
            this.panel3.Controls.Add(this.btn_kaydet);
            this.panel3.Controls.Add(this.txtbox_personelAdi);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btn_yeni_kullanici);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtbox_yeni_kullanici_adı);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtbox_yeni_kullanici_sifre);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.combobox_yeni_kullanici_yetki);
            this.panel3.Location = new System.Drawing.Point(3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 468);
            this.panel3.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(105, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 22);
            this.label16.TabIndex = 24;
            this.label16.Text = "Kullanıcı Yönetimi";
            // 
            // dgv_kullanicilar
            // 
            this.dgv_kullanicilar.AllowUserToAddRows = false;
            this.dgv_kullanicilar.AllowUserToDeleteRows = false;
            this.dgv_kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullanicilar.Location = new System.Drawing.Point(395, 2);
            this.dgv_kullanicilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_kullanicilar.Name = "dgv_kullanicilar";
            this.dgv_kullanicilar.RowHeadersWidth = 51;
            this.dgv_kullanicilar.RowTemplate.Height = 24;
            this.dgv_kullanicilar.Size = new System.Drawing.Size(875, 450);
            this.dgv_kullanicilar.TabIndex = 14;
            this.dgv_kullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kullanicilar_CellContentClick);
            // 
            // txtbox_personelIletisim
            // 
            this.txtbox_personelIletisim.Location = new System.Drawing.Point(184, 223);
            this.txtbox_personelIletisim.Name = "txtbox_personelIletisim";
            this.txtbox_personelIletisim.Size = new System.Drawing.Size(137, 22);
            this.txtbox_personelIletisim.TabIndex = 23;
            // 
            // txtbox_personelTc
            // 
            this.txtbox_personelTc.Location = new System.Drawing.Point(184, 184);
            this.txtbox_personelTc.Name = "txtbox_personelTc";
            this.txtbox_personelTc.Size = new System.Drawing.Size(137, 22);
            this.txtbox_personelTc.TabIndex = 23;
            this.txtbox_personelTc.TextChanged += new System.EventHandler(this.txtbox_personelTc_TextChanged);
            this.txtbox_personelTc.Validated += new System.EventHandler(this.txtbox_personelTc_Validate);
            // 
            // btn_kullanici_listele
            // 
            this.btn_kullanici_listele.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_listele.Image")));
            this.btn_kullanici_listele.Location = new System.Drawing.Point(55, 334);
            this.btn_kullanici_listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kullanici_listele.Name = "btn_kullanici_listele";
            this.btn_kullanici_listele.Size = new System.Drawing.Size(266, 54);
            this.btn_kullanici_listele.TabIndex = 13;
            this.btn_kullanici_listele.UseVisualStyleBackColor = true;
            this.btn_kullanici_listele.Click += new System.EventHandler(this.btn_kullanici_listele_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(55, 260);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(130, 70);
            this.btn_kaydet.TabIndex = 20;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txtbox_personelAdi
            // 
            this.txtbox_personelAdi.Location = new System.Drawing.Point(185, 146);
            this.txtbox_personelAdi.Name = "txtbox_personelAdi";
            this.txtbox_personelAdi.Size = new System.Drawing.Size(136, 22);
            this.txtbox_personelAdi.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(69, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Personel İletişim";
            // 
            // btn_yeni_kullanici
            // 
            this.btn_yeni_kullanici.Image = ((System.Drawing.Image)(resources.GetObject("btn_yeni_kullanici.Image")));
            this.btn_yeni_kullanici.Location = new System.Drawing.Point(191, 260);
            this.btn_yeni_kullanici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_yeni_kullanici.Name = "btn_yeni_kullanici";
            this.btn_yeni_kullanici.Size = new System.Drawing.Size(130, 70);
            this.btn_yeni_kullanici.TabIndex = 18;
            this.btn_yeni_kullanici.UseVisualStyleBackColor = true;
            this.btn_yeni_kullanici.Click += new System.EventHandler(this.btn_yeni_kullanici_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "Personel TC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Personel Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txtbox_yeni_kullanici_adı
            // 
            this.txtbox_yeni_kullanici_adı.Location = new System.Drawing.Point(184, 32);
            this.txtbox_yeni_kullanici_adı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_yeni_kullanici_adı.Name = "txtbox_yeni_kullanici_adı";
            this.txtbox_yeni_kullanici_adı.Size = new System.Drawing.Size(137, 22);
            this.txtbox_yeni_kullanici_adı.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Yetki";
            // 
            // txtbox_yeni_kullanici_sifre
            // 
            this.txtbox_yeni_kullanici_sifre.Location = new System.Drawing.Point(184, 67);
            this.txtbox_yeni_kullanici_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_yeni_kullanici_sifre.Name = "txtbox_yeni_kullanici_sifre";
            this.txtbox_yeni_kullanici_sifre.Size = new System.Drawing.Size(137, 22);
            this.txtbox_yeni_kullanici_sifre.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Şifre";
            // 
            // combobox_yeni_kullanici_yetki
            // 
            this.combobox_yeni_kullanici_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_yeni_kullanici_yetki.FormattingEnabled = true;
            this.combobox_yeni_kullanici_yetki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combobox_yeni_kullanici_yetki.Items.AddRange(new object[] {
            "yönetici",
            "depo",
            "pompa"});
            this.combobox_yeni_kullanici_yetki.Location = new System.Drawing.Point(184, 112);
            this.combobox_yeni_kullanici_yetki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_yeni_kullanici_yetki.Name = "combobox_yeni_kullanici_yetki";
            this.combobox_yeni_kullanici_yetki.Size = new System.Drawing.Size(137, 24);
            this.combobox_yeni_kullanici_yetki.TabIndex = 17;
            // 
            // tp_satisgecmisi
            // 
            this.tp_satisgecmisi.Controls.Add(this.button4);
            this.tp_satisgecmisi.Controls.Add(this.btn_dgvguncelle);
            this.tp_satisgecmisi.Controls.Add(this.dgv_satisgecmisi);
            this.tp_satisgecmisi.Controls.Add(this.btn_islem_sil);
            this.tp_satisgecmisi.Location = new System.Drawing.Point(4, 25);
            this.tp_satisgecmisi.Margin = new System.Windows.Forms.Padding(4);
            this.tp_satisgecmisi.Name = "tp_satisgecmisi";
            this.tp_satisgecmisi.Padding = new System.Windows.Forms.Padding(4);
            this.tp_satisgecmisi.Size = new System.Drawing.Size(1304, 550);
            this.tp_satisgecmisi.TabIndex = 1;
            this.tp_satisgecmisi.Text = "Satış Geçmişi";
            this.tp_satisgecmisi.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1154, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 230);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_dgvguncelle
            // 
            this.btn_dgvguncelle.Location = new System.Drawing.Point(1029, -53);
            this.btn_dgvguncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dgvguncelle.Name = "btn_dgvguncelle";
            this.btn_dgvguncelle.Size = new System.Drawing.Size(115, 44);
            this.btn_dgvguncelle.TabIndex = 6;
            this.btn_dgvguncelle.Text = "Tabloyu Yenile";
            this.btn_dgvguncelle.UseVisualStyleBackColor = true;
            // 
            // dgv_satisgecmisi
            // 
            this.dgv_satisgecmisi.AllowUserToAddRows = false;
            this.dgv_satisgecmisi.AllowUserToDeleteRows = false;
            this.dgv_satisgecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_satisgecmisi.Location = new System.Drawing.Point(0, 0);
            this.dgv_satisgecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_satisgecmisi.Name = "dgv_satisgecmisi";
            this.dgv_satisgecmisi.ReadOnly = true;
            this.dgv_satisgecmisi.RowHeadersWidth = 51;
            this.dgv_satisgecmisi.RowTemplate.Height = 24;
            this.dgv_satisgecmisi.Size = new System.Drawing.Size(1148, 460);
            this.dgv_satisgecmisi.TabIndex = 4;
            this.dgv_satisgecmisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_satisgecmisi_CellContentClick);
            // 
            // btn_islem_sil
            // 
            this.btn_islem_sil.FlatAppearance.BorderSize = 0;
            this.btn_islem_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_islem_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_islem_sil.Image")));
            this.btn_islem_sil.Location = new System.Drawing.Point(1154, 230);
            this.btn_islem_sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_islem_sil.Name = "btn_islem_sil";
            this.btn_islem_sil.Size = new System.Drawing.Size(119, 230);
            this.btn_islem_sil.TabIndex = 5;
            this.btn_islem_sil.UseVisualStyleBackColor = true;
            this.btn_islem_sil.Click += new System.EventHandler(this.btn_islem_sil_Click);
            // 
            // tp_alisgecmisi
            // 
            this.tp_alisgecmisi.Controls.Add(this.button5);
            this.tp_alisgecmisi.Controls.Add(this.button8);
            this.tp_alisgecmisi.Controls.Add(this.dgv_alisGecmisi);
            this.tp_alisgecmisi.Location = new System.Drawing.Point(4, 25);
            this.tp_alisgecmisi.Margin = new System.Windows.Forms.Padding(4);
            this.tp_alisgecmisi.Name = "tp_alisgecmisi";
            this.tp_alisgecmisi.Size = new System.Drawing.Size(1304, 550);
            this.tp_alisgecmisi.TabIndex = 3;
            this.tp_alisgecmisi.Text = "Alış Geçmişi";
            this.tp_alisgecmisi.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1154, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 230);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1154, 230);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 230);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgv_alisGecmisi
            // 
            this.dgv_alisGecmisi.AllowUserToAddRows = false;
            this.dgv_alisGecmisi.AllowUserToDeleteRows = false;
            this.dgv_alisGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alisGecmisi.Location = new System.Drawing.Point(0, 0);
            this.dgv_alisGecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_alisGecmisi.Name = "dgv_alisGecmisi";
            this.dgv_alisGecmisi.ReadOnly = true;
            this.dgv_alisGecmisi.RowHeadersWidth = 51;
            this.dgv_alisGecmisi.RowTemplate.Height = 24;
            this.dgv_alisGecmisi.Size = new System.Drawing.Size(1148, 460);
            this.dgv_alisGecmisi.TabIndex = 13;
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 498);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_panel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_anasayfa.ResumeLayout(false);
            this.tp_anasayfa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp_kullaniciListesi.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanicilar)).EndInit();
            this.tp_satisgecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satisgecmisi)).EndInit();
            this.tp_alisgecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisGecmisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AP_cıkıs_btn;
        private System.Windows.Forms.Label AP_kullanici;
        private System.Windows.Forms.Button TESTMODE_EXITALLPANEL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_kullaniciListesi;
        private System.Windows.Forms.TabPage tp_satisgecmisi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_yeni_kullanici;
        public System.Windows.Forms.ComboBox combobox_yeni_kullanici_yetki;
        private System.Windows.Forms.TextBox txtbox_yeni_kullanici_sifre;
        private System.Windows.Forms.TextBox txtbox_yeni_kullanici_adı;
        private System.Windows.Forms.DataGridView dgv_kullanicilar;
        private System.Windows.Forms.Button btn_kullanici_listele;
        private System.Windows.Forms.Button btn_dgvguncelle;
        private System.Windows.Forms.Button btn_islem_sil;
        private System.Windows.Forms.DataGridView dgv_satisgecmisi;
        private System.Windows.Forms.TabPage tp_anasayfa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_yenifiyat;
        private System.Windows.Forms.ComboBox combobox_yakit_turu;
        private System.Windows.Forms.Button btn_fiyatGuncelle;
        private System.Windows.Forms.ListBox listbox_fiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar PB_benzin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DepoLPGMiktari;
        private System.Windows.Forms.ProgressBar PB_dizel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar PB_lpg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_DepoBenzinMiktari;
        private System.Windows.Forms.Label lbl_DepoDizelMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_alisgecmisi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgv_alisGecmisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbox_personelIletisim;
        private System.Windows.Forms.TextBox txtbox_personelTc;
        private System.Windows.Forms.TextBox txtbox_personelAdi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
    }
}