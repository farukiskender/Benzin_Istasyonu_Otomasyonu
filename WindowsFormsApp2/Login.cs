using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
    
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection sqlbaglanti = new SqlConnection($@"Data Source=195.142.166.165;Initial Catalog=gasstation;User ID=faruk;Password=faruk.1234;Encrypt=True;TrustServerCertificate=True");
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlbaglanti.Open();
                string sql = "SELECT userauthorization FROM users WHERE username=@kullanici_adi AND userpassword=@kullanici_sifresi";
                SqlCommand komut = new SqlCommand(sql, sqlbaglanti);
                komut.Parameters.AddWithValue("@kullanici_adi", textBox1.Text.Trim());
                komut.Parameters.AddWithValue("@kullanici_sifresi", textBox2.Text.Trim());
                SqlDataReader kullanıcı_dogrulama = komut.ExecuteReader();

                if (kullanıcı_dogrulama.Read()) 
                {
                    string yetki = kullanıcı_dogrulama["userauthorization"].ToString().Trim();
                    this.Hide();
                    if (yetki == "yönetici")
                    {
                        admin_panel adminpanel = new admin_panel(textBox1.Text);
                        adminpanel.Show();
                    }
                    else if (yetki == "depo")
                    {
                        depo_panel depopanel = new depo_panel(textBox1.Text);
                        depopanel.Show();
                    }
                    else if (yetki == "pompa")
                    {
                        pompa_panel pompapanel = new pompa_panel(textBox1.Text);
                        pompapanel.Show();
                    }
                    else if (yetki == "admin")
                    {
                        this.Hide();

                        admin_panel adminpanel = new admin_panel("Admin");
                        adminpanel.Show();
                        depo_panel depopanel = new depo_panel("Admin");
                        depopanel.Show();
                        pompa_panel pompapanel = new pompa_panel("Admin");
                        pompapanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yetki bulunamadı! Lütfen sistem yöneticinize danışın!");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                kullanıcı_dogrulama.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası! " + ex.Message);
            }
            finally
            {
                sqlbaglanti.Close();
            }
        }
    }
}
