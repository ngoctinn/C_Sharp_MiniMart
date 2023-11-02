using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Models
{
    public class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=NGOCTIN;Initial Catalog=MiniMart;User ID=sa;Password=ngoctin123");
        }
    }
}
