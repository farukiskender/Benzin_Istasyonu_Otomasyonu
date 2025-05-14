using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class admin_panel : Form
    {
        public admin_panel(string kullaniciAdi)
        {
            InitializeComponent();
            AP_kullanici.Text = kullaniciAdi;
        }
        decimal benzin_fiyat=0, dizel_fiyat = 0, lpg_fiyat = 0;
        private void admin_panel_Load(object sender, EventArgs e)
        {
            listbox_guncelle();
            dgv_satis_gecmisi_guncelle();
            dgv_alis_gecmisi_guncelle();
            btn_depoGuncelle_Click(sender, e);
            dgv_kullanici_guncelle();
            button1_Click(sender,e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }

        private void TESTMODE_EXITALLPANEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kullanici_listele_Click(object sender, EventArgs e)
        {
            dgv_kullanici_guncelle();
        }
        private void btn_kullanici_sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int secilenSatir = dgv_kullanicilar.CurrentCell.RowIndex;

                int kullaniciID = Convert.ToInt32(dgv_kullanicilar.Rows[secilenSatir].Cells["ID"].Value);

                using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM users WHERE ID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", kullaniciID);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kullanıcı silindi.");

                                dgv_kullanicilar.Rows.RemoveAt(secilenSatir);
                            }
                            else
                            {
                                MessageBox.Show("Silme başarısız.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                dgv_kullanici_guncelle();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }
        }
        public void btn_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istediğinize emin misiniz?", "Değişiklik Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE users SET username = @username, userpassword = @userpassword, userauthorization = @userauthorization ,personelAdi=@personelAdi,personelTc=@personelTc,personelIletisim=@personelIletisim WHERE ID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", Convert.ToInt32(dgv_kullanicilar.CurrentCell.RowIndex + 1));
                            command.Parameters.AddWithValue("@username", txtbox_yeni_kullanici_adı.Text);
                            command.Parameters.AddWithValue("@userpassword", txtbox_yeni_kullanici_sifre.Text);
                            command.Parameters.AddWithValue("@userauthorization", combobox_yeni_kullanici_yetki.Text);
                            command.Parameters.AddWithValue("@personelAdi", txtbox_personelAdi.Text);
                            command.Parameters.AddWithValue("@personelTc", txtbox_personelTc.Text);
                            command.Parameters.AddWithValue("@personelIletisim", txtbox_personelIletisim.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgv_kullanici_guncelle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void btn_yeni_kullanici_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kullanıcıyı eklemek istediğinize emin misiniz?", "Kullanıcı ekleme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO users (username, userpassword, userauthorization, personelAdi,personelTc,personelIletisim) VALUES (@username, @userpassword, @userauthorization,@personelAdi,@personelTc,@personelIletisim)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", txtbox_yeni_kullanici_adı.Text);
                            command.Parameters.AddWithValue("@userpassword", txtbox_yeni_kullanici_sifre.Text);
                            command.Parameters.AddWithValue("@userauthorization", combobox_yeni_kullanici_yetki.Text);
                            command.Parameters.AddWithValue("@personelADi", txtbox_personelAdi.Text);
                            command.Parameters.AddWithValue("@personelTc", txtbox_personelTc.Text);
                            command.Parameters.AddWithValue("@personelIletisim", txtbox_personelIletisim.Text);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Yeni Kullanıcı Başarıyla Eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                MessageBox.Show("Veri Kaydedilemedi", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                dgv_kullanici_guncelle();
                txtbox_yeni_kullanici_adı.Clear();
                txtbox_yeni_kullanici_sifre.Clear();
                combobox_yeni_kullanici_yetki.Text = " ";
                txtbox_personelAdi.Clear();
                txtbox_personelTc.Clear();
                txtbox_personelIletisim.Clear();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }
        private void dgv_kullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dgv_kullanicilar.CurrentCell.RowIndex;
            txtbox_yeni_kullanici_adı.Text = dgv_kullanicilar.Rows[secilenSatir].Cells["username"].Value.ToString();
            txtbox_yeni_kullanici_sifre.Text = dgv_kullanicilar.Rows[secilenSatir].Cells["userpassword"].Value.ToString();
            combobox_yeni_kullanici_yetki.SelectedItem = dgv_kullanicilar.Rows[secilenSatir].Cells["userauthorization"].Value.ToString().Trim();
            txtbox_personelAdi.Text = dgv_kullanicilar.Rows[secilenSatir].Cells["personelAdi"].Value.ToString();
            txtbox_personelTc.Text = dgv_kullanicilar.Rows[secilenSatir].Cells["personelTc"].Value.ToString();
            txtbox_personelIletisim.Text = dgv_kullanicilar.Rows[secilenSatir].Cells["personelIletisim"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_satis_gecmisi_guncelle();
        }

        public void dgv_satis_gecmisi_guncelle()
        {
            string query = "SELECT ID, tarih_saat, plaka, yakit_turu,birim_fiyati, yakit_miktari, toplam_tutar, odeme_yontemi, kasiyer FROM satis_gecmisi";
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
                    dgv_satisgecmisi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btn_islem_sil_Click(object sender, EventArgs e)
        {
            decimal D_benzin = 0, D_dizel = 0, D_lpg = 0;
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int secilenSatir = dgv_satisgecmisi.CurrentCell.RowIndex;
                    int islemID = Convert.ToInt32(dgv_satisgecmisi.Rows[secilenSatir].Cells["ID"].Value);
                    DialogResult sonuc2 = MessageBox.Show("Siilinen işleme ait yakıt miktari depoya geri aktarılsınmı?!", "Yakıt Aktarım Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc2 == DialogResult.Yes)
                    {
                        decimal silinenIslem_yakitMiktari = Convert.ToDecimal(dgv_satisgecmisi.CurrentRow.Cells["yakit_miktari"].Value);
                        string silinenIslem_yakitTuru = dgv_satisgecmisi.CurrentRow.Cells["yakit_turu"].Value.ToString();
                        depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);

                        if (silinenIslem_yakitTuru == "Benzin    ")
                        {
                            D_benzin += silinenIslem_yakitMiktari;
                        }
                        if (silinenIslem_yakitTuru == "Dizel     ")
                        {
                            D_dizel += silinenIslem_yakitMiktari;
                        }
                        if (silinenIslem_yakitTuru == "LPG       ")
                        {
                            D_lpg += silinenIslem_yakitMiktari;
                        }
                        string query3 = "UPDATE depo SET yakit_miktari = @yakit_benzin WHERE ID = 1;" +"UPDATE depo SET yakit_miktari = @yakit_dizel WHERE ID = 2;" +"UPDATE depo SET yakit_miktari = @yakit_lpg WHERE ID = 3;";
                        using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand(query3, connection))
                            {
                                cmd.Parameters.AddWithValue("@yakit_benzin", D_benzin);
                                cmd.Parameters.AddWithValue("@yakit_dizel", D_dizel);
                                cmd.Parameters.AddWithValue("@yakit_lpg", D_lpg);

                                int rowsAffected = cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    if (sonuc2 == DialogResult.No)
                    {

                    }
                    using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM satis_gecmisi WHERE ID = @ID";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID", islemID);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Seçili işlem silindi.");

                                    dgv_satisgecmisi.Rows.RemoveAt(secilenSatir);
                                }
                                else
                                {
                                    MessageBox.Show("Silme işlemi başarısız.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            dgv_alis_gecmisi_guncelle();
            btn_depoGuncelle_Click(sender, e);
        }

        // FONKSİYONLAR
        decimal D_benzin,D_dizel, D_lpg;
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
            listbox_fiyat.Items.Clear();
            listbox_fiyat.Items.Add("     Fiyat Litesi");
            listbox_fiyat.Items.Add("Benzin     " + benzin_fiyat + "₺");
            listbox_fiyat.Items.Add("Dizel        " + dizel_fiyat + "₺");
            listbox_fiyat.Items.Add("LPG         " + lpg_fiyat + "₺");
        }

        public void dgv_kullanici_guncelle()
        {
            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {

                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgv_kullanicilar.DataSource = dataTable;
                    dgv_kullanicilar.Columns["ID"].Visible = false;

                    dgv_kullanicilar.ReadOnly = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void btn_fiyatGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Fiyatı güncellemek istediğinize emin misiniz?", "Fiyat Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (combobox_yakit_turu.Text == " ")
                {
                    MessageBox.Show("Lütfen yakıt türünü seçiniz.");
                    return;
                }
                if (txtbox_yenifiyat.Text == " ")
                {
                    MessageBox.Show("Lütfen yeni fiyatı giriniz.");
                    return;
                }
                if (decimal.TryParse(txtbox_yenifiyat.Text, out decimal sayi))
                {

                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (combobox_yakit_turu.Text == "Benzin")
                {
                    benzin_fiyat = Convert.ToDecimal(txtbox_yenifiyat.Text);
                }
                if (combobox_yakit_turu.Text == "Dizel")
                {
                    dizel_fiyat = Convert.ToDecimal(txtbox_yenifiyat.Text);
                }
                if (combobox_yakit_turu.Text == "LPG")
                {
                    lpg_fiyat = Convert.ToDecimal(txtbox_yenifiyat.Text);
                }

                string yenifiyatgonder = "UPDATE depo SET yakit_fiyati = @fiyat_benzin WHERE ID = 1;" +
                           "UPDATE depo SET yakit_fiyati = @fiyat_dizel WHERE ID = 2;" +
                           "UPDATE depo SET yakit_fiyati = @fiyat_lpg WHERE ID = 3;";

                using (SqlConnection conn = sqlbaglanti.BaglantiGetir())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(yenifiyatgonder, conn))
                    {
                        cmd.Parameters.AddWithValue("@fiyat_benzin", benzin_fiyat);
                        cmd.Parameters.AddWithValue("@fiyat_dizel", dizel_fiyat);
                        cmd.Parameters.AddWithValue("@fiyat_lpg", lpg_fiyat);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fiyat Güncelleme Tamamlandı.");
                        }
                        else
                        {
                            MessageBox.Show("Fiyat Güncelleme Başarısız.");
                        }
                    }
                }
                txtbox_yenifiyat.Text = " ";
                combobox_yakit_turu.Text = " ";
                listbox_guncelle();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Fiyat güncelleme işlemi iptal edildi.");
            }
        }

        private void btn_depoGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_alis_gecmisi_guncelle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal D_benzin = 0, D_dizel = 0, D_lpg = 0;
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int secilenSatir = dgv_alisGecmisi.CurrentCell.RowIndex;

                    int islemID = Convert.ToInt32(dgv_alisGecmisi.Rows[secilenSatir].Cells["ID"].Value);

                 

                    DialogResult sonuc2 = MessageBox.Show("Siilinen işleme ait yakıt miktari depodan çıkartılsınmı!", "Yakıt Aktarım Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc2 == DialogResult.Yes)
                    {
                        decimal silinenIslem_yakitMiktari = Convert.ToDecimal(dgv_alisGecmisi.CurrentRow.Cells["yakitMiktari"].Value);
                        string silinenIslem_yakitTuru = dgv_alisGecmisi.CurrentRow.Cells["yakitTuru"].Value.ToString();

                        depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);

                        if (silinenIslem_yakitTuru == "Benzin    ")
                        {
                            D_benzin -= silinenIslem_yakitMiktari;
                        }
                        if (silinenIslem_yakitTuru == "Dizel     ")
                        {
                            D_dizel -= silinenIslem_yakitMiktari;
                        }
                        if (silinenIslem_yakitTuru == "LPG       ")
                        {
                            D_lpg -= silinenIslem_yakitMiktari;
                        }

                        string query3 = "UPDATE depo SET yakit_miktari = @yakit_benzin WHERE ID = 1;" + "UPDATE depo SET yakit_miktari = @yakit_dizel WHERE ID = 2;" + "UPDATE depo SET yakit_miktari = @yakit_lpg WHERE ID = 3;";

                        using (SqlConnection conn = sqlbaglanti.BaglantiGetir())
                        {
                            conn.Open();

                            using (SqlCommand cmd = new SqlCommand(query3, conn))
                            {
                                cmd.Parameters.AddWithValue("@yakit_benzin", D_benzin);
                                cmd.Parameters.AddWithValue("@yakit_dizel", D_dizel);
                                cmd.Parameters.AddWithValue("@yakit_lpg", D_lpg);

                                int rowsAffected = cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    if (sonuc2 == DialogResult.No)
                    {

                    }

                    using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM alis_gecmisi WHERE ID = @ID";



                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID", islemID);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Seçili işlem silindi.");

                                    dgv_alisGecmisi.Rows.RemoveAt(secilenSatir);
                                }
                                else
                                {
                                    MessageBox.Show("Silme işlemi başarısız.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            dgv_alis_gecmisi_guncelle();
            btn_depoGuncelle_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            depoBilgi.DepoDurumuGetir(out D_benzin, out D_dizel, out D_lpg);

            PB_benzin.Value = Convert.ToInt32(D_benzin);
            lbl_DepoBenzinMiktari.Text = Convert.ToString(D_benzin);
            PB_dizel.Value = Convert.ToInt32(D_dizel);
            lbl_DepoDizelMiktari.Text = Convert.ToString(D_dizel);
            PB_lpg.Value = Convert.ToInt32(D_lpg);
            lbl_DepoLPGMiktari.Text = Convert.ToString(D_lpg);
        }

        private void txtbox_personelTc_TextChanged(object sender, EventArgs e)
        {
            if(txtbox_personelTc.Text.Length > 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                txtbox_personelTc.Text = txtbox_personelTc.Text.Substring(0, 11);
            }
        }
        private void txtbox_personelTc_Validate(object sender, EventArgs e)
        {
            if (txtbox_personelTc.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                txtbox_personelTc.Focus();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }

        private void dgv_satisgecmisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpanel = new Login();
            loginpanel.Show();
        }

        public void dgv_alis_gecmisi_guncelle()
        {
            string query = "SELECT ID, tarih_saat,islemOncesiDepoMiktari,yakitTuru,birimFiyati,yakitMiktari,toplamFiyat,yetkili FROM alis_gecmisi";

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
            }
        }
    }
}