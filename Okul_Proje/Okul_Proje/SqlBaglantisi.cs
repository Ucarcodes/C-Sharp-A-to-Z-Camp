using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Okul_Proje
{
    internal class SqlBaglantisi
    {

        public SqlConnection baglantiFunc()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-GHP8JEF;Initial Catalog=OkulProje;Integrated Security=True;TrustServerCertificate=True");
            connect.Open();
            return connect;
        }
    }
}
