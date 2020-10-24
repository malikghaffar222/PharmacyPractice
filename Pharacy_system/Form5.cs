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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Payment);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.AddNew();
        }

        private void btnPervious_Click(object sender, EventArgs e)
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
