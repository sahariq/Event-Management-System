namespace projectiteration2
{
    partial class VendorSponsorDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BidSubmissionTab = new System.Windows.Forms.TabPage();
            this.SubitBidButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceNeededColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileManagementTab = new System.Windows.Forms.TabPage();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactDetailsTextBox = new System.Windows.Forms.TextBox();
            this.BusinessNameTextBox = new System.Windows.Forms.TextBox();
            this.ContractsTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EventNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractEndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.BidSubmissionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ProfileManagementTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ContractsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BidSubmissionTab);
            this.tabControl1.Controls.Add(this.ProfileManagementTab);
            this.tabControl1.Controls.Add(this.ContractsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // BidSubmissionTab
            // 
            this.BidSubmissionTab.BackColor = System.Drawing.Color.Navy;
            this.BidSubmissionTab.Controls.Add(this.label4);
            this.BidSubmissionTab.Controls.Add(this.SubitBidButton);
            this.BidSubmissionTab.Controls.Add(this.dataGridView1);
            this.BidSubmissionTab.Location = new System.Drawing.Point(4, 22);
            this.BidSubmissionTab.Name = "BidSubmissionTab";
            this.BidSubmissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.BidSubmissionTab.Size = new System.Drawing.Size(792, 424);
            this.BidSubmissionTab.TabIndex = 0;
            this.BidSubmissionTab.Text = "Bid Submission";
            this.BidSubmissionTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SubitBidButton
            // 
            this.SubitBidButton.BackColor = System.Drawing.Color.OldLace;
            this.SubitBidButton.Location = new System.Drawing.Point(709, 393);
            this.SubitBidButton.Name = "SubitBidButton";
            this.SubitBidButton.Size = new System.Drawing.Size(75, 23);
            this.SubitBidButton.TabIndex = 1;
            this.SubitBidButton.Text = "Submit Bid";
            this.SubitBidButton.UseVisualStyleBackColor = false;
            this.SubitBidButton.Click += new System.EventHandler(this.SubitBidButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventTitleColumn,
            this.ServiceNeededColumn,
            this.BidStatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(82, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EventTitleColumn
            // 
            this.EventTitleColumn.HeaderText = "Event Title";
            this.EventTitleColumn.Name = "EventTitleColumn";
            // 
            // ServiceNeededColumn
            // 
            this.ServiceNeededColumn.HeaderText = "Service Needed";
            this.ServiceNeededColumn.Name = "ServiceNeededColumn";
            // 
            // BidStatusColumn
            // 
            this.BidStatusColumn.HeaderText = "Bid Status";
            this.BidStatusColumn.Name = "BidStatusColumn";
            // 
            // ProfileManagementTab
            // 
            this.ProfileManagementTab.BackColor = System.Drawing.Color.Navy;
            this.ProfileManagementTab.Controls.Add(this.label5);
            this.ProfileManagementTab.Controls.Add(this.SaveChangesButton);
            this.ProfileManagementTab.Controls.Add(this.groupBox1);
            this.ProfileManagementTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfileManagementTab.Location = new System.Drawing.Point(4, 22);
            this.ProfileManagementTab.Name = "ProfileManagementTab";
            this.ProfileManagementTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileManagementTab.Size = new System.Drawing.Size(792, 424);
            this.ProfileManagementTab.TabIndex = 1;
            this.ProfileManagementTab.Text = "Profile Management";
            this.ProfileManagementTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveChangesButton.Location = new System.Drawing.Point(698, 384);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ContactDetailsTextBox);
            this.groupBox1.Controls.Add(this.BusinessNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(152, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Business Name";
            // 
            // ContactDetailsTextBox
            // 
            this.ContactDetailsTextBox.Location = new System.Drawing.Point(22, 105);
            this.ContactDetailsTextBox.Name = "ContactDetailsTextBox";
            this.ContactDetailsTextBox.Size = new System.Drawing.Size(176, 20);
            this.ContactDetailsTextBox.TabIndex = 1;
            // 
            // BusinessNameTextBox
            // 
            this.BusinessNameTextBox.Location = new System.Drawing.Point(22, 55);
            this.BusinessNameTextBox.Name = "BusinessNameTextBox";
            this.BusinessNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.BusinessNameTextBox.TabIndex = 0;
            // 
            // ContractsTab
            // 
            this.ContractsTab.BackColor = System.Drawing.Color.Navy;
            this.ContractsTab.Controls.Add(this.label6);
            this.ContractsTab.Controls.Add(this.dataGridView2);
            this.ContractsTab.Location = new System.Drawing.Point(4, 22);
            this.ContractsTab.Name = "ContractsTab";
            this.ContractsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContractsTab.Size = new System.Drawing.Size(792, 424);
            this.ContractsTab.TabIndex = 2;
            this.ContractsTab.Text = "Contracts";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNameColumn,
            this.ContractStartDateColumn,
            this.ContractEndDateColumn,
            this.PaymentStatusColumn});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(64, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(631, 299);
            this.dataGridView2.TabIndex = 0;
            // 
            // EventNameColumn
            // 
            this.EventNameColumn.HeaderText = "Event Name";
            this.EventNameColumn.Name = "EventNameColumn";
            // 
            // ContractStartDateColumn
            // 
            this.ContractStartDateColumn.HeaderText = "Contract Start Date";
            this.ContractStartDateColumn.Name = "ContractStartDateColumn";
            // 
            // ContractEndDateColumn
            // 
            this.ContractEndDateColumn.HeaderText = "Contract End Date";
            this.ContractEndDateColumn.Name = "ContractEndDateColumn";
            // 
            // PaymentStatusColumn
            // 
            this.PaymentStatusColumn.HeaderText = "Payment Status";
            this.PaymentStatusColumn.Name = "PaymentStatusColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(77, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bid Submission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profile Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(68, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contracts";
            // 
            // VendorSponsorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "VendorSponsorDashboard";
            this.Text = "VendorSponsorDashboard";
            this.tabControl1.ResumeLayout(false);
            this.BidSubmissionTab.ResumeLayout(false);
            this.BidSubmissionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ProfileManagementTab.ResumeLayout(false);
            this.ProfileManagementTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ContractsTab.ResumeLayout(false);
            this.ContractsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BidSubmissionTab;
        private System.Windows.Forms.TabPage ProfileManagementTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNeededColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidStatusColumn;
        private System.Windows.Forms.Button SubitBidButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage ContractsTab;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContactDetailsTextBox;
        private System.Windows.Forms.TextBox BusinessNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractEndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatusColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}