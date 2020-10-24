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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Payment = new Form6();
            Payment.Show();  
        
            }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Pharmacy = new Form5();
            Pharmacy.Show();
            
        }

        private void btnPharmacy_Office_Click(object sender, EventArgs e)
        {
            Pharmacy_Office Pharmacy_Office = new Pharmacy_Office();
            Pharmacy_Office.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;


            iExit = MessageBox.Show("Confirm If you want to Exit", "Pharmacy Management System",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (iExit == DialogResult.Yes )
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 patient = new Form4();
            patient.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pharmacy_Office Pharmacy_Office = new Pharmacy_Office();
            Pharmacy_Office.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form5 Pharmacy = new Form5();
            Pharmacy.Show();
            }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 Payment = new Form6();
            Payment.Show();
            
        }

    }
}
