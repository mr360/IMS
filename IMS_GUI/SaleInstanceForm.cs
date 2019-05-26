using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IMS.Instance;
using IMS;
using System.Drawing.Printing;
using System.Drawing;

namespace IMS_GUI
{
    public partial class SaleInstanceForm : Form
    {
        SaleInstance sInstance = new SaleInstance(Program.staffAccount, Program.vm, Program.am, Program.im, Program.bm);
        LotInstance lInstance = new LotInstance(Program.vm, Program.bm);

        public SaleInstanceForm()
        {
            InitializeComponent();
        }

        private void SaleInstance_Load(object sender, EventArgs e)
        {
            List<string> bList = lInstance.BaysWithNonSoldVehicles;
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
            if (sInstance.SelectBaseVehicle(cbBay.SelectedItem as string))
            {
                tbVehicleDetails.Text = sInstance.ViewSelectedVehicle;
                dynamic aList = sInstance.GetSelectedVehicleAvailableAddons;

                foreach (Addon a in aList)
                {
                    cblAddon.Items.Add(a.Id);
                }
            }
            else
            {
                tbVehicleDetails.Text = "No vehicle selected";
            }
        }

        private void btnTradeVehicleAdd_Click(object sender, EventArgs e)
        {
            CreateVehicleForm sInstanceForm = new CreateVehicleForm();
            sInstanceForm.ShowDialog();

            string msg = sInstance.GetTradeVehicle(Program.vehicle);
            if (msg == "Success.")
            {
                tbShowTradeInVehicle.Text = Program.vehicle.View;
            }
            else
            {
                MessageBox.Show(msg, "Add Trade-in Vehicle", MessageBoxButtons.OK);
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            sInstance.SelectBaseVehicle(cbBay.SelectedItem as string);
            foreach (dynamic addon in cblAddon.CheckedItems)
            {
                sInstance.SelectAddon(addon as string);
            }

            string msg = sInstance.CreateSale((PriceRate)cbPriceRate.SelectedItem);
            if (msg != "Missing key sales details")
            {
                tbInvoice.Text = sInstance.ViewInvoice.Replace("\n", "\r\n");
                tbcSale.SelectTab(3);
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
            Program.vehicle = null;
            tbShowTradeInVehicle.Text = "";
        }

        private void cblAddon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblAddon.SelectedItem != null)
            {
                Addon a = sInstance.ViewSelectedAddon(cblAddon.SelectedItem as string);
                tbAddonDetail.Text = a.View;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            e.Graphics.DrawString(tbInvoice.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string msg = sInstance.RemoveInvoice();
            if (msg == "Success.")
            {
                tbInvoice.Clear();
            }

            MessageBox.Show(msg, "Remove Sale Invoice", MessageBoxButtons.OK);
        }
    }
}
