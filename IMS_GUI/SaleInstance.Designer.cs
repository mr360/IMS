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
            this.SuspendLayout();
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Location = new System.Drawing.Point(102, 442);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(151, 39);
            this.btnCreateSale.TabIndex = 0;
            this.btnCreateSale.Text = "Create Sale";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            // 
            // btnVehicleSelect
            // 
            this.btnVehicleSelect.Location = new System.Drawing.Point(324, 38);
            this.btnVehicleSelect.Name = "btnVehicleSelect";
            this.btnVehicleSelect.Size = new System.Drawing.Size(75, 27);
            this.btnVehicleSelect.TabIndex = 1;
            this.btnVehicleSelect.Text = "Select";
            this.btnVehicleSelect.UseVisualStyleBackColor = true;
            // 
            // btnAddonAdd
            // 
            this.btnAddonAdd.Location = new System.Drawing.Point(324, 107);
            this.btnAddonAdd.Name = "btnAddonAdd";
            this.btnAddonAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAddonAdd.TabIndex = 2;
            this.btnAddonAdd.Text = "Add";
            this.btnAddonAdd.UseVisualStyleBackColor = true;
            // 
            // cblAddon
            // 
            this.cblAddon.FormattingEnabled = true;
            this.cblAddon.Location = new System.Drawing.Point(58, 107);
            this.cblAddon.Name = "cblAddon";
            this.cblAddon.Size = new System.Drawing.Size(245, 88);
            this.cblAddon.TabIndex = 3;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(58, 38);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(245, 27);
            this.cbVehicle.TabIndex = 4;
            // 
            // btnTradeVehicleAdd
            // 
            this.btnTradeVehicleAdd.Location = new System.Drawing.Point(58, 239);
            this.btnTradeVehicleAdd.Name = "btnTradeVehicleAdd";
            this.btnTradeVehicleAdd.Size = new System.Drawing.Size(204, 27);
            this.btnTradeVehicleAdd.TabIndex = 6;
            this.btnTradeVehicleAdd.Text = "Add Vehicle";
            this.btnTradeVehicleAdd.UseVisualStyleBackColor = true;
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.Location = new System.Drawing.Point(58, 313);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.Size = new System.Drawing.Size(245, 98);
            this.txtOrderSummary.TabIndex = 7;
            // 
            // lblVehicleSelect
            // 
            this.lblVehicleSelect.AutoSize = true;
            this.lblVehicleSelect.Location = new System.Drawing.Point(54, 16);
            this.lblVehicleSelect.Name = "lblVehicleSelect";
            this.lblVehicleSelect.Size = new System.Drawing.Size(72, 19);
            this.lblVehicleSelect.TabIndex = 8;
            this.lblVehicleSelect.Text = "Vehicle";
            // 
            // lblAddonAdd
            // 
            this.lblAddonAdd.AutoSize = true;
            this.lblAddonAdd.Location = new System.Drawing.Point(54, 85);
            this.lblAddonAdd.Name = "lblAddonAdd";
            this.lblAddonAdd.Size = new System.Drawing.Size(54, 19);
            this.lblAddonAdd.TabIndex = 9;
            this.lblAddonAdd.Text = "Addon";
            // 
            // lblTradeVehicleAdd
            // 
            this.lblTradeVehicleAdd.AutoSize = true;
            this.lblTradeVehicleAdd.Location = new System.Drawing.Point(54, 217);
            this.lblTradeVehicleAdd.Name = "lblTradeVehicleAdd";
            this.lblTradeVehicleAdd.Size = new System.Drawing.Size(153, 19);
            this.lblTradeVehicleAdd.TabIndex = 10;
            this.lblTradeVehicleAdd.Text = "Trade-In Vehicle";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(54, 291);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(126, 19);
            this.lblOrderSummary.TabIndex = 11;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // SaleInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 507);
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
            this.Text = "SaleInstance";
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
    }
}