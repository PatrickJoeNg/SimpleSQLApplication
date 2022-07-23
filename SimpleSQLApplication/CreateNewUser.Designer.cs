namespace SimpleSQLApplication
{
    partial class CreateNewUser
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.newUserGroupBox = new System.Windows.Forms.GroupBox();
            this.companyNameDropDown = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.phoneValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.newUserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(28, 30);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(258, 45);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Create New User";
            // 
            // newUserGroupBox
            // 
            this.newUserGroupBox.Controls.Add(this.companyNameDropDown);
            this.newUserGroupBox.Controls.Add(this.companyLabel);
            this.newUserGroupBox.Controls.Add(this.phoneValue);
            this.newUserGroupBox.Controls.Add(this.emailValue);
            this.newUserGroupBox.Controls.Add(this.lastNameValue);
            this.newUserGroupBox.Controls.Add(this.firstNameValue);
            this.newUserGroupBox.Controls.Add(this.lastNameLabel);
            this.newUserGroupBox.Controls.Add(this.emailLabel);
            this.newUserGroupBox.Controls.Add(this.phoneLabel);
            this.newUserGroupBox.Controls.Add(this.firstNameLabel);
            this.newUserGroupBox.Location = new System.Drawing.Point(35, 125);
            this.newUserGroupBox.Name = "newUserGroupBox";
            this.newUserGroupBox.Size = new System.Drawing.Size(544, 339);
            this.newUserGroupBox.TabIndex = 1;
            this.newUserGroupBox.TabStop = false;
            this.newUserGroupBox.Text = "User Info";
            // 
            // companyNameDropDown
            // 
            this.companyNameDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyNameDropDown.FormattingEnabled = true;
            this.companyNameDropDown.Location = new System.Drawing.Point(230, 281);
            this.companyNameDropDown.Name = "companyNameDropDown";
            this.companyNameDropDown.Size = new System.Drawing.Size(286, 38);
            this.companyNameDropDown.TabIndex = 3;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyLabel.Location = new System.Drawing.Point(6, 278);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(137, 37);
            this.companyLabel.TabIndex = 11;
            this.companyLabel.Text = "Company:";
            // 
            // phoneValue
            // 
            this.phoneValue.Location = new System.Drawing.Point(234, 228);
            this.phoneValue.Name = "phoneValue";
            this.phoneValue.Size = new System.Drawing.Size(282, 35);
            this.phoneValue.TabIndex = 10;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(234, 172);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(282, 35);
            this.emailValue.TabIndex = 9;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(234, 113);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(282, 35);
            this.lastNameValue.TabIndex = 8;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(234, 60);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(282, 35);
            this.firstNameValue.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(6, 110);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(148, 37);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(4, 169);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(189, 37);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(6, 225);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(202, 37);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(6, 57);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(150, 37);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.BackColor = System.Drawing.Color.DimGray;
            this.createNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewUserButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createNewUserButton.Location = new System.Drawing.Point(221, 485);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(165, 80);
            this.createNewUserButton.TabIndex = 2;
            this.createNewUserButton.Text = "Create";
            this.createNewUserButton.UseVisualStyleBackColor = false;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButton_Click);
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 603);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.newUserGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.newUserGroupBox.ResumeLayout(false);
            this.newUserGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private GroupBox newUserGroupBox;
        private TextBox phoneValue;
        private TextBox emailValue;
        private TextBox lastNameValue;
        private TextBox firstNameValue;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label firstNameLabel;
        private Button createNewUserButton;
        private Label companyLabel;
        private ComboBox companyNameDropDown;
    }
}