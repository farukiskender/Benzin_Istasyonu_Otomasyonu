using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class sqlbaglanti
    {
        public static SqlConnection BaglantiGetir()
        {
            return new SqlConnection($@"Data Source=195.142.166.165;Initial Catalog=gasstation;User ID=faruk;Password=faruk.1234;Encrypt=True;TrustServerCertificate=True");
        }
    }
}
