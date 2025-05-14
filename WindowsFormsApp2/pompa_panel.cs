using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Numerics;
using System.Collections;
namespace WindowsFormsApp2
{
    public partial class pompa_panel : Form
    {
        public pompa_panel(string kullaniciAdi)
        {
            InitializeComponent();
            PP_kullanici.Text = kullaniciAdi;

        }

        private void pompa_panel_Load(object sender, EventArgs e)
        {
            listbox_guncelle();
            listbox_depodurumguncelleme(D_benzin, D_dizel, D_lpg);
        }
        decimal litrefiyati;

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }
        decimal yakitmiktari;
        private void yakit_miktari_TextChanged(object sender, EventArgs e)
        {
            decimal yakitMiktari;
            if (decimal.TryParse(txtbox_yakit_miktari.Text, out yakitMiktari))
            {
                yakitmiktari = Convert.ToDecimal(txtbox_yakit_miktari.Text);
                verigüncelleme();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yakıt miktarı giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        decimal benzin_fiyat = 0;
        decimal dizel_fiyat = 0;
        decimal lpg_fiyat = 0;
        private void lstbox_fiyat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void yakit_turu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combobox_yakit_turu.Text)
            {
                case "Benzin":
                    litrefiyati = benzin_fiyat;
                    break;
                case "Dizel":
                    litrefiyati = dizel_fiyat;
                    break;
                case "LPG":
                    litrefiyati = lpg_fiyat;
                    break;
            }
            verigüncelleme();
        }
        
        

        private void btn_doldur_Click(object sender, EventArgs e)
        {
            decimal D_benzin = 0, D_dizel = 0, D_lpg = 0;
            if (combobox_yakit_turu == null)
            {
                MessageBox.Show("Lütfen Geçerli Bir Yakıt Türü Seçiniz", "Eksik Veya Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtbox_arac_plakasi==null)
            {
                MessageBox.Show("Lütfen Geçerli Bir Araç Plakası Giriniz", "Eksik Veya Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radbtn_nakit.Checked == true)
            {
                lbl_odeme_turu.Text = "Nakit";
            }
            else if (radbtn_kredi_karti.Checked == true)
            {
                lbl_odeme_turu.Text = "KrediKartı";
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Ödeme Türü Seçiniz", "Eksik Veya Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);

            if (combobox_yakit_turu.Text=="Benzin")
            {
                if (D_benzin - yakitmiktari < 0)
                {
                    MessageBox.Show("Benzin Depoda Yeterli Yakıt Yok!\n" + "Benzin Depo: " + D_benzin + "Lt");
                }
                else
                {
                    D_benzin -= Convert.ToDecimal(txtbox_yakit_miktari.Text);
                    yakitDoldur(D_benzin,D_dizel,D_lpg);
                }
            }
            if (combobox_yakit_turu.Text=="Dizel")
            {
                if (D_dizel - yakitmiktari < 0)
                {
                    MessageBox.Show("Dizel Depoda Yeterli Yakıt Yok!\n" + "Dizel Depo: " + D_dizel + "Lt");
                }
                else
                {
                    D_dizel -= Convert.ToDecimal(txtbox_yakit_miktari.Text);
                    yakitDoldur(D_benzin, D_dizel, D_lpg);
                }
            }
            if (combobox_yakit_turu.Text == "LPG")
            {
                if (D_lpg - yakitmiktari < 0)
                {
                    MessageBox.Show("LPG Depoda Yeterli Yakıt Yok!\n" + "LPG Depo: " + D_lpg + "Lt");
                }
                else
                {
                    D_lpg -= Convert.ToDecimal(txtbox_yakit_miktari.Text);
                    yakitDoldur(D_benzin, D_dizel, D_lpg);
                }
            }
            listbox_depodurumguncelleme(D_benzin,D_dizel,D_lpg);
        }



        private void arac_plakasi_TextChanged(object sender, EventArgs e)
        {
            verigüncelleme();
        }

        private void btn_yeni_islem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pompa_panel pompaPanel = new pompa_panel(PP_kullanici.Text);
            pompaPanel.Show();
        }

        private void radbtn_nakit_CheckedChanged(object sender, EventArgs e)
        {
            verigüncelleme();
        }

        private void radbtn_kredi_karti_CheckedChanged(object sender, EventArgs e)
        {
            verigüncelleme();
        }
        decimal D_benzin, D_dizel, D_lpg;


        public void depomiktaral()
        {
            depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);
        }

        //FONKSİYONLAR
        public void yakitDoldur(decimal D_benzin,decimal D_dizel,decimal D_lpg)
        {
            string verigonder = "UPDATE depo SET yakit_miktari = @yakit_benzin WHERE ID = 1;" +
           "UPDATE depo SET yakit_miktari = @yakit_dizel WHERE ID = 2;" +
           "UPDATE depo SET yakit_miktari = @yakit_lpg WHERE ID = 3;";

            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(verigonder, connection))
                {
                    cmd.Parameters.AddWithValue("@yakit_benzin", D_benzin);
                    cmd.Parameters.AddWithValue("@yakit_dizel", D_dizel);
                    cmd.Parameters.AddWithValue("@yakit_lpg", D_lpg);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                try
                {
                    connection.Open();
                    string islemverisigonder = "INSERT INTO satis_gecmisi (plaka, yakit_turu, birim_fiyati, yakit_miktari, kasiyer,toplam_tutar,odeme_yontemi) VALUES (@plaka, @yakit_turu, @birim_fiyati, @yakit_miktari, @kullaniciAdi,@toplam_tutar,@odeme_yontemi)";

                    using (SqlCommand command = new SqlCommand(islemverisigonder, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", txtbox_arac_plakasi.Text.ToUpper().Trim());
                        command.Parameters.AddWithValue("@yakit_turu", combobox_yakit_turu.Text);
                        command.Parameters.AddWithValue("@birim_fiyati", Convert.ToDecimal(litrefiyati));
                        command.Parameters.AddWithValue("@yakit_miktari", Convert.ToDecimal(txtbox_yakit_miktari.Text));
                        command.Parameters.AddWithValue("@kullaniciAdi", PP_kullanici.Text);
                        command.Parameters.AddWithValue("@toplam_tutar", lbl_toptutar.Text);
                        command.Parameters.AddWithValue("@odeme_yontemi", lbl_odeme_turu.Text);


                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("İşlem başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            MessageBox.Show("Veri Kaydedilemedi", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            this.Hide();
            pompa_panel pompaPanel = new pompa_panel(PP_kullanici.Text);
            pompaPanel.Show();
        }

        public void listbox_guncelle()
        {
            string fiyatal = "SELECT yakit_fiyati FROM depo WHERE ID IN (1, 2, 3)";

            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(fiyatal, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                benzin_fiyat = reader.GetDecimal(0);
                                Console.WriteLine($"benzin_fiyat: {benzin_fiyat}");

                                if (reader.Read())
                                {
                                    dizel_fiyat = reader.GetDecimal(0);
                                    Console.WriteLine($"dizel_fiyat: {dizel_fiyat}");

                                    if (reader.Read())
                                    {
                                        lpg_fiyat = reader.GetDecimal(0);
                                        Console.WriteLine($"dizel_fiyat: {lpg_fiyat}");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Veri bulunamadı!");
                        }
                    }
                    connection.Close();
                }
            }

            lstbox_fiyat.Items.Clear();
            lstbox_fiyat.Items.Add("     Fiyat Litesi");
            lstbox_fiyat.Items.Add("Benzin     " + benzin_fiyat + "₺");
            lstbox_fiyat.Items.Add("Dizel        " + dizel_fiyat + "₺");
            lstbox_fiyat.Items.Add("LPG         " + lpg_fiyat + "₺");
            listbox_depodurumguncelleme(D_benzin, D_dizel, D_lpg);
        }
        public void verigüncelleme()
        {
            lbl_toptutar.Text = (litrefiyati * yakitmiktari).ToString() + " TL";
            radbtnupdate();
            listbox_guncelleme(lbl_odeme_turu.Text, txtbox_yakit_miktari.Text, txtbox_arac_plakasi.Text, lbl_toptutar.Text, yakitmiktari);
        }

        public void radbtnupdate()
        {
            if (radbtn_nakit.Checked == true)
            {
                lbl_odeme_turu.Text = "Nakit";
            }
            else if (radbtn_kredi_karti.Checked == true)
            {
                lbl_odeme_turu.Text = "KrediKartı";
            }
            else
            {

            }

        }

        public void listbox_guncelleme(string odemeturu, string yakıtmiktarı, string plaka, string toplam_tutar,decimal yakitmiktari)
        {
            lstbox_islem_ozeti.Items.Clear();
            lstbox_islem_ozeti.Items.Add("İşlem Özeti");
            lstbox_islem_ozeti.Items.Add("------------------------------------------");
            lstbox_islem_ozeti.Items.Add("Yakıt Türü/LitreFiyatı: ");
            lstbox_islem_ozeti.Items.Add(combobox_yakit_turu.Text + " / " + litrefiyati+" TL");
            lstbox_islem_ozeti.Items.Add(" ");
            lstbox_islem_ozeti.Items.Add("Doldurulan Yakıt: ");
            lstbox_islem_ozeti.Items.Add(yakıtmiktarı+" LT");
            lstbox_islem_ozeti.Items.Add(" ");
            lstbox_islem_ozeti.Items.Add("Plaka: ");
            lstbox_islem_ozeti.Items.Add(plaka);
            lstbox_islem_ozeti.Items.Add(" ");
            lstbox_islem_ozeti.Items.Add("Ödeme Türü: ");
            lstbox_islem_ozeti.Items.Add(odemeturu);
            lstbox_islem_ozeti.Items.Add(" ");
            lstbox_islem_ozeti.Items.Add("Toplam Tutar: ");
            lstbox_islem_ozeti.Items.Add(toplam_tutar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satis_gecmisi_pompaci satis_Gecmisi_Pompaci = new satis_gecmisi_pompaci();
            satis_Gecmisi_Pompaci.Show();
        }

        public void listbox_depodurumguncelleme(decimal D_benzin, decimal D_dizel ,decimal D_LPG)
        {
            depomiktaral();
            listbox_depodurumu.Items.Clear();
            listbox_depodurumu.Items.Add("     Depo Durumu");
            listbox_depodurumu.Items.Add("Benzin     " + D_benzin + "Lt");
            listbox_depodurumu.Items.Add("Dizel        " + D_dizel + "Lt");
            listbox_depodurumu.Items.Add("LPG         " + D_LPG + "Lt");
        }

        private void listbox_depodurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_depodurumguncelleme(D_benzin, D_dizel, D_lpg);
        }
    }
}