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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void doctorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void doctorBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Doctor);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iexit;


            iexit = MessageBox.Show("Confirm if you want to exit doctor's report ", "Pharmacy Management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Doctor_Report doctor = new Doctor_Report();
            doctor.Show(); 
        }

        private void doctor_s_NHS_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void medical_Center_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void address_of_CenterLabel_Click(object sender, EventArgs e)
        {

        }

        private void doctor_s_Ref_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void office_Phone_No_1Label_Click(object sender, EventArgs e)
        {

        }

        private void office_Phone_No_2Label_Click(object sender, EventArgs e)
        {

        }

        private void fax_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void patient_NHS_NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void eMIS_NumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
