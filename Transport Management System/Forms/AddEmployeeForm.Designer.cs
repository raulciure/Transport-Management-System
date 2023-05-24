namespace Transport_Management_System.Forms
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeInfoPanel = new System.Windows.Forms.Panel();
            this.driverRouteTypeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.yearInputWarning = new System.Windows.Forms.Label();
            this.nameInputWarning = new System.Windows.Forms.Label();
            this.salaryInputWarning = new System.Windows.Forms.Label();
            this.birthdayDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.employmentYearTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.employeeInfoPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(5, 5);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(712, 100);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new employee";
            // 
            // employeeInfoPanel
            // 
            this.employeeInfoPanel.Controls.Add(this.driverRouteTypeComboBox);
            this.employeeInfoPanel.Controls.Add(this.employeeTypeComboBox);
            this.employeeInfoPanel.Controls.Add(this.yearInputWarning);
            this.employeeInfoPanel.Controls.Add(this.nameInputWarning);
            this.employeeInfoPanel.Controls.Add(this.salaryInputWarning);
            this.employeeInfoPanel.Controls.Add(this.birthdayDateTimePick);
            this.employeeInfoPanel.Controls.Add(this.salaryTextBox);
            this.employeeInfoPanel.Controls.Add(this.employmentYearTextBox);
            this.employeeInfoPanel.Controls.Add(this.employeeNameTextBox);
            this.employeeInfoPanel.Controls.Add(this.label5);
            this.employeeInfoPanel.Controls.Add(this.label4);
            this.employeeInfoPanel.Controls.Add(this.label3);
            this.employeeInfoPanel.Controls.Add(this.driverLabel);
            this.employeeInfoPanel.Controls.Add(this.label6);
            this.employeeInfoPanel.Controls.Add(this.label2);
            this.employeeInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.employeeInfoPanel.Name = "employeeInfoPanel";
            this.employeeInfoPanel.Size = new System.Drawing.Size(705, 308);
            this.employeeInfoPanel.TabIndex = 3;
            // 
            // driverRouteTypeComboBox
            // 
            this.driverRouteTypeComboBox.FormattingEnabled = true;
            this.driverRouteTypeComboBox.Location = new System.Drawing.Point(263, 229);
            this.driverRouteTypeComboBox.Name = "driverRouteTypeComboBox";
            this.driverRouteTypeComboBox.Size = new System.Drawing.Size(284, 38);
            this.driverRouteTypeComboBox.TabIndex = 5;
            // 
            // employeeTypeComboBox
            // 
            this.employeeTypeComboBox.FormattingEnabled = true;
            this.employeeTypeComboBox.Location = new System.Drawing.Point(263, 13);
            this.employeeTypeComboBox.Name = "employeeTypeComboBox";
            this.employeeTypeComboBox.Size = new System.Drawing.Size(284, 38);
            this.employeeTypeComboBox.TabIndex = 5;
            this.employeeTypeComboBox.SelectedValueChanged += new System.EventHandler(this.employeeTypeComboBox_SelectedValueChanged);
            // 
            // yearInputWarning
            // 
            this.yearInputWarning.AutoSize = true;
            this.yearInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInputWarning.ForeColor = System.Drawing.Color.Red;
            this.yearInputWarning.Location = new System.Drawing.Point(553, 155);
            this.yearInputWarning.Name = "yearInputWarning";
            this.yearInputWarning.Size = new System.Drawing.Size(113, 19);
            this.yearInputWarning.TabIndex = 4;
            this.yearInputWarning.Text = "⚫ Not a year";
            this.yearInputWarning.Visible = false;
            // 
            // nameInputWarning
            // 
            this.nameInputWarning.AutoSize = true;
            this.nameInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputWarning.ForeColor = System.Drawing.Color.Red;
            this.nameInputWarning.Location = new System.Drawing.Point(553, 69);
            this.nameInputWarning.Name = "nameInputWarning";
            this.nameInputWarning.Size = new System.Drawing.Size(138, 19);
            this.nameInputWarning.TabIndex = 4;
            this.nameInputWarning.Text = "⚫ Field is empty";
            this.nameInputWarning.Visible = false;
            // 
            // salaryInputWarning
            // 
            this.salaryInputWarning.AutoSize = true;
            this.salaryInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryInputWarning.ForeColor = System.Drawing.Color.Red;
            this.salaryInputWarning.Location = new System.Drawing.Point(553, 198);
            this.salaryInputWarning.Name = "salaryInputWarning";
            this.salaryInputWarning.Size = new System.Drawing.Size(140, 19);
            this.salaryInputWarning.TabIndex = 4;
            this.salaryInputWarning.Text = "⚫ Not a number";
            this.salaryInputWarning.Visible = false;
            // 
            // birthdayDateTimePick
            // 
            this.birthdayDateTimePick.Location = new System.Drawing.Point(263, 100);
            this.birthdayDateTimePick.Name = "birthdayDateTimePick";
            this.birthdayDateTimePick.Size = new System.Drawing.Size(284, 37);
            this.birthdayDateTimePick.TabIndex = 3;
            this.birthdayDateTimePick.Value = new System.DateTime(2023, 5, 14, 13, 5, 6, 0);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(263, 186);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(284, 37);
            this.salaryTextBox.TabIndex = 2;
            this.salaryTextBox.Leave += new System.EventHandler(this.salaryTextBox_Leave);
            // 
            // employmentYearTextBox
            // 
            this.employmentYearTextBox.Location = new System.Drawing.Point(263, 143);
            this.employmentYearTextBox.Name = "employmentYearTextBox";
            this.employmentYearTextBox.Size = new System.Drawing.Size(284, 37);
            this.employmentYearTextBox.TabIndex = 2;
            this.employmentYearTextBox.Leave += new System.EventHandler(this.employmentYearTextBox_Leave);
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(262, 57);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.employeeNameTextBox.TabIndex = 2;
            this.employeeNameTextBox.Leave += new System.EventHandler(this.employeeNameTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employment year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birthday";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(114, 232);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(143, 30);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "Route type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.addButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(5, 420);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(712, 76);
            this.buttonsPanel.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(456, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 58);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Orange;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(57, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 58);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.employeeInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add employee";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.employeeInfoPanel.ResumeLayout(false);
            this.employeeInfoPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel employeeInfoPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePick;
        private System.Windows.Forms.TextBox employmentYearTextBox;
        private System.Windows.Forms.Label yearInputWarning;
        private System.Windows.Forms.Label salaryInputWarning;
        private System.Windows.Forms.Label nameInputWarning;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.ComboBox employeeTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox driverRouteTypeComboBox;
        private System.Windows.Forms.Label driverLabel;
    }
}