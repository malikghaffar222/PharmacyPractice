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
    public partial class Pharmacy_Office : Form
    {
        public Pharmacy_Office()
        {
            InitializeComponent();
        }

        private void Pharmacy_Office_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
            this.pharmacy_OfficeTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Pharmacy_Office);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.AddNew();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacy_OfficeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Pharmacy_Office_Report pr = new Pharmacy_Office_Report();
            pr.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit patient's report ", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
