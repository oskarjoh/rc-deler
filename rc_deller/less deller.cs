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
            mysql();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo1 = new Form1();
            fo1.ShowDialog();
            this.Close();
        }

        private void less_deller_Load(object sender, EventArgs e)
        {

        }
        public void mysql()
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
