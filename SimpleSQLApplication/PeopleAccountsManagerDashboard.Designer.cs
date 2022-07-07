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
            this.SuspendLayout();
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.DimGray;
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createUserButton.Location = new System.Drawing.Point(129, 260);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(165, 80);
            this.createUserButton.TabIndex = 0;
            this.createUserButton.Text = "Create";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // viewUserButton
            // 
            this.viewUserButton.BackColor = System.Drawing.Color.DimGray;
            this.viewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewUserButton.Location = new System.Drawing.Point(523, 260);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(165, 80);
            this.viewUserButton.TabIndex = 1;
            this.viewUserButton.Text = "View";
            this.viewUserButton.UseVisualStyleBackColor = false;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // userNameDropDown
            // 
            this.userNameDropDown.FormattingEnabled = true;
            this.userNameDropDown.Location = new System.Drawing.Point(209, 147);
            this.userNameDropDown.Name = "userNameDropDown";
            this.userNameDropDown.Size = new System.Drawing.Size(412, 38);
            this.userNameDropDown.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(186, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(459, 47);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "People Accounts Dashboard";
            // 
            // PeopleAccountsManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 421);
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
    }
}