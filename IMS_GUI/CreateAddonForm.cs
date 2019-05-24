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
    public partial class CreateAddonForm : Form
    {
        public CreateAddonForm()
        {
            InitializeComponent();
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            Program.addon = new Addon(txtId.Text, txtName.Text, txtDesc.Text, Convert.ToDouble(nudPrice.Text));
            this.Close();
        }
    }
}
