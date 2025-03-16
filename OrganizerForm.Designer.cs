namespace projectiteration2
{
    partial class OrganizerForm
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
            this.OrganizerTabControl = new System.Windows.Forms.TabControl();
            this.EventManagementTab = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateEventTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TicketTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.EventDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventTitleTextBox = new System.Windows.Forms.TextBox();
            this.AttendeeListTab = new System.Windows.Forms.TabPage();
            this.RegisteredAttendees = new System.Windows.Forms.DataGridView();
            this.AttendeeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceAllocationTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResourceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ResourceNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OrganizerTabControl.SuspendLayout();
            this.EventManagementTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CreateEventTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            this.AttendeeListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredAttendees)).BeginInit();
            this.ResourceAllocationTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizerTabControl
            // 
            this.OrganizerTabControl.Controls.Add(this.EventManagementTab);
            this.OrganizerTabControl.Controls.Add(this.CreateEventTab);
            this.OrganizerTabControl.Controls.Add(this.AttendeeListTab);
            this.OrganizerTabControl.Controls.Add(this.ResourceAllocationTab);
            this.OrganizerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganizerTabControl.Location = new System.Drawing.Point(0, 0);
            this.OrganizerTabControl.Name = "OrganizerTabControl";
            this.OrganizerTabControl.SelectedIndex = 0;
            this.OrganizerTabControl.Size = new System.Drawing.Size(800, 450);
            this.OrganizerTabControl.TabIndex = 0;
            // 
            // EventManagementTab
            // 
            this.EventManagementTab.BackColor = System.Drawing.Color.Navy;
            this.EventManagementTab.Controls.Add(this.label11);
            this.EventManagementTab.Controls.Add(this.DeleteButton);
            this.EventManagementTab.Controls.Add(this.EditButton);
            this.EventManagementTab.Controls.Add(this.dataGridView1);
            this.EventManagementTab.Location = new System.Drawing.Point(4, 22);
            this.EventManagementTab.Name = "EventManagementTab";
            this.EventManagementTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventManagementTab.Size = new System.Drawing.Size(792, 424);
            this.EventManagementTab.TabIndex = 0;
            this.EventManagementTab.Text = "Event Management";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(714, 393);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(633, 393);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventTitleColumn,
            this.DateRangeColumn,
            this.LocationColumn,
            this.StatusColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(59, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // EventTitleColumn
            // 
            this.EventTitleColumn.HeaderText = "Event Title";
            this.EventTitleColumn.Name = "EventTitleColumn";
            // 
            // DateRangeColumn
            // 
            this.DateRangeColumn.HeaderText = "Date Range";
            this.DateRangeColumn.Name = "DateRangeColumn";
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // CreateEventTab
            // 
            this.CreateEventTab.BackColor = System.Drawing.Color.Navy;
            this.CreateEventTab.Controls.Add(this.label12);
            this.CreateEventTab.Controls.Add(this.groupBox1);
            this.CreateEventTab.Location = new System.Drawing.Point(4, 22);
            this.CreateEventTab.Name = "CreateEventTab";
            this.CreateEventTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateEventTab.Size = new System.Drawing.Size(792, 424);
            this.CreateEventTab.TabIndex = 1;
            this.CreateEventTab.Text = "Create Event";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PriceNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TicketTypeComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EndDateTimePicker);
            this.groupBox1.Controls.Add(this.StartDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LocationTextBox);
            this.groupBox1.Controls.Add(this.EventDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EventTitleTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(74, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CreateButton
            // 
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(424, 275);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price:";
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(24, 275);
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PriceNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ticket Type:";
            // 
            // TicketTypeComboBox
            // 
            this.TicketTypeComboBox.FormattingEnabled = true;
            this.TicketTypeComboBox.Location = new System.Drawing.Point(23, 228);
            this.TicketTypeComboBox.Name = "TicketTypeComboBox";
            this.TicketTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TicketTypeComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Date:";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(299, 179);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDateTimePicker.TabIndex = 7;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StartDateTimePicker.Location = new System.Drawing.Point(23, 179);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(241, 43);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(195, 20);
            this.LocationTextBox.TabIndex = 4;
            // 
            // EventDescriptionTextBox
            // 
            this.EventDescriptionTextBox.Location = new System.Drawing.Point(23, 94);
            this.EventDescriptionTextBox.Name = "EventDescriptionTextBox";
            this.EventDescriptionTextBox.Size = new System.Drawing.Size(413, 56);
            this.EventDescriptionTextBox.TabIndex = 3;
            this.EventDescriptionTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Title";
            // 
            // EventTitleTextBox
            // 
            this.EventTitleTextBox.Location = new System.Drawing.Point(23, 43);
            this.EventTitleTextBox.Name = "EventTitleTextBox";
            this.EventTitleTextBox.Size = new System.Drawing.Size(172, 20);
            this.EventTitleTextBox.TabIndex = 0;
            // 
            // AttendeeListTab
            // 
            this.AttendeeListTab.BackColor = System.Drawing.Color.Navy;
            this.AttendeeListTab.Controls.Add(this.label13);
            this.AttendeeListTab.Controls.Add(this.RegisteredAttendees);
            this.AttendeeListTab.Location = new System.Drawing.Point(4, 22);
            this.AttendeeListTab.Name = "AttendeeListTab";
            this.AttendeeListTab.Padding = new System.Windows.Forms.Padding(3);
            this.AttendeeListTab.Size = new System.Drawing.Size(792, 424);
            this.AttendeeListTab.TabIndex = 2;
            this.AttendeeListTab.Text = "Attendee List";
            // 
            // RegisteredAttendees
            // 
            this.RegisteredAttendees.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.RegisteredAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisteredAttendees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendeeNameColumn,
            this.EmailColumn,
            this.TicketTypeColumn});
            this.RegisteredAttendees.Location = new System.Drawing.Point(113, 86);
            this.RegisteredAttendees.Name = "RegisteredAttendees";
            this.RegisteredAttendees.Size = new System.Drawing.Size(577, 276);
            this.RegisteredAttendees.TabIndex = 0;
            // 
            // AttendeeNameColumn
            // 
            this.AttendeeNameColumn.HeaderText = "Attendee Name";
            this.AttendeeNameColumn.Name = "AttendeeNameColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // TicketTypeColumn
            // 
            this.TicketTypeColumn.HeaderText = "Ticket Type";
            this.TicketTypeColumn.Name = "TicketTypeColumn";
            // 
            // ResourceAllocationTab
            // 
            this.ResourceAllocationTab.BackColor = System.Drawing.Color.Navy;
            this.ResourceAllocationTab.Controls.Add(this.label10);
            this.ResourceAllocationTab.Controls.Add(this.groupBox2);
            this.ResourceAllocationTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResourceAllocationTab.Location = new System.Drawing.Point(4, 22);
            this.ResourceAllocationTab.Name = "ResourceAllocationTab";
            this.ResourceAllocationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResourceAllocationTab.Size = new System.Drawing.Size(792, 424);
            this.ResourceAllocationTab.TabIndex = 3;
            this.ResourceAllocationTab.Text = "Resource Allocation";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ResourceTypeComboBox);
            this.groupBox2.Controls.Add(this.ResourceNameTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(181, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 256);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(29, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Resource";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ResourceTypeComboBox
            // 
            this.ResourceTypeComboBox.FormattingEnabled = true;
            this.ResourceTypeComboBox.Location = new System.Drawing.Point(29, 124);
            this.ResourceTypeComboBox.Name = "ResourceTypeComboBox";
            this.ResourceTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ResourceTypeComboBox.TabIndex = 4;
            // 
            // ResourceNameTextBox
            // 
            this.ResourceNameTextBox.Location = new System.Drawing.Point(29, 56);
            this.ResourceNameTextBox.Name = "ResourceNameTextBox";
            this.ResourceNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResourceNameTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Resource Type:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Resource Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Resource Allocation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(54, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Event Management";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(80, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Create Event";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(108, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Attendee List";
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrganizerTabControl);
            this.Name = "OrganizerForm";
            this.Text = "OrganizerForm";
            this.OrganizerTabControl.ResumeLayout(false);
            this.EventManagementTab.ResumeLayout(false);
            this.EventManagementTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CreateEventTab.ResumeLayout(false);
            this.CreateEventTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            this.AttendeeListTab.ResumeLayout(false);
            this.AttendeeListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredAttendees)).EndInit();
            this.ResourceAllocationTab.ResumeLayout(false);
            this.ResourceAllocationTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OrganizerTabControl;
        private System.Windows.Forms.TabPage EventManagementTab;
        private System.Windows.Forms.TabPage CreateEventTab;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRangeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.TabPage AttendeeListTab;
        private System.Windows.Forms.TabPage ResourceAllocationTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.RichTextBox EventDescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EventTitleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TicketTypeComboBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView RegisteredAttendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketTypeColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ResourceNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ResourceTypeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}