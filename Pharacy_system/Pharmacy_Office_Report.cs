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
    public partial class Pharmacy_Office_Report : Form
    {
        public Pharmacy_Office_Report()
        {
            InitializeComponent();
        }

        private void Pharmacy_Office_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_Manageent_SystemDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
            this.pharmacy_OfficeTableAdapter.Fill(this.pharmacy_Manageent_SystemDataSet.Pharmacy_Office);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.MoveNext();
        }

        private void btnPervious_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacy_OfficeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_Manageent_SystemDataSet);
        }
    }
}
