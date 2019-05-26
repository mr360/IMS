namespace IMS_GUI
{
    partial class SaleInstanceForm
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
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.cblAddon = new System.Windows.Forms.CheckedListBox();
            this.btnTradeVehicleAdd = new System.Windows.Forms.Button();
            this.lblVehicleSelect = new System.Windows.Forms.Label();
            this.lblAddonAdd = new System.Windows.Forms.Label();
            this.lblTradeVehicleAdd = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.tbcSale = new System.Windows.Forms.TabControl();
            this.tbpBaseVehicle = new System.Windows.Forms.TabPage();
            this.cbPriceRate = new System.Windows.Forms.ComboBox();
            this.tbVehicleDetails = new System.Windows.Forms.TextBox();
            this.lbPriceModify = new System.Windows.Forms.Label();
            this.lbVehicleDetail = new System.Windows.Forms.Label();
            this.lbBaySelect = new System.Windows.Forms.Label();
            this.btnVehicleSelect = new System.Windows.Forms.Button();
            this.cbBay = new System.Windows.Forms.ComboBox();
            this.tbpAddon = new System.Windows.Forms.TabPage();
            this.lblAddonDetail = new System.Windows.Forms.Label();
            this.tbAddonDetail = new System.Windows.Forms.TextBox();
            this.tbpRebate = new System.Windows.Forms.TabPage();
            this.btnClearTradeInVehicle = new System.Windows.Forms.Button();
            this.tbShowTradeInVehicle = new System.Windows.Forms.TextBox();
            this.tbpSummary = new System.Windows.Forms.TabPage();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbInvoice = new System.Windows.Forms.TextBox();
            this.lblSaleInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaleTip = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbcSale.SuspendLayout();
            this.tbpBaseVehicle.SuspendLayout();
            this.tbpAddon.SuspendLayout();
            this.tbpRebate.SuspendLayout();
            this.tbpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Location = new System.Drawing.Point(138, 530);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(151, 39);
            this.btnCreateSale.TabIndex = 0;
            this.btnCreateSale.Text = "Create Sale";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // cblAddon
            // 
            this.cblAddon.FormattingEnabled = true;
            this.cblAddon.Location = new System.Drawing.Point(19, 27);
            this.cblAddon.Name = "cblAddon";
            this.cblAddon.Size = new System.Drawing.Size(361, 193);
            this.cblAddon.TabIndex = 3;
            this.cblAddon.SelectedIndexChanged += new System.EventHandler(this.cblAddon_SelectedIndexChanged);
            // 
            // btnTradeVehicleAdd
            // 
            this.btnTradeVehicleAdd.Location = new System.Drawing.Point(21, 151);
            this.btnTradeVehicleAdd.Name = "btnTradeVehicleAdd";
            this.btnTradeVehicleAdd.Size = new System.Drawing.Size(203, 27);
            this.btnTradeVehicleAdd.TabIndex = 6;
            this.btnTradeVehicleAdd.Text = "Add Vehicle";
            this.btnTradeVehicleAdd.UseVisualStyleBackColor = true;
            this.btnTradeVehicleAdd.Click += new System.EventHandler(this.btnTradeVehicleAdd_Click);
            // 
            // lblVehicleSelect
            // 
            this.lblVehicleSelect.AutoSize = true;
            this.lblVehicleSelect.Location = new System.Drawing.Point(458, 130);
            this.lblVehicleSelect.Name = "lblVehicleSelect";
            this.lblVehicleSelect.Size = new System.Drawing.Size(72, 19);
            this.lblVehicleSelect.TabIndex = 8;
            this.lblVehicleSelect.Text = "Vehicle";
            // 
            // lblAddonAdd
            // 
            this.lblAddonAdd.AutoSize = true;
            this.lblAddonAdd.Location = new System.Drawing.Point(458, 192);
            this.lblAddonAdd.Name = "lblAddonAdd";
            this.lblAddonAdd.Size = new System.Drawing.Size(54, 19);
            this.lblAddonAdd.TabIndex = 9;
            this.lblAddonAdd.Text = "Addon";
            // 
            // lblTradeVehicleAdd
            // 
            this.lblTradeVehicleAdd.AutoSize = true;
            this.lblTradeVehicleAdd.Location = new System.Drawing.Point(458, 324);
            this.lblTradeVehicleAdd.Name = "lblTradeVehicleAdd";
            this.lblTradeVehicleAdd.Size = new System.Drawing.Size(153, 19);
            this.lblTradeVehicleAdd.TabIndex = 10;
            this.lblTradeVehicleAdd.Text = "Trade-In Vehicle";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(458, 398);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(126, 19);
            this.lblOrderSummary.TabIndex = 11;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // tbcSale
            // 
            this.tbcSale.Controls.Add(this.tbpBaseVehicle);
            this.tbcSale.Controls.Add(this.tbpAddon);
            this.tbcSale.Controls.Add(this.tbpRebate);
            this.tbcSale.Controls.Add(this.tbpSummary);
            this.tbcSale.Location = new System.Drawing.Point(12, 137);
            this.tbcSale.Name = "tbcSale";
            this.tbcSale.SelectedIndex = 0;
            this.tbcSale.Size = new System.Drawing.Size(421, 388);
            this.tbcSale.TabIndex = 12;
            // 
            // tbpBaseVehicle
            // 
            this.tbpBaseVehicle.Controls.Add(this.cbPriceRate);
            this.tbpBaseVehicle.Controls.Add(this.tbVehicleDetails);
            this.tbpBaseVehicle.Controls.Add(this.lbPriceModify);
            this.tbpBaseVehicle.Controls.Add(this.lbVehicleDetail);
            this.tbpBaseVehicle.Controls.Add(this.lbBaySelect);
            this.tbpBaseVehicle.Controls.Add(this.btnVehicleSelect);
            this.tbpBaseVehicle.Controls.Add(this.cbBay);
            this.tbpBaseVehicle.Location = new System.Drawing.Point(4, 28);
            this.tbpBaseVehicle.Name = "tbpBaseVehicle";
            this.tbpBaseVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBaseVehicle.Size = new System.Drawing.Size(413, 356);
            this.tbpBaseVehicle.TabIndex = 0;
            this.tbpBaseVehicle.Text = "Base Vehicle";
            this.tbpBaseVehicle.UseVisualStyleBackColor = true;
            // 
            // cbPriceRate
            // 
            this.cbPriceRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriceRate.FormattingEnabled = true;
            this.cbPriceRate.Location = new System.Drawing.Point(28, 253);
            this.cbPriceRate.Name = "cbPriceRate";
            this.cbPriceRate.Size = new System.Drawing.Size(341, 27);
            this.cbPriceRate.TabIndex = 10;
            // 
            // tbVehicleDetails
            // 
            this.tbVehicleDetails.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleDetails.Location = new System.Drawing.Point(28, 115);
            this.tbVehicleDetails.Multiline = true;
            this.tbVehicleDetails.Name = "tbVehicleDetails";
            this.tbVehicleDetails.ReadOnly = true;
            this.tbVehicleDetails.Size = new System.Drawing.Size(341, 100);
            this.tbVehicleDetails.TabIndex = 9;
            // 
            // lbPriceModify
            // 
            this.lbPriceModify.AutoSize = true;
            this.lbPriceModify.Location = new System.Drawing.Point(24, 230);
            this.lbPriceModify.Name = "lbPriceModify";
            this.lbPriceModify.Size = new System.Drawing.Size(135, 19);
            this.lbPriceModify.TabIndex = 8;
            this.lbPriceModify.Text = "Price Modifier";
            // 
            // lbVehicleDetail
            // 
            this.lbVehicleDetail.AutoSize = true;
            this.lbVehicleDetail.Location = new System.Drawing.Point(24, 93);
            this.lbVehicleDetail.Name = "lbVehicleDetail";
            this.lbVehicleDetail.Size = new System.Drawing.Size(144, 19);
            this.lbVehicleDetail.TabIndex = 7;
            this.lbVehicleDetail.Text = "Vehicle Details";
            // 
            // lbBaySelect
            // 
            this.lbBaySelect.AutoSize = true;
            this.lbBaySelect.Location = new System.Drawing.Point(24, 24);
            this.lbBaySelect.Name = "lbBaySelect";
            this.lbBaySelect.Size = new System.Drawing.Size(99, 19);
            this.lbBaySelect.TabIndex = 6;
            this.lbBaySelect.Text = "Select Bay";
            // 
            // btnVehicleSelect
            // 
            this.btnVehicleSelect.Location = new System.Drawing.Point(294, 48);
            this.btnVehicleSelect.Name = "btnVehicleSelect";
            this.btnVehicleSelect.Size = new System.Drawing.Size(75, 27);
            this.btnVehicleSelect.TabIndex = 1;
            this.btnVehicleSelect.Text = "Select";
            this.btnVehicleSelect.UseVisualStyleBackColor = true;
            this.btnVehicleSelect.Click += new System.EventHandler(this.btnVehicleSelect_Click);
            // 
            // cbBay
            // 
            this.cbBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBay.FormattingEnabled = true;
            this.cbBay.Location = new System.Drawing.Point(28, 49);
            this.cbBay.Name = "cbBay";
            this.cbBay.Size = new System.Drawing.Size(245, 27);
            this.cbBay.TabIndex = 4;
            // 
            // tbpAddon
            // 
            this.tbpAddon.Controls.Add(this.lblAddonDetail);
            this.tbpAddon.Controls.Add(this.tbAddonDetail);
            this.tbpAddon.Controls.Add(this.cblAddon);
            this.tbpAddon.Location = new System.Drawing.Point(4, 28);
            this.tbpAddon.Name = "tbpAddon";
            this.tbpAddon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddon.Size = new System.Drawing.Size(413, 356);
            this.tbpAddon.TabIndex = 1;
            this.tbpAddon.Text = "Addons";
            this.tbpAddon.UseVisualStyleBackColor = true;
            // 
            // lblAddonDetail
            // 
            this.lblAddonDetail.AutoSize = true;
            this.lblAddonDetail.Location = new System.Drawing.Point(15, 232);
            this.lblAddonDetail.Name = "lblAddonDetail";
            this.lblAddonDetail.Size = new System.Drawing.Size(63, 19);
            this.lblAddonDetail.TabIndex = 5;
            this.lblAddonDetail.Text = "Detail";
            // 
            // tbAddonDetail
            // 
            this.tbAddonDetail.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddonDetail.Location = new System.Drawing.Point(19, 254);
            this.tbAddonDetail.Multiline = true;
            this.tbAddonDetail.Name = "tbAddonDetail";
            this.tbAddonDetail.ReadOnly = true;
            this.tbAddonDetail.Size = new System.Drawing.Size(361, 87);
            this.tbAddonDetail.TabIndex = 4;
            // 
            // tbpRebate
            // 
            this.tbpRebate.Controls.Add(this.btnClearTradeInVehicle);
            this.tbpRebate.Controls.Add(this.tbShowTradeInVehicle);
            this.tbpRebate.Controls.Add(this.btnTradeVehicleAdd);
            this.tbpRebate.Location = new System.Drawing.Point(4, 28);
            this.tbpRebate.Name = "tbpRebate";
            this.tbpRebate.Size = new System.Drawing.Size(413, 356);
            this.tbpRebate.TabIndex = 2;
            this.tbpRebate.Text = "Rebate";
            this.tbpRebate.UseVisualStyleBackColor = true;
            // 
            // btnClearTradeInVehicle
            // 
            this.btnClearTradeInVehicle.Location = new System.Drawing.Point(246, 151);
            this.btnClearTradeInVehicle.Name = "btnClearTradeInVehicle";
            this.btnClearTradeInVehicle.Size = new System.Drawing.Size(141, 27);
            this.btnClearTradeInVehicle.TabIndex = 8;
            this.btnClearTradeInVehicle.Text = "Clear Vehicle";
            this.btnClearTradeInVehicle.UseVisualStyleBackColor = true;
            this.btnClearTradeInVehicle.Click += new System.EventHandler(this.btnClearTradeInVehicle_Click);
            // 
            // tbShowTradeInVehicle
            // 
            this.tbShowTradeInVehicle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowTradeInVehicle.Location = new System.Drawing.Point(21, 26);
            this.tbShowTradeInVehicle.Multiline = true;
            this.tbShowTradeInVehicle.Name = "tbShowTradeInVehicle";
            this.tbShowTradeInVehicle.ReadOnly = true;
            this.tbShowTradeInVehicle.Size = new System.Drawing.Size(366, 106);
            this.tbShowTradeInVehicle.TabIndex = 7;
            // 
            // tbpSummary
            // 
            this.tbpSummary.Controls.Add(this.btnDeleteInvoice);
            this.tbpSummary.Controls.Add(this.btnPrint);
            this.tbpSummary.Controls.Add(this.tbInvoice);
            this.tbpSummary.Location = new System.Drawing.Point(4, 28);
            this.tbpSummary.Name = "tbpSummary";
            this.tbpSummary.Size = new System.Drawing.Size(413, 356);
            this.tbpSummary.TabIndex = 3;
            this.tbpSummary.Text = "Summary";
            this.tbpSummary.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Image = global::IMS_GUI.Properties.Resources.delete_32_32;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(374, 46);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteInvoice.TabIndex = 9;
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::IMS_GUI.Properties.Resources.printer_32_32;
            this.btnPrint.Location = new System.Drawing.Point(374, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbInvoice
            // 
            this.tbInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInvoice.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoice.Location = new System.Drawing.Point(3, 3);
            this.tbInvoice.Multiline = true;
            this.tbInvoice.Name = "tbInvoice";
            this.tbInvoice.ReadOnly = true;
            this.tbInvoice.Size = new System.Drawing.Size(365, 350);
            this.tbInvoice.TabIndex = 7;
            // 
            // lblSaleInstanceHeading
            // 
            this.lblSaleInstanceHeading.AutoSize = true;
            this.lblSaleInstanceHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaleInstanceHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleInstanceHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaleInstanceHeading.Location = new System.Drawing.Point(20, 28);
            this.lblSaleInstanceHeading.Name = "lblSaleInstanceHeading";
            this.lblSaleInstanceHeading.Size = new System.Drawing.Size(220, 28);
            this.lblSaleInstanceHeading.TabIndex = 13;
            this.lblSaleInstanceHeading.Text = "HTV Sales Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 88);
            this.panel1.TabIndex = 14;
            // 
            // lblSaleTip
            // 
            this.lblSaleTip.AutoSize = true;
            this.lblSaleTip.Location = new System.Drawing.Point(12, 108);
            this.lblSaleTip.Name = "lblSaleTip";
            this.lblSaleTip.Size = new System.Drawing.Size(315, 19);
            this.lblSaleTip.TabIndex = 15;
            this.lblSaleTip.Text = "Please go through the tab process.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(138, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SaleInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSaleTip);
            this.Controls.Add(this.lblSaleInstanceHeading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcSale);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblTradeVehicleAdd);
            this.Controls.Add(this.lblAddonAdd);
            this.Controls.Add(this.lblVehicleSelect);
            this.Controls.Add(this.btnCreateSale);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleInstanceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaleInstance";
            this.Load += new System.EventHandler(this.SaleInstance_Load);
            this.tbcSale.ResumeLayout(false);
            this.tbpBaseVehicle.ResumeLayout(false);
            this.tbpBaseVehicle.PerformLayout();
            this.tbpAddon.ResumeLayout(false);
            this.tbpAddon.PerformLayout();
            this.tbpRebate.ResumeLayout(false);
            this.tbpRebate.PerformLayout();
            this.tbpSummary.ResumeLayout(false);
            this.tbpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.CheckedListBox cblAddon;
        private System.Windows.Forms.Button btnTradeVehicleAdd;
        private System.Windows.Forms.Label lblVehicleSelect;
        private System.Windows.Forms.Label lblAddonAdd;
        private System.Windows.Forms.Label lblTradeVehicleAdd;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.TabControl tbcSale;
        private System.Windows.Forms.TabPage tbpAddon;
        private System.Windows.Forms.TabPage tbpRebate;
        private System.Windows.Forms.Label lblSaleInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaleTip;
        private System.Windows.Forms.TextBox tbShowTradeInVehicle;
        private System.Windows.Forms.Button btnClearTradeInVehicle;
        private System.Windows.Forms.TabPage tbpBaseVehicle;
        private System.Windows.Forms.TextBox tbVehicleDetails;
        private System.Windows.Forms.Label lbPriceModify;
        private System.Windows.Forms.Label lbVehicleDetail;
        private System.Windows.Forms.Label lbBaySelect;
        private System.Windows.Forms.Button btnVehicleSelect;
        private System.Windows.Forms.ComboBox cbBay;
        private System.Windows.Forms.Label lblAddonDetail;
        private System.Windows.Forms.TextBox tbAddonDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbPriceRate;
        private System.Windows.Forms.TabPage tbpSummary;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbInvoice;
    }
}