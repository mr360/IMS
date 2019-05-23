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
            // https://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it

            if (Validate(txtId, "^[a-zA-Z0-9-]+$") && Validate(txtModel, "^[a-zA-Z0-9-]+$") && Validate(txtPrice, "^[0-9]+$"))
            {
                SaleInstanceForm.tradeVehicle = new Vehicle(txtId.Text, (Brand)cbBrand.SelectedItem, txtModel.Text, new DateTime(Convert.ToInt32(cbYear.SelectedItem), 01, 01), Convert.ToDouble(txtPrice.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("The inputted data is not valid and/or missing", "Validation Fail", MessageBoxButtons.OK);
            }
            

        }

        private bool Validate(TextBox t, string regex)
        {
            if ((new Regex(@regex)).IsMatch(t.Text))
            {
                return true;
            }
            return false;
        }
    }
}
