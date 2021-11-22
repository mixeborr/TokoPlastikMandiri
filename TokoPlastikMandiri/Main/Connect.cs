using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TokoPlastikMandiri.Main
{
    public class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mGxFox\source\repos\TokoPlastikMandiri\TokoPlastikMandiri\Database.mdf;Integrated Security=True";
    }
}
