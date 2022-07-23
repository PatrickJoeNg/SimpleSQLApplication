namespace SimpleSQLApplication
{
    partial class PeopleAccountsManagerDashboard
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
            this.createUserButton = new System.Windows.Forms.Button();
            this.viewUserButton = new System.Windows.Forms.Button();
            this.userNameDropDown = new System.Windows.Forms.ComboBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.userHeaderLabel = new System.Windows.Forms.Label();
            this.companyHeaderLabel = new System.Windows.Forms.Label();
            this.companyNameDropDown = new System.Windows.Forms.ComboBox();
            this.createNewCompany = new System.Windows.Forms.Button();
            this.viewCompanyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.DimGray;
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createUserButton.Location = new System.Drawing.Point(51, 249);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(165, 80);
            this.createUserButton.TabIndex = 0;
            this.createUserButton.Text = "Create New User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // viewUserButton
            // 
            this.viewUserButton.BackColor = System.Drawing.Color.DimGray;
            this.viewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewUserButton.Location = new System.Drawing.Point(234, 249);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(165, 80);
            this.viewUserButton.TabIndex = 1;
            this.viewUserButton.Text = "View User Info";
            this.viewUserButton.UseVisualStyleBackColor = false;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // userNameDropDown
            // 
            this.userNameDropDown.FormattingEnabled = true;
            this.userNameDropDown.Location = new System.Drawing.Point(51, 179);
            this.userNameDropDown.Name = "userNameDropDown";
            this.userNameDropDown.Size = new System.Drawing.Size(348, 38);
            this.userNameDropDown.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(264, 31);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(459, 47);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "People Accounts Dashboard";
            // 
            // userHeaderLabel
            // 
            this.userHeaderLabel.AutoSize = true;
            this.userHeaderLabel.Location = new System.Drawing.Point(175, 127);
            this.userHeaderLabel.Name = "userHeaderLabel";
            this.userHeaderLabel.Size = new System.Drawing.Size(97, 30);
            this.userHeaderLabel.TabIndex = 4;
            this.userHeaderLabel.Text = "User Info";
            // 
            // companyHeaderLabel
            // 
            this.companyHeaderLabel.AutoSize = true;
            this.companyHeaderLabel.Location = new System.Drawing.Point(672, 127);
            this.companyHeaderLabel.Name = "companyHeaderLabel";
            this.companyHeaderLabel.Size = new System.Drawing.Size(144, 30);
            this.companyHeaderLabel.TabIndex = 5;
            this.companyHeaderLabel.Text = "Company Info";
            // 
            // companyNameDropDown
            // 
            this.companyNameDropDown.FormattingEnabled = true;
            this.companyNameDropDown.Location = new System.Drawing.Point(566, 179);
            this.companyNameDropDown.Name = "companyNameDropDown";
            this.companyNameDropDown.Size = new System.Drawing.Size(348, 38);
            this.companyNameDropDown.TabIndex = 6;
            // 
            // createNewCompany
            // 
            this.createNewCompany.BackColor = System.Drawing.Color.DimGray;
            this.createNewCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewCompany.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createNewCompany.Location = new System.Drawing.Point(566, 249);
            this.createNewCompany.Name = "createNewCompany";
            this.createNewCompany.Size = new System.Drawing.Size(165, 80);
            this.createNewCompany.TabIndex = 7;
            this.createNewCompany.Text = "Create New Company";
            this.createNewCompany.UseVisualStyleBackColor = false;
            // 
            // viewCompanyButton
            // 
            this.viewCompanyButton.BackColor = System.Drawing.Color.DimGray;
            this.viewCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCompanyButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewCompanyButton.Location = new System.Drawing.Point(749, 249);
            this.viewCompanyButton.Name = "viewCompanyButton";
            this.viewCompanyButton.Size = new System.Drawing.Size(165, 80);
            this.viewCompanyButton.TabIndex = 8;
            this.viewCompanyButton.Text = "View Company Button";
            this.viewCompanyButton.UseVisualStyleBackColor = false;
            // 
            // PeopleAccountsManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 443);
            this.Controls.Add(this.viewCompanyButton);
            this.Controls.Add(this.createNewCompany);
            this.Controls.Add(this.companyNameDropDown);
            this.Controls.Add(this.companyHeaderLabel);
            this.Controls.Add(this.userHeaderLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.userNameDropDown);
            this.Controls.Add(this.viewUserButton);
            this.Controls.Add(this.createUserButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PeopleAccountsManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People Accounts Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createUserButton;
        private Button viewUserButton;
        private ComboBox userNameDropDown;
        private Label headerLabel;
        private Label userHeaderLabel;
        private Label companyHeaderLabel;
        private ComboBox companyNameDropDown;
        private Button createNewCompany;
        private Button viewCompanyButton;
    }
}