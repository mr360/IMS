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
    public partial class GarageInstanceForm : Form
    {
        GarageInstance gInstance = new GarageInstance(Program.staffAccount, Program.vm, Program.am, Program.bm, Program.im);

        public GarageInstanceForm()
        {
            InitializeComponent();
        }

        private void GarageInstanceForm_Load(object sender, EventArgs e)
        {
            lbUnassignedVehicle.Items.Clear();
            lbSoldVehicleRemove.Items.Clear();
            cbOpenBay.Items.Clear();

            // Load the unassigned vehicles
            List<string> vList = gInstance.UnallocatedVehicle;
            foreach (string vId in vList)
            {
                lbUnassignedVehicle.Items.Add(vId);
            }

            // Load the sold vehicles
            List<string> sList = gInstance.SoldVehicle;
            foreach (string sId in sList)
            {
                lbSoldVehicleRemove.Items.Add(sId);
            }
            
            // Load the available bays
            List<string> bList = gInstance.AllBays;
            foreach (string bId in bList)
            {
                cbOpenBay.Items.Add(bId);
            }
        }

        private void btnSoldVehicleRemove_Click(object sender, EventArgs e)
        {
            string msg = gInstance.RemoveSoldVehicle(lbSoldVehicleRemove.SelectedItem as string);
            MessageBox.Show(msg, "Remove Vehicle", MessageBoxButtons.OK);
            GarageInstanceForm_Load(sender, e);
        }

        private void btnAssignVehicleToBay_Click(object sender, EventArgs e)
        {
            string msg = gInstance.AssignVehicleToBay(lbUnassignedVehicle.SelectedItem as string, cbOpenBay.SelectedItem as string);
            MessageBox.Show(msg, "Assign Vehicle", MessageBoxButtons.OK);
            GarageInstanceForm_Load(sender, e);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            CreateVehicleForm vInstanceForm = new CreateVehicleForm();
            vInstanceForm.ShowDialog();
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            CreateAddonForm aInstanceForm = new CreateAddonForm();
            aInstanceForm.ShowDialog();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            string msg = "Enter in a items details, then click Add.";

            if (Program.addon != null && Program.vehicle != null)
            {
                MessageBox.Show("Can only add a single item", "Adding Items", MessageBoxButtons.OK);
            }
            else
            {
                if (Program.addon != null)
                {
                    msg = gInstance.Add(Program.addon);
                    tbAddDetail.Text = gInstance.ViewAddon;
                }
                else if(Program.vehicle != null)
                {
                    msg = gInstance.Add(Program.vehicle);
                    tbAddDetail.Text = gInstance.ViewVehicle;
                }

                MessageBox.Show(msg, "Adding Item", MessageBoxButtons.OK);
            }
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            tbAddDetail.Text = "";
            Program.vehicle = null;
            Program.addon = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
