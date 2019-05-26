namespace IMS_GUI
{
    partial class CreateReportForm
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
            this.lblCreateReportHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPeriodStart = new System.Windows.Forms.TextBox();
            this.txtPeriodEnd = new System.Windows.Forms.TextBox();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.lblPeriodStart = new System.Windows.Forms.Label();
            this.lblPeriodEnd = new System.Windows.Forms.Label();
            this.lblReportType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateReportHeading
            // 
            this.lblCreateReportHeading.AutoSize = true;
            this.lblCreateReportHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCreateReportHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReportHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateReportHeading.Location = new System.Drawing.Point(18, 24);
            this.lblCreateReportHeading.Name = "lblCreateReportHeading";
            this.lblCreateReportHeading.Size = new System.Drawing.Size(233, 28);
            this.lblCreateReportHeading.TabIndex = 39;
            this.lblCreateReportHeading.Text = "HTV Create Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 88);
            this.panel1.TabIndex = 40;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(123, 241);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 32);
            this.btnCreate.TabIndex = 41;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPeriodStart
            // 
            this.txtPeriodStart.Location = new System.Drawing.Point(123, 129);
            this.txtPeriodStart.Name = "txtPeriodStart";
            this.txtPeriodStart.Size = new System.Drawing.Size(151, 26);
            this.txtPeriodStart.TabIndex = 42;
            // 
            // txtPeriodEnd
            // 
            this.txtPeriodEnd.Location = new System.Drawing.Point(123, 161);
            this.txtPeriodEnd.Name = "txtPeriodEnd";
            this.txtPeriodEnd.Size = new System.Drawing.Size(151, 26);
            this.txtPeriodEnd.TabIndex = 43;
            // 
            // cbReportType
            // 
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(123, 193);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(151, 27);
            this.cbReportType.TabIndex = 44;
            // 
            // lblPeriodStart
            // 
            this.lblPeriodStart.AutoSize = true;
            this.lblPeriodStart.Location = new System.Drawing.Point(19, 132);
            this.lblPeriodStart.Name = "lblPeriodStart";
            this.lblPeriodStart.Size = new System.Drawing.Size(99, 19);
            this.lblPeriodStart.TabIndex = 45;
            this.lblPeriodStart.Text = "Date Start";
            // 
            // lblPeriodEnd
            // 
            this.lblPeriodEnd.AutoSize = true;
            this.lblPeriodEnd.Location = new System.Drawing.Point(19, 164);
            this.lblPeriodEnd.Name = "lblPeriodEnd";
            this.lblPeriodEnd.Size = new System.Drawing.Size(81, 19);
            this.lblPeriodEnd.TabIndex = 46;
            this.lblPeriodEnd.Text = "Date End";
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(19, 197);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(45, 19);
            this.lblReportType.TabIndex = 47;
            this.lblReportType.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 26);
            this.txtName.TabIndex = 48;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 19);
            this.lblId.TabIndex = 49;
            this.lblId.Text = "Name";
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.lblPeriodEnd);
            this.Controls.Add(this.lblPeriodStart);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.txtPeriodEnd);
            this.Controls.Add(this.txtPeriodStart);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCreateReportHeading);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Report ";
            this.Load += new System.EventHandler(this.CreateReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateReportHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPeriodStart;
        private System.Windows.Forms.TextBox txtPeriodEnd;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label lblPeriodStart;
        private System.Windows.Forms.Label lblPeriodEnd;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
    }
}