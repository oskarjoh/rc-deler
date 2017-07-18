using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rc_deller
{

    public class sql
    {
        public void Sql()
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=[192.168.0.106];Database=[rc-deler];Trusted_Connection=true";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM rom", conn);

            }
        }
    }
}
