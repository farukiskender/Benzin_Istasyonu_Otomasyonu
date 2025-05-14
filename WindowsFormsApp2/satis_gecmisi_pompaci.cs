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
    public partial class satis_gecmisi_pompaci : Form
    {
        public satis_gecmisi_pompaci()
        {
            InitializeComponent();
        }
        private void satis_gecmisi_pompaci_Load_1(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void btn_satisgecmisikapat_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT  tarih_saat, plaka, yakit_turu,birim_fiyati, yakit_miktari, toplam_tutar, odeme_yontemi FROM satis_gecmisi";

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

                    dgv_pompaciislemgecmisi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
