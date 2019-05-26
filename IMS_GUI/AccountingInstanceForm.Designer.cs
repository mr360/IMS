namespace IMS_GUI
{
    partial class AccountingInstanceForm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblAccountingInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPayment = new System.Windows.Forms.TabPage();
            this.nudCardExpire = new System.Windows.Forms.NumericUpDown();
            this.nudCardCode = new System.Windows.Forms.NumericUpDown();
            this.btnGetExistingCustomer = new System.Windows.Forms.Button();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerExisting = new System.Windows.Forms.TextBox();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.tbpInvoice = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtInvoiceView = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCode)).BeginInit();
            this.tbpInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(291, 21);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(142, 48);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTotal.Location = new System.Drawing.Point(16, 490);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total (inc GST)";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTotalValue.Location = new System.Drawing.Point(48, 519);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(72, 19);
            this.lblTotalValue.TabIndex = 11;
            this.lblTotalValue.Text = "$______";
            // 
            // lblAccountingInstanceHeading
            // 
            this.lblAccountingInstanceHeading.AutoSize = true;
            this.lblAccountingInstanceHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAccountingInstanceHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountingInstanceHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountingInstanceHeading.Location = new System.Drawing.Point(18, 24);
            this.lblAccountingInstanceHeading.Name = "lblAccountingInstanceHeading";
            this.lblAccountingInstanceHeading.Size = new System.Drawing.Size(285, 28);
            this.lblAccountingInstanceHeading.TabIndex = 30;
            this.lblAccountingInstanceHeading.Text = "HTV Accounting Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 88);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(-5, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 93);
            this.panel2.TabIndex = 35;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 48);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPayment);
            this.tabControl1.Controls.Add(this.tbpInvoice);
            this.tabControl1.Location = new System.Drawing.Point(0, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 367);
            this.tabControl1.TabIndex = 36;
            // 
            // tbpPayment
            // 
            this.tbpPayment.BackColor = System.Drawing.SystemColors.Control;
            this.tbpPayment.Controls.Add(this.nudCardExpire);
            this.tbpPayment.Controls.Add(this.nudCardCode);
            this.tbpPayment.Controls.Add(this.btnGetExistingCustomer);
            this.tbpPayment.Controls.Add(this.btnGetInvoice);
            this.tbpPayment.Controls.Add(this.lblPayment);
            this.tbpPayment.Controls.Add(this.txtCardNumber);
            this.tbpPayment.Controls.Add(this.lblCustomer);
            this.tbpPayment.Controls.Add(this.lblInvoiceId);
            this.tbpPayment.Controls.Add(this.btnCreateNewCustomer);
            this.tbpPayment.Controls.Add(this.txtCustomerExisting);
            this.tbpPayment.Controls.Add(this.txtInvoiceId);
            this.tbpPayment.Location = new System.Drawing.Point(4, 28);
            this.tbpPayment.Name = "tbpPayment";
            this.tbpPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPayment.Size = new System.Drawing.Size(434, 335);
            this.tbpPayment.TabIndex = 0;
            this.tbpPayment.Text = "Payment";
            // 
            // nudCardExpire
            // 
            this.nudCardExpire.Location = new System.Drawing.Point(19, 226);
            this.nudCardExpire.Name = "nudCardExpire";
            this.nudCardExpire.Size = new System.Drawing.Size(193, 26);
            this.nudCardExpire.TabIndex = 48;
            // 
            // nudCardCode
            // 
            this.nudCardCode.Location = new System.Drawing.Point(18, 258);
            this.nudCardCode.Name = "nudCardCode";
            this.nudCardCode.Size = new System.Drawing.Size(120, 26);
            this.nudCardCode.TabIndex = 47;
            // 
            // btnGetExistingCustomer
            // 
            this.btnGetExistingCustomer.Location = new System.Drawing.Point(364, 114);
            this.btnGetExistingCustomer.Name = "btnGetExistingCustomer";
            this.btnGetExistingCustomer.Size = new System.Drawing.Size(57, 26);
            this.btnGetExistingCustomer.TabIndex = 45;
            this.btnGetExistingCustomer.Text = "Get";
            this.btnGetExistingCustomer.UseVisualStyleBackColor = true;
            this.btnGetExistingCustomer.Click += new System.EventHandler(this.btnGetExistingCustomer_Click);
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(189, 40);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(75, 27);
            this.btnGetInvoice.TabIndex = 44;
            this.btnGetInvoice.Text = "Get";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(14, 169);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(144, 19);
            this.lblPayment.TabIndex = 41;
            this.lblPayment.Text = "Payment Details";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(18, 194);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(403, 26);
            this.txtCardNumber.TabIndex = 40;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(14, 88);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(225, 19);
            this.lblCustomer.TabIndex = 39;
            this.lblCustomer.Text = "New or Existing Customer";
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Location = new System.Drawing.Point(14, 17);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(99, 19);
            this.lblInvoiceId.TabIndex = 38;
            this.lblInvoiceId.Text = "Invoice Id";
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(18, 114);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(165, 26);
            this.btnCreateNewCustomer.TabIndex = 37;
            this.btnCreateNewCustomer.Text = "Create Customer";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // txtCustomerExisting
            // 
            this.txtCustomerExisting.Location = new System.Drawing.Point(210, 114);
            this.txtCustomerExisting.Name = "txtCustomerExisting";
            this.txtCustomerExisting.Size = new System.Drawing.Size(148, 26);
            this.txtCustomerExisting.TabIndex = 36;
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Location = new System.Drawing.Point(18, 41);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(165, 26);
            this.txtInvoiceId.TabIndex = 35;
            // 
            // tbpInvoice
            // 
            this.tbpInvoice.Controls.Add(this.btnPrint);
            this.tbpInvoice.Controls.Add(this.txtInvoiceView);
            this.tbpInvoice.Location = new System.Drawing.Point(4, 28);
            this.tbpInvoice.Name = "tbpInvoice";
            this.tbpInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInvoice.Size = new System.Drawing.Size(434, 335);
            this.tbpInvoice.TabIndex = 1;
            this.tbpInvoice.Text = "Invoice";
            this.tbpInvoice.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::IMS_GUI.Properties.Resources.printer_32_32;
            this.btnPrint.Location = new System.Drawing.Point(396, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtInvoiceView
            // 
            this.txtInvoiceView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceView.Location = new System.Drawing.Point(4, 4);
            this.txtInvoiceView.Multiline = true;
            this.txtInvoiceView.Name = "txtInvoiceView";
            this.txtInvoiceView.ReadOnly = true;
            this.txtInvoiceView.Size = new System.Drawing.Size(388, 325);
            this.txtInvoiceView.TabIndex = 0;
            // 
            // AccountingInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAccountingInstanceHeading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingInstanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountingInstanceForm";
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpPayment.ResumeLayout(false);
            this.tbpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCode)).EndInit();
            this.tbpInvoice.ResumeLayout(false);
            this.tbpInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblAccountingInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPayment;
        private System.Windows.Forms.Button btnGetExistingCustomer;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.TextBox txtCustomerExisting;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.TabPage tbpInvoice;
        private System.Windows.Forms.NumericUpDown nudCardExpire;
        private System.Windows.Forms.NumericUpDown nudCardCode;
        private System.Windows.Forms.TextBox txtInvoiceView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
    }
}