namespace IMS_GUI
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLoginHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLectureMsg1 = new System.Windows.Forms.Label();
            this.lblLectureMsg2 = new System.Windows.Forms.Label();
            this.lblLectureMsg3 = new System.Windows.Forms.Label();
            this.lblLectureMsg4 = new System.Windows.Forms.Label();
            this.lblLectureMsg5 = new System.Windows.Forms.Label();
            this.lblLectureMsg6 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(59, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(279, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Please enter your IMS username";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(99, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 35);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(63, 130);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(275, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // lblLoginHeading
            // 
            this.lblLoginHeading.AutoSize = true;
            this.lblLoginHeading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLoginHeading.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginHeading.Location = new System.Drawing.Point(12, 23);
            this.lblLoginHeading.Name = "lblLoginHeading";
            this.lblLoginHeading.Size = new System.Drawing.Size(194, 28);
            this.lblLoginHeading.TabIndex = 3;
            this.lblLoginHeading.Text = "HTV IMS Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 88);
            this.panel1.TabIndex = 4;
            // 
            // lblLectureMsg1
            // 
            this.lblLectureMsg1.AutoSize = true;
            this.lblLectureMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureMsg1.Location = new System.Drawing.Point(14, 246);
            this.lblLectureMsg1.Name = "lblLectureMsg1";
            this.lblLectureMsg1.Size = new System.Drawing.Size(263, 13);
            this.lblLectureMsg1.TabIndex = 5;
            this.lblLectureMsg1.Text = "Lecturer Message: This is the home screen.  ";
            // 
            // lblLectureMsg2
            // 
            this.lblLectureMsg2.AutoSize = true;
            this.lblLectureMsg2.Location = new System.Drawing.Point(17, 267);
            this.lblLectureMsg2.Name = "lblLectureMsg2";
            this.lblLectureMsg2.Size = new System.Drawing.Size(109, 13);
            this.lblLectureMsg2.TabIndex = 6;
            this.lblLectureMsg2.Text = "Sales Username: S10";
            // 
            // lblLectureMsg3
            // 
            this.lblLectureMsg3.AutoSize = true;
            this.lblLectureMsg3.Location = new System.Drawing.Point(17, 284);
            this.lblLectureMsg3.Name = "lblLectureMsg3";
            this.lblLectureMsg3.Size = new System.Drawing.Size(140, 13);
            this.lblLectureMsg3.TabIndex = 7;
            this.lblLectureMsg3.Text = "Accounting Username: S20 ";
            // 
            // lblLectureMsg4
            // 
            this.lblLectureMsg4.AutoSize = true;
            this.lblLectureMsg4.Location = new System.Drawing.Point(18, 304);
            this.lblLectureMsg4.Name = "lblLectureMsg4";
            this.lblLectureMsg4.Size = new System.Drawing.Size(148, 13);
            this.lblLectureMsg4.TabIndex = 8;
            this.lblLectureMsg4.Text = "Management Username:  S30";
            // 
            // lblLectureMsg5
            // 
            this.lblLectureMsg5.AutoSize = true;
            this.lblLectureMsg5.Location = new System.Drawing.Point(18, 322);
            this.lblLectureMsg5.Name = "lblLectureMsg5";
            this.lblLectureMsg5.Size = new System.Drawing.Size(118, 13);
            this.lblLectureMsg5.TabIndex = 9;
            this.lblLectureMsg5.Text = "Garage Username: S40";
            // 
            // lblLectureMsg6
            // 
            this.lblLectureMsg6.AutoSize = true;
            this.lblLectureMsg6.LinkArea = new System.Windows.Forms.LinkArea(24, 46);
            this.lblLectureMsg6.Location = new System.Drawing.Point(18, 345);
            this.lblLectureMsg6.Name = "lblLectureMsg6";
            this.lblLectureMsg6.Size = new System.Drawing.Size(235, 17);
            this.lblLectureMsg6.TabIndex = 10;
            this.lblLectureMsg6.TabStop = true;
            this.lblLectureMsg6.Text = "For more help, please : https://bit.ly/2HBoOeX";
            this.lblLectureMsg6.UseCompatibleTextRendering = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 367);
            this.Controls.Add(this.lblLectureMsg6);
            this.Controls.Add(this.lblLectureMsg5);
            this.Controls.Add(this.lblLectureMsg4);
            this.Controls.Add(this.lblLectureMsg3);
            this.Controls.Add(this.lblLectureMsg2);
            this.Controls.Add(this.lblLectureMsg1);
            this.Controls.Add(this.lblLoginHeading);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLectureMsg1;
        private System.Windows.Forms.Label lblLectureMsg2;
        private System.Windows.Forms.Label lblLectureMsg3;
        private System.Windows.Forms.Label lblLectureMsg4;
        private System.Windows.Forms.Label lblLectureMsg5;
        private System.Windows.Forms.LinkLabel lblLectureMsg6;
    }
}