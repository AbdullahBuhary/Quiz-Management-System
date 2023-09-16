using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Management
{
    internal class function
    {
        protected SqlConnection getConnectionString()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True";
            return con;
            
        }

        
    }
}
