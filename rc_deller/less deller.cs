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

namespace rc_deller
{
    public partial class less_deller : Form
    {
        public less_deller()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
