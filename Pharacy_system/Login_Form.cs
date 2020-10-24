using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharacy_system
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "malik" && txtPassword.Text == "1234")
            {
                this.Hide();
                Form1 Home = new Form1();
                Home.Show();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter the Correct Login Details", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }


    }
}
