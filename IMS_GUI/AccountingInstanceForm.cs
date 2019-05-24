using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS;
using IMS.Instance;

namespace IMS_GUI
{
    public partial class AccountingInstanceForm : Form
    {
        AccountingInstance aInstance = new AccountingInstance(Program.staffAccount, Program.im, Program.um, Program.vm);
        public AccountingInstanceForm()
        {
            InitializeComponent();
        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            string msg = aInstance.Invoice(txtInvoiceId.Text);
            MessageBox.Show(msg, "Invoice", MessageBoxButtons.OK);
            try
            {
                lblTotalValue.Text =  aInstance.ViewTotal.ToString();
            }
            catch
            {
                lblTotalValue.Text = "_______";
            }
        }

        private void btnGetExistingCustomer_Click(object sender, EventArgs e)
        {
            string msg = aInstance.CustomerLocate(txtCustomerExisting.Text);
            MessageBox.Show(msg, "Customer", MessageBoxButtons.OK);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CreditCard card;
            card.cardNumber = txtCardNumber.Text;
            card.cardCode = Convert.ToInt32(nudCardCode.Text);
            card.expirationDate = Convert.ToInt32(nudCardExpire.Text);

            string msg = aInstance.CreatePayment(card);
            MessageBox.Show(msg, "Invoice", MessageBoxButtons.OK);

            if (msg == "Payment Success.")
            {
                txtInvoiceView.Text = aInstance.ViewTax.Replace("\n", "\r\n");

                tabControl1.SelectTab(1);
                tabControl1.Enabled = false;
                btnPay.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
