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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Patient);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Patient_Report pt = new Patient_Report();
            pt.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit patient's report ", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
