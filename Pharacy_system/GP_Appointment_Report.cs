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
    public partial class GP_Appointment_Report : Form
    {
        public GP_Appointment_Report()
        {
            InitializeComponent();
        }

        private void GP_Appointment_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.GP_Apppoinment' table. You can move, or remove it, as needed.
            this.gP_ApppoinmentTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.GP_Apppoinment);

        }

        private void gP_ApppoinmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_ApppoinmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.MoveNext();
        }

        private void btnPervious_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.gP_ApppoinmentBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_ApppoinmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);
        }
    }
}
