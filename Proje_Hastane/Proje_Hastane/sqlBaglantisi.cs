using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {

        public SqlConnection baglantiFunc()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-GHP8JEF;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True");
            connect.Open();
            return connect;
        }
    }
}
