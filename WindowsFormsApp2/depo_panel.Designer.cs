namespace WindowsFormsApp2
{
    partial class depo_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depo_panel));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dp_kullanici = new System.Windows.Forms.Label();
            this.txt_yakitekle = new System.Windows.Forms.TextBox();
            this.PB_benzin = new System.Windows.Forms.ProgressBar();
            this.PB_dizel = new System.Windows.Forms.ProgressBar();
            this.PB_lpg = new System.Windows.Forms.ProgressBar();
            this.lbl_DepoBenzinMiktari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_DepoDizelMiktari = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_DepoLPGMiktari = new System.Windows.Forms.Label();
            this.CB_ekleYakitTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_litrefiyati = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_alisGecmisi = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_depoGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(970, 13);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(92, 32);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.PP_cikis_btn_Click);
            // 
            // dp_kullanici
            // 
            this.dp_kullanici.AutoSize = true;
            this.dp_kullanici.Location = new System.Drawing.Point(901, 21);
            this.dp_kullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dp_kullanici.Name = "dp_kullanici";
            this.dp_kullanici.Size = new System.Drawing.Size(56, 16);
            this.dp_kullanici.TabIndex = 8;
            this.dp_kullanici.Text = "Kullanıcı";
            // 
            // txt_yakitekle
            // 
            this.txt_yakitekle.Location = new System.Drawing.Point(150, 78);
            this.txt_yakitekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_yakitekle.Name = "txt_yakitekle";
            this.txt_yakitekle.Size = new System.Drawing.Size(127, 22);
            this.txt_yakitekle.TabIndex = 13;
            this.txt_yakitekle.Text = " ";
            this.txt_yakitekle.UseWaitCursor = true;
            // 
            // PB_benzin
            // 
            this.PB_benzin.Location = new System.Drawing.Point(377, 38);
            this.PB_benzin.Margin = new System.Windows.Forms.Padding(4);
            this.PB_benzin.Maximum = 25000;
            this.PB_benzin.Name = "PB_benzin";
            this.PB_benzin.Size = new System.Drawing.Size(284, 28);
            this.PB_benzin.TabIndex = 19;
            // 
            // PB_dizel
            // 
            this.PB_dizel.Location = new System.Drawing.Point(377, 74);
            this.PB_dizel.Margin = new System.Windows.Forms.Padding(4);
            this.PB_dizel.Maximum = 40000;
            this.PB_dizel.Name = "PB_dizel";
            this.PB_dizel.Size = new System.Drawing.Size(284, 28);
            this.PB_dizel.TabIndex = 20;
            // 
            // PB_lpg
            // 
            this.PB_lpg.Location = new System.Drawing.Point(377, 109);
            this.PB_lpg.Margin = new System.Windows.Forms.Padding(4);
            this.PB_lpg.Maximum = 15000;
            this.PB_lpg.Name = "PB_lpg";
            this.PB_lpg.Size = new System.Drawing.Size(284, 29);
            this.PB_lpg.TabIndex = 21;
            // 
            // lbl_DepoBenzinMiktari
            // 
            this.lbl_DepoBenzinMiktari.AutoSize = true;
            this.lbl_DepoBenzinMiktari.Location = new System.Drawing.Point(673, 44);
            this.lbl_DepoBenzinMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoBenzinMiktari.Name = "lbl_DepoBenzinMiktari";
            this.lbl_DepoBenzinMiktari.Size = new System.Drawing.Size(14, 16);
            this.lbl_DepoBenzinMiktari.TabIndex = 22;
            this.lbl_DepoBenzinMiktari.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "25.000Lt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "40.000Lt";
            // 
            // lbl_DepoDizelMiktari
            // 
            this.lbl_DepoDizelMiktari.AutoSize = true;
            this.lbl_DepoDizelMiktari.Location = new System.Drawing.Point(670, 79);
            this.lbl_DepoDizelMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoDizelMiktari.Name = "lbl_DepoDizelMiktari";
            this.lbl_DepoDizelMiktari.Size = new System.Drawing.Size(17, 16);
            this.lbl_DepoDizelMiktari.TabIndex = 25;
            this.lbl_DepoDizelMiktari.Text = " 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "15.000Lt";
            // 
            // lbl_DepoLPGMiktari
            // 
            this.lbl_DepoLPGMiktari.AutoSize = true;
            this.lbl_DepoLPGMiktari.Location = new System.Drawing.Point(670, 113);
            this.lbl_DepoLPGMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DepoLPGMiktari.Name = "lbl_DepoLPGMiktari";
            this.lbl_DepoLPGMiktari.Size = new System.Drawing.Size(17, 16);
            this.lbl_DepoLPGMiktari.TabIndex = 28;
            this.lbl_DepoLPGMiktari.Text = " 0";
            // 
            // CB_ekleYakitTuru
            // 
            this.CB_ekleYakitTuru.FormattingEnabled = true;
            this.CB_ekleYakitTuru.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.CB_ekleYakitTuru.Location = new System.Drawing.Point(150, 40);
            this.CB_ekleYakitTuru.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ekleYakitTuru.Name = "CB_ekleYakitTuru";
            this.CB_ekleYakitTuru.Size = new System.Drawing.Size(127, 24);
            this.CB_ekleYakitTuru.TabIndex = 32;
            this.CB_ekleYakitTuru.Text = "Yakıt Türü Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Yakıt Miktari (Lt)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Birim Fiyatı";
            // 
            // txtbox_litrefiyati
            // 
            this.txtbox_litrefiyati.Location = new System.Drawing.Point(149, 114);
            this.txtbox_litrefiyati.Name = "txtbox_litrefiyati";
            this.txtbox_litrefiyati.Size = new System.Drawing.Size(127, 22);
            this.txtbox_litrefiyati.TabIndex = 34;
            this.txtbox_litrefiyati.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Lpg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Dizel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Benzin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_alisGecmisi
            // 
            this.dgv_alisGecmisi.AllowUserToAddRows = false;
            this.dgv_alisGecmisi.AllowUserToDeleteRows = false;
            this.dgv_alisGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alisGecmisi.Location = new System.Drawing.Point(35, 221);
            this.dgv_alisGecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_alisGecmisi.Name = "dgv_alisGecmisi";
            this.dgv_alisGecmisi.ReadOnly = true;
            this.dgv_alisGecmisi.RowHeadersVisible = false;
            this.dgv_alisGecmisi.RowHeadersWidth = 51;
            this.dgv_alisGecmisi.RowTemplate.Height = 24;
            this.dgv_alisGecmisi.Size = new System.Drawing.Size(929, 354);
            this.dgv_alisGecmisi.TabIndex = 38;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(970, 221);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 354);
            this.button5.TabIndex = 39;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(133, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 69);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_depoGuncelle
            // 
            this.btn_depoGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_depoGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depoGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_depoGuncelle.Image")));
            this.btn_depoGuncelle.Location = new System.Drawing.Point(428, 144);
            this.btn_depoGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_depoGuncelle.Name = "btn_depoGuncelle";
            this.btn_depoGuncelle.Size = new System.Drawing.Size(188, 69);
            this.btn_depoGuncelle.TabIndex = 16;
            this.btn_depoGuncelle.UseVisualStyleBackColor = true;
            this.btn_depoGuncelle.Click += new System.EventHandler(this.btn_depoGuncelle_Click);
            // 
            // depo_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_alisGecmisi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_litrefiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_ekleYakitTuru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_DepoLPGMiktari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_DepoDizelMiktari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_DepoBenzinMiktari);
            this.Controls.Add(this.PB_lpg);
            this.Controls.Add(this.PB_dizel);
            this.Controls.Add(this.PB_benzin);
            this.Controls.Add(this.btn_depoGuncelle);
            this.Controls.Add(this.txt_yakitekle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.dp_kullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "depo_panel";
            this.Text = "Depo Paneli";
            this.Load += new System.EventHandler(this.depo_panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label dp_kullanici;
        private System.Windows.Forms.TextBox txt_yakitekle;
        private System.Windows.Forms.Button btn_depoGuncelle;
        private System.Windows.Forms.ProgressBar PB_benzin;
        private System.Windows.Forms.ProgressBar PB_dizel;
        private System.Windows.Forms.ProgressBar PB_lpg;
        private System.Windows.Forms.Label lbl_DepoBenzinMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_DepoDizelMiktari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DepoLPGMiktari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_ekleYakitTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_litrefiyati;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_alisGecmisi;
        private System.Windows.Forms.Button button5;
    }
}