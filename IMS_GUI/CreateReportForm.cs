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
    public partial class CreateReportForm : Form
    {
        public CreateReportForm()
        {
            InitializeComponent();
            cbReportType.DataSource = Enum.GetValues(typeof(ReportType));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ReportInstanceForm.txtName = txtName.Text;
            ReportInstanceForm.txtStartPeriod = txtPeriodStart.Text;
            ReportInstanceForm.txtEndPeriod = txtPeriodEnd.Text;
            ReportInstanceForm.txtReportType = cbReportType.SelectedItem.ToString();
            this.Close();
        }

        private void CreateReportForm_Load(object sender, EventArgs e)
        {
            ReportInstanceForm.txtName = "";
            ReportInstanceForm.txtStartPeriod = "";
            ReportInstanceForm.txtEndPeriod = "";
            ReportInstanceForm.txtReportType = "";
        }
    }
}
