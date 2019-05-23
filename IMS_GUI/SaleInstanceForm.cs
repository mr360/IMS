using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IMS.Instance;
using IMS;

namespace IMS_GUI
{
    public partial class SaleInstanceForm : Form
    {
        SaleInstance sInstance = new SaleInstance(Program.staffAccount, Program.vm, Program.am, Program.im, Program.bm);
        public static Vehicle tradeVehicle = null;

        public SaleInstanceForm()
        {
            InitializeComponent();
        }

        private void SaleInstance_Load(object sender, EventArgs e)
        {
            // SaleInstance.ViewAllBay (do not include empty or sold)
            // Load the bay into bayid text box
            List<string> bList = sInstance.AllBays;
            foreach (string bId in bList)
            {
                cbBay.Items.Add(bId);
            }

            cbPriceRate.DataSource = Enum.GetValues(typeof(PriceRate));
        }

        private void btnVehicleSelect_Click(object sender, EventArgs e)
        {
            cblAddon.Items.Clear();

            //Load vehicle that is in bay
            if (sInstance.GetBaseVehicle(cbBay.SelectedItem as string))
            {
                tbVehicleDetails.Text = sInstance.ViewVehicle;
                dynamic aList = sInstance.AllAddons;

                foreach (Addon a in aList)
                {
                    cblAddon.Items.Add(a.Id);
                }
            }
            else
            {
                tbVehicleDetails.Text = "Empty Bay";
            }
        }

        private void btnTradeVehicleAdd_Click(object sender, EventArgs e)
        {
            CreateVehicleForm sInstanceForm = new CreateVehicleForm();
            sInstanceForm.ShowDialog();

            string msg = sInstance.GetTradeVehicle(tradeVehicle);
            if (msg == "Success.")
            {
                tbShowTradeInVehicle.Text = tradeVehicle.View;
            }
            else
            {
                MessageBox.Show(msg, "Add Trade-in Vehicle", MessageBoxButtons.OK);
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            sInstance.GetBaseVehicle(cbBay.SelectedItem as string);

            foreach (dynamic addon in cblAddon.CheckedItems)
            {
                sInstance.GetAddon(addon as string);
            }

            string msg = sInstance.CreateSale((PriceRate)cbPriceRate.SelectedItem);

            if (msg != "Missing key sales details")
            {
                tbInvoice.Text = sInstance.ViewInvoice.Replace("\n", "\r\n");
                tbcSale.SelectTab(3);
                tbcSale.Enabled = false;
                btnCreateSale.Hide();
                btnClose.Show();
            }
            else 
            {
                MessageBox.Show(msg, "Create Sale", MessageBoxButtons.OK);
            }
        }

        private void btnClearTradeInVehicle_Click(object sender, EventArgs e)
        {
            SaleInstanceForm.tradeVehicle = null;
            tbShowTradeInVehicle.Text = "";
        }

        private void cblAddon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblAddon.SelectedItem != null)
            {
                Addon a = sInstance.SingleAddon(cblAddon.SelectedItem as string);
                tbAddonDetail.Text = a.View;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
