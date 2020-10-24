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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gP_ApppoinmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_ApppoinmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.GP_Apppoinment' table. You can move, or remove it, as needed.
            this.gP_ApppoinmentTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.GP_Apppoinment);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.MoveNext();
        }

        private void btnPervious_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.MovePrevious();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_ApppoinmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit GP appointment report ", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.AddNew();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit doctor's report ", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            GP_Appointment_Report gp = new GP_Appointment_Report();
            gp.Show();
        }

    }
}
