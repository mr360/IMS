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

namespace IMS_GUI
{
    public partial class CreateVehicleForm : Form
    {
        public CreateVehicleForm()
        {
            InitializeComponent();
        }

        private void CreateVehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // cbBrand.SelectedText to enum?? how??
            //_vehicle = new Vehicle(txtId.Text, (Brand)1, txtModel.Text, new DateTime(Convert.ToInt32(cbYear.SelectedText), 01, 01), Convert.ToDouble(txtPrice.SelectedText));
            SaleInstanceForm.tradeVehicle = new Vehicle(txtId.Text, Brand.Audi, txtModel.Text, new DateTime(2006, 01, 01), 26000.00);
            this.Close();
        }
    }
}
