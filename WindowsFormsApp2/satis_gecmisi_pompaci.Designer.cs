namespace WindowsFormsApp2
{
    partial class satis_gecmisi_pompaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis_gecmisi_pompaci));
            this.dgv_pompaciislemgecmisi = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_satisgecmisikapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pompaciislemgecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pompaciislemgecmisi
            // 
            this.dgv_pompaciislemgecmisi.AllowUserToAddRows = false;
            this.dgv_pompaciislemgecmisi.AllowUserToDeleteRows = false;
            this.dgv_pompaciislemgecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pompaciislemgecmisi.Location = new System.Drawing.Point(2, 1);
            this.dgv_pompaciislemgecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_pompaciislemgecmisi.Name = "dgv_pompaciislemgecmisi";
            this.dgv_pompaciislemgecmisi.ReadOnly = true;
            this.dgv_pompaciislemgecmisi.RowHeadersVisible = false;
            this.dgv_pompaciislemgecmisi.RowHeadersWidth = 51;
            this.dgv_pompaciislemgecmisi.RowTemplate.Height = 24;
            this.dgv_pompaciislemgecmisi.Size = new System.Drawing.Size(937, 540);
            this.dgv_pompaciislemgecmisi.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1045, 522);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 14);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_satisgecmisikapat
            // 
            this.btn_satisgecmisikapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_satisgecmisikapat.FlatAppearance.BorderSize = 0;
            this.btn_satisgecmisikapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satisgecmisikapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_satisgecmisikapat.Image")));
            this.btn_satisgecmisikapat.Location = new System.Drawing.Point(947, 1);
            this.btn_satisgecmisikapat.Name = "btn_satisgecmisikapat";
            this.btn_satisgecmisikapat.Size = new System.Drawing.Size(119, 540);
            this.btn_satisgecmisikapat.TabIndex = 16;
            this.btn_satisgecmisikapat.UseVisualStyleBackColor = false;
            this.btn_satisgecmisikapat.Click += new System.EventHandler(this.btn_satisgecmisikapat_Click);
            // 
            // satis_gecmisi_pompaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 547);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_satisgecmisikapat);
            this.Controls.Add(this.dgv_pompaciislemgecmisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "satis_gecmisi_pompaci";
            this.Text = "İşlem Geçmişi";
            this.Load += new System.EventHandler(this.satis_gecmisi_pompaci_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pompaciislemgecmisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_pompaciislemgecmisi;
        private System.Windows.Forms.Button btn_satisgecmisikapat;
        private System.Windows.Forms.Button button5;
    }
}