using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class depo_panel : Form
    {

        public depo_panel(string kullaniciAdi)
        {
            InitializeComponent();
            dp_kullanici.Text = kullaniciAdi;
        }

        private void PP_cikis_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }

        decimal D_benzin, D_dizel, D_lpg;

        private void btn_depoGuncelle_Click(object sender, EventArgs e)
        {
            depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);

            PB_benzin.Value = Convert.ToInt32(D_benzin);
            lbl_DepoBenzinMiktari.Text = Convert.ToString(D_benzin);
            PB_dizel.Value = Convert.ToInt32(D_dizel);
            lbl_DepoDizelMiktari.Text = Convert.ToString(D_dizel);
            PB_lpg.Value = Convert.ToInt32(D_lpg);
            lbl_DepoLPGMiktari.Text = Convert.ToString(D_lpg);
        }
        decimal islemOncesiYakit = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_yakitekle.Text==" ")
            {
                MessageBox.Show("Lütfen geçerli bir yakıt miktari giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Convert.ToDecimal(txt_yakitekle.Text)<0)
            {
                MessageBox.Show("Lütfen geçerli bir yakıt miktari giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txtbox_litrefiyati.Text==" ")
            {
                MessageBox.Show("Lütfen Gereçli bir birim fiyatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToDecimal(txtbox_litrefiyati.Text) < 0)
            {
                MessageBox.Show("Lütfen Gereçli bir birim fiyatı giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (CB_ekleYakitTuru.Text=="Benzin")
            {
                if (D_benzin + Convert.ToDecimal(txt_yakitekle.Text) > 25000)
                {
                    MessageBox.Show("Benzin Depoda Yeterli Alan Yok !!!");
                }
                else if (Convert.ToDecimal(txt_yakitekle.Text) < 0)
                {
                    MessageBox.Show("Depodan yakıt çıkartmak için lütfen satış ekranını kullanınız!");
                }
                else
                {
                    islemOncesiYakit = D_benzin;
                    D_benzin += Convert.ToDecimal(txt_yakitekle.Text);
                    PB_benzin.Value = Convert.ToInt32(D_benzin);
                    lbl_DepoBenzinMiktari.Text = Convert.ToString(D_benzin);
                    yakıtekle();
                }
            }
            if (CB_ekleYakitTuru.Text=="Dizel")
            {
                if (Convert.ToDecimal(txt_yakitekle.Text) < 0)
                {
                    MessageBox.Show("Depodan yakıt çıkartmak için lütfen satış ekranını kullanınız!");
                }
                else if (D_dizel + Convert.ToDecimal(txt_yakitekle.Text) > 40000)
                {
                    MessageBox.Show("Dizel Depoda Yeterli Alan Yok !!!");
                }
                else
                {
                    islemOncesiYakit = D_dizel;
                    D_dizel += Convert.ToDecimal(txt_yakitekle.Text);
                    PB_dizel.Value = Convert.ToInt32(D_dizel);
                    lbl_DepoDizelMiktari.Text = Convert.ToString(D_dizel);
                    yakıtekle();
                }
            }
            if (CB_ekleYakitTuru.Text=="LPG")
            {
                if (D_lpg + Convert.ToDecimal(txt_yakitekle.Text) > 15000)
                {
                    MessageBox.Show("LPG Depoda Yeterli Alan Yok !!!");
                }
                else if (Convert.ToDecimal(txt_yakitekle.Text) < 0)
                {
                    MessageBox.Show("Depodan yakıt çıkartmak için lütfen satış ekranını kullanınız!");
                }
                else
                {
                    islemOncesiYakit = D_lpg;
                    D_lpg += Convert.ToDecimal(txt_yakitekle.Text);
                    PB_lpg.Value = Convert.ToInt32(D_lpg);
                    lbl_DepoLPGMiktari.Text = Convert.ToString(D_lpg);
                    yakıtekle();
                }
            }

            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                try
                {
                    connection.Open();
                    string islemverisigonder = "INSERT INTO alis_gecmisi (islemOncesiDepoMiktari,yakitTuru,birimFiyati,yakitMiktari,toplamFİyat,yetkili) VALUES (@islemOncesiDepoMiktari,@yakitTuru,@birimFiyati,@yakitMiktari,@toplamFİyat,@yetkili)";

                    using (SqlCommand command = new SqlCommand(islemverisigonder, connection))
                    {
                        command.Parameters.AddWithValue("@islemOncesiDepoMiktari", Convert.ToDecimal(islemOncesiYakit));
                        command.Parameters.AddWithValue("@yakitTuru", CB_ekleYakitTuru.Text);
                        command.Parameters.AddWithValue("@birimFiyati", Convert.ToDecimal(txtbox_litrefiyati.Text));
                        command.Parameters.AddWithValue("@yakitMiktari", Convert.ToDecimal(txt_yakitekle.Text));
                        command.Parameters.AddWithValue("@yetkili", dp_kullanici.Text);
                        command.Parameters.AddWithValue("@toplamFiyat", Convert.ToDecimal(txtbox_litrefiyati.Text) * Convert.ToDecimal(txt_yakitekle.Text));

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            txt_yakitekle.Text = "0";
            dgv_alis_gecmisi_guncelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_alis_gecmisi_guncelle();
        }

        private void depo_panel_Load(object sender, EventArgs e)
        {
            dgv_alis_gecmisi_guncelle();
        }


        // FONKSİYONLAR-Metotlar

        public void dgv_alis_gecmisi_guncelle()
        {
            string query = "SELECT tarih_saat,islemOncesiDepoMiktari,yakitTuru,birimFiyati,yakitMiktari,toplamFiyat,yetkili FROM alis_gecmisi";

            DataTable dt = new DataTable();

            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dgv_alisGecmisi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
                connection.Close();
            }
        }
        public void yakıtekle()
        {
            DialogResult result = MessageBox.Show(CB_ekleYakitTuru.Text + " Depoya toplam fiyatı " + (Convert.ToDecimal(txtbox_litrefiyati.Text) * Convert.ToDecimal(txt_yakitekle.Text)).ToString("0.00") + " TL olan " + txt_yakitekle.Text + " Lt yakıtın alımını onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                string yakitmikyatigonder = "UPDATE depo SET yakit_miktari = @yakit_benzin WHERE ID = 1;" +
                       "UPDATE depo SET yakit_miktari = @yakit_dizel WHERE ID = 2;" +
                       "UPDATE depo SET yakit_miktari = @yakit_lpg WHERE ID = 3;";

                using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(yakitmikyatigonder, connection))
                    {
                        cmd.Parameters.AddWithValue("@yakit_benzin", D_benzin);
                        cmd.Parameters.AddWithValue("@yakit_dizel", D_dizel);
                        cmd.Parameters.AddWithValue("@yakit_lpg", D_lpg);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doldurma İşlemi Başarılı.");
                        }
                        else
                        {
                            MessageBox.Show("Doldurma İşlemi Başarısız");
                        }
                    }

                    connection.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgi");
            }
        }
    }
}
