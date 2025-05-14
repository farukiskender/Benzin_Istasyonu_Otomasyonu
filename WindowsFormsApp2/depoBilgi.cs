using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class depoBilgi
    {
        public static void DepoDurumuGetir(out decimal D_benzin, out decimal D_dizel, out decimal D_lpg)
        {
            D_benzin = 0;
            D_dizel = 0;
            D_lpg = 0;

            string query = "SELECT yakit_miktari FROM depo WHERE ID IN (1, 2, 3)";

            using (SqlConnection connection = sqlbaglanti.BaglantiGetir())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                D_benzin = reader.GetDecimal(0);
                                Console.WriteLine($"D_benzin: {D_benzin}");

                                if (reader.Read())
                                {
                                    D_dizel = reader.GetDecimal(0);
                                    Console.WriteLine($"D_dizel: {D_dizel}");

                                    if (reader.Read())
                                    {
                                        D_lpg = reader.GetDecimal(0);
                                        Console.WriteLine($"D_lpg: {D_lpg}");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Veri bulunamadı!");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
