namespace IMS_GUI
{
    partial class ReportInstanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReportInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpReportList = new System.Windows.Forms.TabControl();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.tbpReportView = new System.Windows.Forms.TabPage();
            this.lbReport = new System.Windows.Forms.ListBox();
            this.txtReportView = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbpReportList.SuspendLayout();
            this.tbReport.SuspendLayout();
            this.tbpReportView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportInstanceHeading
            // 
            this.lblReportInstanceHeading.AutoSize = true;
            this.lblReportInstanceHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReportInstanceHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportInstanceHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReportInstanceHeading.Location = new System.Drawing.Point(18, 24);
            this.lblReportInstanceHeading.Name = "lblReportInstanceHeading";
            this.lblReportInstanceHeading.Size = new System.Drawing.Size(233, 28);
            this.lblReportInstanceHeading.TabIndex = 32;
            this.lblReportInstanceHeading.Text = "HTV Report Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 88);
            this.panel1.TabIndex = 33;
            // 
            // tbpReportList
            // 
            this.tbpReportList.Controls.Add(this.tbReport);
            this.tbpReportList.Controls.Add(this.tbpReportView);
            this.tbpReportList.Location = new System.Drawing.Point(0, 95);
            this.tbpReportList.Name = "tbpReportList";
            this.tbpReportList.SelectedIndex = 0;
            this.tbpReportList.Size = new System.Drawing.Size(442, 351);
            this.tbpReportList.TabIndex = 34;
            // 
            // tbReport
            // 
            this.tbReport.Controls.Add(this.btnCreateReport);
            this.tbReport.Controls.Add(this.lbReport);
            this.tbReport.Location = new System.Drawing.Point(4, 28);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(434, 319);
            this.tbReport.TabIndex = 0;
            this.tbReport.Text = "Reports";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // tbpReportView
            // 
            this.tbpReportView.Controls.Add(this.btnPrint);
            this.tbpReportView.Controls.Add(this.txtReportView);
            this.tbpReportView.Location = new System.Drawing.Point(4, 28);
            this.tbpReportView.Name = "tbpReportView";
            this.tbpReportView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReportView.Size = new System.Drawing.Size(434, 319);
            this.tbpReportView.TabIndex = 1;
            this.tbpReportView.Text = "View";
            this.tbpReportView.UseVisualStyleBackColor = true;
            // 
            // lbReport
            // 
            this.lbReport.FormattingEnabled = true;
            this.lbReport.ItemHeight = 19;
            this.lbReport.Location = new System.Drawing.Point(7, 7);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(386, 308);
            this.lbReport.TabIndex = 0;
            // 
            // txtReportView
            // 
            this.txtReportView.Location = new System.Drawing.Point(4, 4);
            this.txtReportView.Multiline = true;
            this.txtReportView.Name = "txtReportView";
            this.txtReportView.ReadOnly = true;
            this.txtReportView.Size = new System.Drawing.Size(385, 309);
            this.txtReportView.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(131, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Image = global::IMS_GUI.Properties.Resources.plus_32_32;
            this.btnCreateReport.Location = new System.Drawing.Point(398, 7);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(32, 32);
            this.btnCreateReport.TabIndex = 36;
            this.btnCreateReport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::IMS_GUI.Properties.Resources.printer_32_32;
            this.btnPrint.Location = new System.Drawing.Point(396, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ReportInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbpReportList);
            this.Controls.Add(this.lblReportInstanceHeading);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportInstanceForm";
            this.Text = "Report Instance ";
            this.tbpReportList.ResumeLayout(false);
            this.tbReport.ResumeLayout(false);
            this.tbpReportView.ResumeLayout(false);
            this.tbpReportView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbpReportList;
        private System.Windows.Forms.TabPage tbReport;
        private System.Windows.Forms.ListBox lbReport;
        private System.Windows.Forms.TabPage tbpReportView;
        private System.Windows.Forms.TextBox txtReportView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCreateReport;
    }
}