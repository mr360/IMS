using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.User;

namespace IMS_GUI
{
    public partial class CreateCustomerForm : Form
    {
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AccountingInstanceForm.newCustomer = new Customer(txtId.Text, txtName.Text, txtAddress.Text);
            this.Hide();
        }
    }
}
