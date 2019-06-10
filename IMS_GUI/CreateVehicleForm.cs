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
using System.Text.RegularExpressions;

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
            cbBrand.DataSource = Enum.GetValues(typeof(Brand));
            cbYear.DataSource = Enumerable.Range(1990, DateTime.Now.Year - 1990 + 1).ToList();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            WinFormShared.vehicle = new Vehicle(txtId.Text, (Brand)cbBrand.SelectedItem, txtModel.Text, new DateTime(Convert.ToInt32(cbYear.SelectedItem), 01, 01), Convert.ToDouble(nudPrice.Text));
            this.Close();            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblSaleInstanceHeading_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
