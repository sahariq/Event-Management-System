namespace projectiteration2
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
            this.label1 = new System.Windows.Forms.Label();
            this.RoleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.OrganizerTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.OrganizationTypeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BusinessLicenseTextBox = new System.Windows.Forms.TextBox();
            this.VendorTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.BusinessNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceTypeTextBox = new System.Windows.Forms.TextBox();
            this.SponsorTab = new System.Windows.Forms.TabPage();
            this.SponsorshipTypeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.OrganizerTab.SuspendLayout();
            this.VendorTab.SuspendLayout();
            this.SponsorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register/Log In";
            this.label1.UseWaitCursor = true;
            // 
            // RoleTypeComboBox
            // 
            this.RoleTypeComboBox.FormattingEnabled = true;
            this.RoleTypeComboBox.Items.AddRange(new object[] {
            "Attendee",
            "Organizer",
            "Vendor",
            "Sponsor"});
            this.RoleTypeComboBox.Location = new System.Drawing.Point(69, 196);
            this.RoleTypeComboBox.Name = "RoleTypeComboBox";
            this.RoleTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleTypeComboBox.TabIndex = 1;
            this.RoleTypeComboBox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(68, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role Type:";
            this.label2.UseWaitCursor = true;
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(69, 157);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.Size = new System.Drawing.Size(224, 20);
            this.PasswordTextBox1.TabIndex = 3;
            this.PasswordTextBox1.UseWaitCursor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(69, 118);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(224, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(68, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            this.label3.UseWaitCursor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoSize = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.Navy;
            this.PasswordTextBox.Location = new System.Drawing.Point(68, 141);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(56, 13);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "Password:";
            this.PasswordTextBox.UseWaitCursor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(69, 79);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(68, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            this.label5.UseWaitCursor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterButton.Location = new System.Drawing.Point(67, 362);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.UseWaitCursor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogInButton.Location = new System.Drawing.Point(228, 365);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 12;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.UseWaitCursor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.OrganizerTab);
            this.TabControl.Controls.Add(this.VendorTab);
            this.TabControl.Controls.Add(this.SponsorTab);
            this.TabControl.Location = new System.Drawing.Point(67, 223);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(263, 133);
            this.TabControl.TabIndex = 13;
            this.TabControl.UseWaitCursor = true;
            // 
            // OrganizerTab
            // 
            this.OrganizerTab.Controls.Add(this.label10);
            this.OrganizerTab.Controls.Add(this.OrganizationTypeTextBox);
            this.OrganizerTab.Controls.Add(this.label9);
            this.OrganizerTab.Controls.Add(this.BusinessLicenseTextBox);
            this.OrganizerTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrganizerTab.Location = new System.Drawing.Point(4, 22);
            this.OrganizerTab.Name = "OrganizerTab";
            this.OrganizerTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizerTab.Size = new System.Drawing.Size(255, 107);
            this.OrganizerTab.TabIndex = 0;
            this.OrganizerTab.Text = "Organizer";
            this.OrganizerTab.UseVisualStyleBackColor = true;
            this.OrganizerTab.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Organization Type:";
            this.label10.UseWaitCursor = true;
            // 
            // OrganizationTypeTextBox
            // 
            this.OrganizationTypeTextBox.Location = new System.Drawing.Point(3, 19);
            this.OrganizationTypeTextBox.Name = "OrganizationTypeTextBox";
            this.OrganizationTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrganizationTypeTextBox.TabIndex = 5;
            this.OrganizationTypeTextBox.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Business License:";
            this.label9.UseWaitCursor = true;
            // 
            // BusinessLicenseTextBox
            // 
            this.BusinessLicenseTextBox.Location = new System.Drawing.Point(2, 58);
            this.BusinessLicenseTextBox.Name = "BusinessLicenseTextBox";
            this.BusinessLicenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.BusinessLicenseTextBox.TabIndex = 2;
            this.BusinessLicenseTextBox.UseWaitCursor = true;
            // 
            // VendorTab
            // 
            this.VendorTab.Controls.Add(this.label6);
            this.VendorTab.Controls.Add(this.BusinessNameTextBox);
            this.VendorTab.Controls.Add(this.label4);
            this.VendorTab.Controls.Add(this.ServiceTypeTextBox);
            this.VendorTab.Location = new System.Drawing.Point(4, 22);
            this.VendorTab.Name = "VendorTab";
            this.VendorTab.Padding = new System.Windows.Forms.Padding(3);
            this.VendorTab.Size = new System.Drawing.Size(255, 107);
            this.VendorTab.TabIndex = 1;
            this.VendorTab.Text = "Vendor";
            this.VendorTab.UseVisualStyleBackColor = true;
            this.VendorTab.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Business Name:";
            this.label6.UseWaitCursor = true;
            // 
            // BusinessNameTextBox
            // 
            this.BusinessNameTextBox.Location = new System.Drawing.Point(3, 19);
            this.BusinessNameTextBox.Name = "BusinessNameTextBox";
            this.BusinessNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.BusinessNameTextBox.TabIndex = 3;
            this.BusinessNameTextBox.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service Type:";
            this.label4.UseWaitCursor = true;
            // 
            // ServiceTypeTextBox
            // 
            this.ServiceTypeTextBox.Location = new System.Drawing.Point(3, 58);
            this.ServiceTypeTextBox.Name = "ServiceTypeTextBox";
            this.ServiceTypeTextBox.Size = new System.Drawing.Size(164, 20);
            this.ServiceTypeTextBox.TabIndex = 1;
            this.ServiceTypeTextBox.UseWaitCursor = true;
            // 
            // SponsorTab
            // 
            this.SponsorTab.Controls.Add(this.SponsorshipTypeTextBox);
            this.SponsorTab.Controls.Add(this.label8);
            this.SponsorTab.Controls.Add(this.label7);
            this.SponsorTab.Controls.Add(this.CompanyNameTextBox);
            this.SponsorTab.Location = new System.Drawing.Point(4, 22);
            this.SponsorTab.Name = "SponsorTab";
            this.SponsorTab.Padding = new System.Windows.Forms.Padding(3);
            this.SponsorTab.Size = new System.Drawing.Size(255, 107);
            this.SponsorTab.TabIndex = 2;
            this.SponsorTab.Text = "Sponsor";
            this.SponsorTab.UseVisualStyleBackColor = true;
            this.SponsorTab.UseWaitCursor = true;
            // 
            // SponsorshipTypeTextBox
            // 
            this.SponsorshipTypeTextBox.Location = new System.Drawing.Point(3, 58);
            this.SponsorshipTypeTextBox.Name = "SponsorshipTypeTextBox";
            this.SponsorshipTypeTextBox.Size = new System.Drawing.Size(164, 20);
            this.SponsorshipTypeTextBox.TabIndex = 0;
            this.SponsorshipTypeTextBox.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Company Name:";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sponsorship Type: ";
            this.label7.UseWaitCursor = true;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(3, 19);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.CompanyNameTextBox.TabIndex = 4;
            this.CompanyNameTextBox.UseWaitCursor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleTypeComboBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.TabControl.ResumeLayout(false);
            this.OrganizerTab.ResumeLayout(false);
            this.OrganizerTab.PerformLayout();
            this.VendorTab.ResumeLayout(false);
            this.VendorTab.PerformLayout();
            this.SponsorTab.ResumeLayout(false);
            this.SponsorTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoleTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PasswordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage OrganizerTab;
        private System.Windows.Forms.TabPage VendorTab;
        private System.Windows.Forms.TabPage SponsorTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OrganizationTypeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SponsorshipTypeTextBox;
        private System.Windows.Forms.TextBox ServiceTypeTextBox;
        private System.Windows.Forms.TextBox BusinessLicenseTextBox;
        private System.Windows.Forms.TextBox BusinessNameTextBox;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

