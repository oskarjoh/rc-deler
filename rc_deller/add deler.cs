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
    public partial class add_deler : Form
    {
        public add_deler()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=[192.168.0.106];User id=[raspberry];Password=[raspberry];Database=[rc-deler];Trusted_Connection=true";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM rom", conn);
                conn.Close();

            }
        }
        public void progres_bar()
            {
            ProgressBar pBar1 = new ProgressBar();
            // Display the ProgressBar control.
            pBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            pBar1.Maximum = 100;
            // Set the initial value of the ProgressBar.
            pBar1.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo1 = new Form1();
            fo1.ShowDialog();
            this.Close();
        }
    }
}
