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
            // Load the vehicles into Base Vehicle text box
            
            
        }

        private void btnVehicleSelect_Click(object sender, EventArgs e)
        {
            // Load the addon list into Addon checkbox panel
        }

        private void btnTradeVehicleAdd_Click(object sender, EventArgs e)
        {
            // Create a new vehicle object 
            
            CreateVehicleForm sInstanceForm = new CreateVehicleForm();
            sInstanceForm.ShowDialog();
        }
    }
}
