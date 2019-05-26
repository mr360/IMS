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
using IMS.User;
using System.Drawing.Printing;

namespace IMS_GUI
{
    public partial class AccountingInstanceForm : Form
    {
        AccountingInstance aInstance = new AccountingInstance(Program.staffAccount, Program.im, Program.um, Program.vm);
        public static Customer newCustomer = null;

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

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();
            createCustomerForm.ShowDialog();

            string msg = aInstance.CreateCustomer(newCustomer);
            MessageBox.Show(msg, "Customer", MessageBoxButtons.OK);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(xDoc);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void xDoc(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtInvoiceView.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20);
        }
    }
}
