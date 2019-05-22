namespace IMS_GUI
{
    partial class SaleInstance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblSaleInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
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
            this.btnVehicleSelect.Location = new System.Drawing.Point(728, 152);
            this.btnVehicleSelect.Name = "btnVehicleSelect";
            this.btnVehicleSelect.Size = new System.Drawing.Size(75, 27);
            this.btnVehicleSelect.TabIndex = 1;
            this.btnVehicleSelect.Text = "Select";
            this.btnVehicleSelect.UseVisualStyleBackColor = true;
            // 
            // btnAddonAdd
            // 
            this.btnAddonAdd.Location = new System.Drawing.Point(728, 214);
            this.btnAddonAdd.Name = "btnAddonAdd";
            this.btnAddonAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAddonAdd.TabIndex = 2;
            this.btnAddonAdd.Text = "Add";
            this.btnAddonAdd.UseVisualStyleBackColor = true;
            // 
            // cblAddon
            // 
            this.cblAddon.FormattingEnabled = true;
            this.cblAddon.Location = new System.Drawing.Point(462, 214);
            this.cblAddon.Name = "cblAddon";
            this.cblAddon.Size = new System.Drawing.Size(245, 88);
            this.cblAddon.TabIndex = 3;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(462, 152);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(245, 27);
            this.cbVehicle.TabIndex = 4;
            // 
            // btnTradeVehicleAdd
            // 
            this.btnTradeVehicleAdd.Location = new System.Drawing.Point(462, 346);
            this.btnTradeVehicleAdd.Name = "btnTradeVehicleAdd";
            this.btnTradeVehicleAdd.Size = new System.Drawing.Size(204, 27);
            this.btnTradeVehicleAdd.TabIndex = 6;
            this.btnTradeVehicleAdd.Text = "Add Vehicle";
            this.btnTradeVehicleAdd.UseVisualStyleBackColor = true;
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.Location = new System.Drawing.Point(462, 420);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.Size = new System.Drawing.Size(245, 98);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 137);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 388);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Base Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Addons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(342, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rebate";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(342, 161);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please go through the tab process.";
            // 
            // SaleInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaleInstanceHeading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblTradeVehicleAdd);
            this.Controls.Add(this.lblAddonAdd);
            this.Controls.Add(this.lblVehicleSelect);
            this.Controls.Add(this.txtOrderSummary);
            this.Controls.Add(this.btnTradeVehicleAdd);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.cblAddon);
            this.Controls.Add(this.btnAddonAdd);
            this.Controls.Add(this.btnVehicleSelect);
            this.Controls.Add(this.btnCreateSale);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaleInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaleInstance";
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblSaleInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}