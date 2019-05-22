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
            this.btnVehicleSelect = new System.Windows.Forms.Button();
            this.btnAddonAdd = new System.Windows.Forms.Button();
            this.cblAddon = new System.Windows.Forms.CheckedListBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.btnTradeVehicleAdd = new System.Windows.Forms.Button();
            this.txtOrderSummary = new System.Windows.Forms.TextBox();
            this.lblVehicleSelect = new System.Windows.Forms.Label();
            this.lblAddonAdd = new System.Windows.Forms.Label();
            this.lblTradeVehicleAdd = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.tbcSale = new System.Windows.Forms.TabControl();
            this.tbpBaseVehicle = new System.Windows.Forms.TabPage();
            this.tbpAddon = new System.Windows.Forms.TabPage();
            this.tbpRebate = new System.Windows.Forms.TabPage();
            this.tbpSummary = new System.Windows.Forms.TabPage();
            this.lblSaleInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaleTip = new System.Windows.Forms.Label();
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
            // btnAddonAdd
            // 
            this.btnAddonAdd.Location = new System.Drawing.Point(317, 27);
            this.btnAddonAdd.Name = "btnAddonAdd";
            this.btnAddonAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAddonAdd.TabIndex = 2;
            this.btnAddonAdd.Text = "Add";
            this.btnAddonAdd.UseVisualStyleBackColor = true;
            // 
            // cblAddon
            // 
            this.cblAddon.FormattingEnabled = true;
            this.cblAddon.Location = new System.Drawing.Point(19, 27);
            this.cblAddon.Name = "cblAddon";
            this.cblAddon.Size = new System.Drawing.Size(292, 298);
            this.cblAddon.TabIndex = 3;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(28, 49);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(245, 27);
            this.cbVehicle.TabIndex = 4;
            // 
            // btnTradeVehicleAdd
            // 
            this.btnTradeVehicleAdd.Location = new System.Drawing.Point(87, 151);
            this.btnTradeVehicleAdd.Name = "btnTradeVehicleAdd";
            this.btnTradeVehicleAdd.Size = new System.Drawing.Size(204, 27);
            this.btnTradeVehicleAdd.TabIndex = 6;
            this.btnTradeVehicleAdd.Text = "Add Vehicle";
            this.btnTradeVehicleAdd.UseVisualStyleBackColor = true;
            this.btnTradeVehicleAdd.Click += new System.EventHandler(this.btnTradeVehicleAdd_Click);
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderSummary.Location = new System.Drawing.Point(9, 24);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.Size = new System.Drawing.Size(386, 306);
            this.txtOrderSummary.TabIndex = 7;
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
            this.tbpBaseVehicle.Controls.Add(this.btnVehicleSelect);
            this.tbpBaseVehicle.Controls.Add(this.cbVehicle);
            this.tbpBaseVehicle.Location = new System.Drawing.Point(4, 28);
            this.tbpBaseVehicle.Name = "tbpBaseVehicle";
            this.tbpBaseVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBaseVehicle.Size = new System.Drawing.Size(413, 356);
            this.tbpBaseVehicle.TabIndex = 0;
            this.tbpBaseVehicle.Text = "Base Vehicle";
            this.tbpBaseVehicle.UseVisualStyleBackColor = true;
            // 
            // tbpAddon
            // 
            this.tbpAddon.Controls.Add(this.cblAddon);
            this.tbpAddon.Controls.Add(this.btnAddonAdd);
            this.tbpAddon.Location = new System.Drawing.Point(4, 28);
            this.tbpAddon.Name = "tbpAddon";
            this.tbpAddon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddon.Size = new System.Drawing.Size(413, 356);
            this.tbpAddon.TabIndex = 1;
            this.tbpAddon.Text = "Addons";
            this.tbpAddon.UseVisualStyleBackColor = true;
            // 
            // tbpRebate
            // 
            this.tbpRebate.Controls.Add(this.btnTradeVehicleAdd);
            this.tbpRebate.Location = new System.Drawing.Point(4, 28);
            this.tbpRebate.Name = "tbpRebate";
            this.tbpRebate.Size = new System.Drawing.Size(413, 356);
            this.tbpRebate.TabIndex = 2;
            this.tbpRebate.Text = "Rebate";
            this.tbpRebate.UseVisualStyleBackColor = true;
            // 
            // tbpSummary
            // 
            this.tbpSummary.Controls.Add(this.txtOrderSummary);
            this.tbpSummary.Location = new System.Drawing.Point(4, 28);
            this.tbpSummary.Name = "tbpSummary";
            this.tbpSummary.Size = new System.Drawing.Size(413, 356);
            this.tbpSummary.TabIndex = 3;
            this.tbpSummary.Text = "Summary";
            this.tbpSummary.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
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
            // SaleInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 576);
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
            this.tbpAddon.ResumeLayout(false);
            this.tbpRebate.ResumeLayout(false);
            this.tbpSummary.ResumeLayout(false);
            this.tbpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Button btnVehicleSelect;
        private System.Windows.Forms.Button btnAddonAdd;
        private System.Windows.Forms.CheckedListBox cblAddon;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Button btnTradeVehicleAdd;
        private System.Windows.Forms.TextBox txtOrderSummary;
        private System.Windows.Forms.Label lblVehicleSelect;
        private System.Windows.Forms.Label lblAddonAdd;
        private System.Windows.Forms.Label lblTradeVehicleAdd;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.TabControl tbcSale;
        private System.Windows.Forms.TabPage tbpBaseVehicle;
        private System.Windows.Forms.TabPage tbpAddon;
        private System.Windows.Forms.TabPage tbpRebate;
        private System.Windows.Forms.TabPage tbpSummary;
        private System.Windows.Forms.Label lblSaleInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaleTip;
    }
}