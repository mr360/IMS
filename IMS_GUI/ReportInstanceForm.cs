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
using IMS.Report;
using IMS;
using System.Drawing.Printing;

namespace IMS_GUI
{
    public partial class ReportInstanceForm : Form
    {
        ReportInstance rInstance = new ReportInstance(Program.staffAccount, Program.rm, Program.im);
        public static string txtName = "";
        public static string txtStartPeriod = "";
        public static string txtEndPeriod = "";
        public static string txtReportType = "";

        public ReportInstanceForm()
        {
            InitializeComponent();
        }

        private void ReportInstanceForm_Load(object sender, EventArgs e)
        {
            lbReport.Items.Clear();
            List<string> lReportList = rInstance.GetReportList;
            foreach(string r in lReportList)
            {
                lbReport.Items.Add(r);
            }
            
        }

        private void lbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtReportView.Text = rInstance.ViewSelectedReport(lbReport.SelectedItem as string).Replace("\n", "\r\n");
            }
            catch
            {
                txtReportView.Text = "";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string lMsg = "";
            CreateReportForm rForm = new CreateReportForm();
            rForm.ShowDialog();

            ReportType myStatus;
            Enum.TryParse(txtReportType, out myStatus);
            lMsg = rInstance.CreateReport(txtName,txtStartPeriod, txtEndPeriod, myStatus);
            MessageBox.Show(lMsg, "Create Report", MessageBoxButtons.OK);
            ReportInstanceForm_Load(sender, e);
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
            e.Graphics.DrawString(txtReportView.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20);
        }
    }
}
