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
using IMS;

namespace IMS_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Program.staffAccount = Program.um.Retrieve(txtUsername.Text) as Staff;
           if (Program.staffAccount != null)
           {
                this.Hide();
                switch (Program.staffAccount.Role)
                {
                    case JobRole.Accounting:
                        AccountingInstanceForm aInstanceForm = new AccountingInstanceForm();
                        aInstanceForm.ShowDialog();
                        break;
                    case JobRole.Sale:
                        SaleInstanceForm sInstanceForm = new SaleInstanceForm();
                        sInstanceForm.ShowDialog();
                        break;
                    case JobRole.Garage:
                        GarageInstanceForm gInstanceForm = new GarageInstanceForm();
                        gInstanceForm.ShowDialog();
                        break;
                    case JobRole.Management:
                        ReportInstanceForm rInstanceForm = new ReportInstanceForm();
                        rInstanceForm.ShowDialog();
                        break;
                    default:
                        throw new ArgumentException("Unknown user! Unknown instance to create!");
                }
                
           }
           else
           {
                MessageBox.Show("The user account does not exist.", "Unknown User", MessageBoxButtons.OK);
            }
            
        }
    }
}
