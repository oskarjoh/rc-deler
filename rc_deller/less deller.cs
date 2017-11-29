using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rc_deller
{
    public partial class less_deller : Form
    {
        public less_deller()
        {
            InitializeComponent();
            mysqlstart();
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

        public void mysqlstart()
        {
            
        }
    }
}
