using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Instance;
using IMS;

namespace IMS_GUI
{
    public partial class SaleInstanceForm : Form
    {
        SaleInstance sInstance = new SaleInstance(Program.staffAccount, Program.vm, Program.am, Program.im);
        public static Vehicle tradeVehicle = null;

        public SaleInstanceForm()
        {
            InitializeComponent();
        }

        private void SaleInstance_Load(object sender, EventArgs e)
        {
            // SaleInstance.ViewAllBay (do not include empty or sold)
            // Load the bay into bayid text box
            List<string> vIdList = Program.bm.GetIDs;
            foreach (string bId in vIdList)
            {
                cbBay.Items.Add(bId);
            }

        }

        private void btnVehicleSelect_Click(object sender, EventArgs e)
        {
            cblAddon.Items.Clear();

            //Load vehicle that is in bay
            Bay b = Program.bm.Retrieve(cbBay.SelectedItem as string) as Bay;
            Vehicle v = Program.vm.Retrieve(b.Vehicle) as Vehicle;
            if (v == null)
            {
                tbVehicleDetails.Text = "Empty Bay";
            }
            else
            {
                tbVehicleDetails.Text = v.View;

                // Load the addon list into Addon checkbox panel
                dynamic aList = Program.am.RetrieveMany(v.Id) as dynamic;
                if (aList != null)
                {
                    foreach (Addon a in aList)
                    {
                        cblAddon.Items.Add(a.Id);
                    }
                }
            }
        }

        private void btnTradeVehicleAdd_Click(object sender, EventArgs e)
        {
            CreateVehicleForm sInstanceForm = new CreateVehicleForm();
            sInstanceForm.ShowDialog();
            
            if (SaleInstanceForm.tradeVehicle != null)
            {
                tbShowTradeInVehicle.Text = tradeVehicle.View;
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {

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
                Addon a = Program.am.Retrieve(cblAddon.SelectedItem as string) as Addon;
                tbAddonDetail.Text = a.View;
            }

            
        }
    }
}
