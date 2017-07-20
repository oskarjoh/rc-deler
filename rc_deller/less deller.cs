using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rc_deller
{
    public partial class less_deller : Form
    {
        public less_deller()
        {
            InitializeComponent();
            //mysql();
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

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=192.168.0.106;uid=add_rc;" +
                "pwd=KGSoa5kG-jL1;database=rc-deler;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
