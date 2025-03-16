namespace projectiteration2
{
    partial class AdminForm
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
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.UserManagementPage = new System.Windows.Forms.TabPage();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventApprovalPage = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EventTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmissionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportsDashboardTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminTabControl.SuspendLayout();
            this.UserManagementPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EventApprovalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ReportsDashboardTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.UserManagementPage);
            this.AdminTabControl.Controls.Add(this.EventApprovalPage);
            this.AdminTabControl.Controls.Add(this.ReportsDashboardTab);
            this.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTabControl.Location = new System.Drawing.Point(0, 0);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(800, 450);
            this.AdminTabControl.TabIndex = 0;
            // 
            // UserManagementPage
            // 
            this.UserManagementPage.BackColor = System.Drawing.Color.Navy;
            this.UserManagementPage.Controls.Add(this.label2);
            this.UserManagementPage.Controls.Add(this.ActivateButton);
            this.UserManagementPage.Controls.Add(this.EditButton);
            this.UserManagementPage.Controls.Add(this.dataGridView1);
            this.UserManagementPage.Location = new System.Drawing.Point(4, 22);
            this.UserManagementPage.Name = "UserManagementPage";
            this.UserManagementPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserManagementPage.Size = new System.Drawing.Size(792, 424);
            this.UserManagementPage.TabIndex = 0;
            this.UserManagementPage.Text = "User Management";
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(655, 393);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(129, 23);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Deactivate/Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(574, 393);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.RoleColumn,
            this.StatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(60, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // RoleColumn
            // 
            this.RoleColumn.HeaderText = "Role";
            this.RoleColumn.Name = "RoleColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // EventApprovalPage
            // 
            this.EventApprovalPage.BackColor = System.Drawing.Color.Navy;
            this.EventApprovalPage.Controls.Add(this.label3);
            this.EventApprovalPage.Controls.Add(this.DeleteButton);
            this.EventApprovalPage.Controls.Add(this.ApproveButton);
            this.EventApprovalPage.Controls.Add(this.dataGridView2);
            this.EventApprovalPage.Location = new System.Drawing.Point(4, 22);
            this.EventApprovalPage.Name = "EventApprovalPage";
            this.EventApprovalPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventApprovalPage.Size = new System.Drawing.Size(792, 424);
            this.EventApprovalPage.TabIndex = 1;
            this.EventApprovalPage.Text = "Event Approval";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(709, 393);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(628, 393);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveButton.TabIndex = 1;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventTitleColumn,
            this.OrganizerNameColumn,
            this.SubmissionDateColumn,
            this.StatusColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(63, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(659, 292);
            this.dataGridView2.TabIndex = 0;
            // 
            // EventTitleColumn
            // 
            this.EventTitleColumn.HeaderText = "Event Title";
            this.EventTitleColumn.Name = "EventTitleColumn";
            // 
            // OrganizerNameColumn
            // 
            this.OrganizerNameColumn.HeaderText = "Organizer Name";
            this.OrganizerNameColumn.Name = "OrganizerNameColumn";
            // 
            // SubmissionDateColumn
            // 
            this.SubmissionDateColumn.HeaderText = "Submission Date";
            this.SubmissionDateColumn.Name = "SubmissionDateColumn";
            // 
            // StatusColumn1
            // 
            this.StatusColumn1.HeaderText = "Status";
            this.StatusColumn1.Name = "StatusColumn1";
            // 
            // ReportsDashboardTab
            // 
            this.ReportsDashboardTab.BackColor = System.Drawing.Color.Navy;
            this.ReportsDashboardTab.Controls.Add(this.label4);
            this.ReportsDashboardTab.Controls.Add(this.groupBox1);
            this.ReportsDashboardTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportsDashboardTab.Location = new System.Drawing.Point(4, 22);
            this.ReportsDashboardTab.Name = "ReportsDashboardTab";
            this.ReportsDashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsDashboardTab.Size = new System.Drawing.Size(792, 424);
            this.ReportsDashboardTab.TabIndex = 2;
            this.ReportsDashboardTab.Text = "Reports Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(231, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateButton.Location = new System.Drawing.Point(250, 160);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Report:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Attendance Report",
            "",
            "Revenue Report",
            "",
            "Event Feedback Report"});
            this.comboBox1.Location = new System.Drawing.Point(6, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event Approval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reports Dashboard";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminTabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.AdminTabControl.ResumeLayout(false);
            this.UserManagementPage.ResumeLayout(false);
            this.UserManagementPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EventApprovalPage.ResumeLayout(false);
            this.EventApprovalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ReportsDashboardTab.ResumeLayout(false);
            this.ReportsDashboardTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage UserManagementPage;
        private System.Windows.Forms.TabPage EventApprovalPage;
        private System.Windows.Forms.TabPage ReportsDashboardTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmissionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}