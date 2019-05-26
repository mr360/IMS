namespace IMS_GUI
{
    partial class GarageInstanceForm
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
            this.lblSaleInstanceHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcGarage = new System.Windows.Forms.TabControl();
            this.tbpUnallocatedVehicle = new System.Windows.Forms.TabPage();
            this.lblAssignBay = new System.Windows.Forms.Label();
            this.lbUnassignedVehicle = new System.Windows.Forms.ListBox();
            this.btnAssignVehicleToBay = new System.Windows.Forms.Button();
            this.cbOpenBay = new System.Windows.Forms.ComboBox();
            this.tbpSoldVehicle = new System.Windows.Forms.TabPage();
            this.lblSoldVehicleRemove = new System.Windows.Forms.Label();
            this.lbSoldVehicleRemove = new System.Windows.Forms.ListBox();
            this.btnSoldVehicleRemove = new System.Windows.Forms.Button();
            this.tbpAddEntity = new System.Windows.Forms.TabPage();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.Label();
            this.tbAddDetail = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAddAddon = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbcGarage.SuspendLayout();
            this.tbpUnallocatedVehicle.SuspendLayout();
            this.tbpSoldVehicle.SuspendLayout();
            this.tbpAddEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaleInstanceHeading
            // 
            this.lblSaleInstanceHeading.AutoSize = true;
            this.lblSaleInstanceHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaleInstanceHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleInstanceHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaleInstanceHeading.Location = new System.Drawing.Point(19, 28);
            this.lblSaleInstanceHeading.Name = "lblSaleInstanceHeading";
            this.lblSaleInstanceHeading.Size = new System.Drawing.Size(233, 28);
            this.lblSaleInstanceHeading.TabIndex = 15;
            this.lblSaleInstanceHeading.Text = "HTV Garage Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 88);
            this.panel1.TabIndex = 16;
            // 
            // tbcGarage
            // 
            this.tbcGarage.Controls.Add(this.tbpUnallocatedVehicle);
            this.tbcGarage.Controls.Add(this.tbpSoldVehicle);
            this.tbcGarage.Controls.Add(this.tbpAddEntity);
            this.tbcGarage.Location = new System.Drawing.Point(12, 103);
            this.tbcGarage.Name = "tbcGarage";
            this.tbcGarage.SelectedIndex = 0;
            this.tbcGarage.Size = new System.Drawing.Size(409, 345);
            this.tbcGarage.TabIndex = 17;
            // 
            // tbpUnallocatedVehicle
            // 
            this.tbpUnallocatedVehicle.Controls.Add(this.lblAssignBay);
            this.tbpUnallocatedVehicle.Controls.Add(this.lbUnassignedVehicle);
            this.tbpUnallocatedVehicle.Controls.Add(this.btnAssignVehicleToBay);
            this.tbpUnallocatedVehicle.Controls.Add(this.cbOpenBay);
            this.tbpUnallocatedVehicle.Location = new System.Drawing.Point(4, 28);
            this.tbpUnallocatedVehicle.Name = "tbpUnallocatedVehicle";
            this.tbpUnallocatedVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnallocatedVehicle.Size = new System.Drawing.Size(401, 313);
            this.tbpUnallocatedVehicle.TabIndex = 0;
            this.tbpUnallocatedVehicle.Text = "Unallocated";
            this.tbpUnallocatedVehicle.UseVisualStyleBackColor = true;
            // 
            // lblAssignBay
            // 
            this.lblAssignBay.AutoSize = true;
            this.lblAssignBay.Location = new System.Drawing.Point(13, 19);
            this.lblAssignBay.Name = "lblAssignBay";
            this.lblAssignBay.Size = new System.Drawing.Size(342, 19);
            this.lblAssignBay.TabIndex = 10;
            this.lblAssignBay.Text = "Vehicles waiting to be assigned bays.";
            // 
            // lbUnassignedVehicle
            // 
            this.lbUnassignedVehicle.FormattingEnabled = true;
            this.lbUnassignedVehicle.ItemHeight = 19;
            this.lbUnassignedVehicle.Location = new System.Drawing.Point(15, 50);
            this.lbUnassignedVehicle.Name = "lbUnassignedVehicle";
            this.lbUnassignedVehicle.Size = new System.Drawing.Size(373, 194);
            this.lbUnassignedVehicle.TabIndex = 9;
            // 
            // btnAssignVehicleToBay
            // 
            this.btnAssignVehicleToBay.Location = new System.Drawing.Point(301, 266);
            this.btnAssignVehicleToBay.Name = "btnAssignVehicleToBay";
            this.btnAssignVehicleToBay.Size = new System.Drawing.Size(87, 27);
            this.btnAssignVehicleToBay.TabIndex = 8;
            this.btnAssignVehicleToBay.Text = "Assign";
            this.btnAssignVehicleToBay.UseVisualStyleBackColor = true;
            this.btnAssignVehicleToBay.Click += new System.EventHandler(this.btnAssignVehicleToBay_Click);
            // 
            // cbOpenBay
            // 
            this.cbOpenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpenBay.FormattingEnabled = true;
            this.cbOpenBay.Location = new System.Drawing.Point(15, 266);
            this.cbOpenBay.Name = "cbOpenBay";
            this.cbOpenBay.Size = new System.Drawing.Size(273, 27);
            this.cbOpenBay.TabIndex = 0;
            // 
            // tbpSoldVehicle
            // 
            this.tbpSoldVehicle.Controls.Add(this.lblSoldVehicleRemove);
            this.tbpSoldVehicle.Controls.Add(this.lbSoldVehicleRemove);
            this.tbpSoldVehicle.Controls.Add(this.btnSoldVehicleRemove);
            this.tbpSoldVehicle.Location = new System.Drawing.Point(4, 28);
            this.tbpSoldVehicle.Name = "tbpSoldVehicle";
            this.tbpSoldVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSoldVehicle.Size = new System.Drawing.Size(401, 313);
            this.tbpSoldVehicle.TabIndex = 1;
            this.tbpSoldVehicle.Text = "Sold ";
            this.tbpSoldVehicle.UseVisualStyleBackColor = true;
            // 
            // lblSoldVehicleRemove
            // 
            this.lblSoldVehicleRemove.AutoSize = true;
            this.lblSoldVehicleRemove.Location = new System.Drawing.Point(13, 19);
            this.lblSoldVehicleRemove.Name = "lblSoldVehicleRemove";
            this.lblSoldVehicleRemove.Size = new System.Drawing.Size(234, 19);
            this.lblSoldVehicleRemove.TabIndex = 7;
            this.lblSoldVehicleRemove.Text = "Removal of sold vehicles.";
            // 
            // lbSoldVehicleRemove
            // 
            this.lbSoldVehicleRemove.FormattingEnabled = true;
            this.lbSoldVehicleRemove.ItemHeight = 19;
            this.lbSoldVehicleRemove.Location = new System.Drawing.Point(15, 50);
            this.lbSoldVehicleRemove.Name = "lbSoldVehicleRemove";
            this.lbSoldVehicleRemove.Size = new System.Drawing.Size(373, 194);
            this.lbSoldVehicleRemove.TabIndex = 6;
            // 
            // btnSoldVehicleRemove
            // 
            this.btnSoldVehicleRemove.Location = new System.Drawing.Point(301, 266);
            this.btnSoldVehicleRemove.Name = "btnSoldVehicleRemove";
            this.btnSoldVehicleRemove.Size = new System.Drawing.Size(87, 27);
            this.btnSoldVehicleRemove.TabIndex = 5;
            this.btnSoldVehicleRemove.Text = "Remove";
            this.btnSoldVehicleRemove.UseVisualStyleBackColor = true;
            this.btnSoldVehicleRemove.Click += new System.EventHandler(this.btnSoldVehicleRemove_Click);
            // 
            // tbpAddEntity
            // 
            this.tbpAddEntity.Controls.Add(this.btnAddClear);
            this.tbpAddEntity.Controls.Add(this.btnAddConfirm);
            this.tbpAddEntity.Controls.Add(this.lblDetail);
            this.tbpAddEntity.Controls.Add(this.tbAddDetail);
            this.tbpAddEntity.Controls.Add(this.lblAdd);
            this.tbpAddEntity.Controls.Add(this.btnAddAddon);
            this.tbpAddEntity.Controls.Add(this.btnAddVehicle);
            this.tbpAddEntity.Location = new System.Drawing.Point(4, 28);
            this.tbpAddEntity.Name = "tbpAddEntity";
            this.tbpAddEntity.Size = new System.Drawing.Size(401, 313);
            this.tbpAddEntity.TabIndex = 2;
            this.tbpAddEntity.Text = "Add";
            this.tbpAddEntity.UseVisualStyleBackColor = true;
            // 
            // btnAddClear
            // 
            this.btnAddClear.Location = new System.Drawing.Point(17, 266);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(87, 27);
            this.btnAddClear.TabIndex = 12;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Location = new System.Drawing.Point(301, 266);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(87, 27);
            this.btnAddConfirm.TabIndex = 11;
            this.btnAddConfirm.Text = "Add";
            this.btnAddConfirm.UseVisualStyleBackColor = true;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(13, 105);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(63, 19);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "Detail";
            // 
            // tbAddDetail
            // 
            this.tbAddDetail.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddDetail.Location = new System.Drawing.Point(17, 134);
            this.tbAddDetail.Multiline = true;
            this.tbAddDetail.Name = "tbAddDetail";
            this.tbAddDetail.ReadOnly = true;
            this.tbAddDetail.Size = new System.Drawing.Size(371, 116);
            this.tbAddDetail.TabIndex = 9;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(13, 20);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(261, 19);
            this.lblAdd.TabIndex = 8;
            this.lblAdd.Text = "Add either vehicle or addon.";
            // 
            // btnAddAddon
            // 
            this.btnAddAddon.Location = new System.Drawing.Point(219, 57);
            this.btnAddAddon.Name = "btnAddAddon";
            this.btnAddAddon.Size = new System.Drawing.Size(169, 27);
            this.btnAddAddon.TabIndex = 1;
            this.btnAddAddon.Text = "Addon Detail";
            this.btnAddAddon.UseVisualStyleBackColor = true;
            this.btnAddAddon.Click += new System.EventHandler(this.btnAddAddon_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(17, 57);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(163, 27);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = " Vehicle Detail";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(131, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GarageInstanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 512);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbcGarage);
            this.Controls.Add(this.lblSaleInstanceHeading);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GarageInstanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GarageInstance ";
            this.Load += new System.EventHandler(this.GarageInstanceForm_Load);
            this.tbcGarage.ResumeLayout(false);
            this.tbpUnallocatedVehicle.ResumeLayout(false);
            this.tbpUnallocatedVehicle.PerformLayout();
            this.tbpSoldVehicle.ResumeLayout(false);
            this.tbpSoldVehicle.PerformLayout();
            this.tbpAddEntity.ResumeLayout(false);
            this.tbpAddEntity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleInstanceHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcGarage;
        private System.Windows.Forms.TabPage tbpUnallocatedVehicle;
        private System.Windows.Forms.TabPage tbpSoldVehicle;
        private System.Windows.Forms.TabPage tbpAddEntity;
        private System.Windows.Forms.ComboBox cbOpenBay;
        private System.Windows.Forms.Label lblSoldVehicleRemove;
        private System.Windows.Forms.ListBox lbSoldVehicleRemove;
        private System.Windows.Forms.Button btnSoldVehicleRemove;
        private System.Windows.Forms.Label lblAssignBay;
        private System.Windows.Forms.ListBox lbUnassignedVehicle;
        private System.Windows.Forms.Button btnAssignVehicleToBay;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox tbAddDetail;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnAddAddon;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddClear;
    }
}