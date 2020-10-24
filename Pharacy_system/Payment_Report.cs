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
    public partial class Payment_Report : Form
    {
        public Payment_Report()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);

        }

        private void Payment_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Payment);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.MoveNext();
        }

        private void btnPervious_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);
         }
    }
}
