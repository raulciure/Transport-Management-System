namespace Transport_Management_System.Forms
{
    partial class AddVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleInfoPanel = new System.Windows.Forms.Panel();
            this.weightInputWarning = new System.Windows.Forms.Label();
            this.nameInputWarning = new System.Windows.Forms.Label();
            this.yearInputWarning = new System.Windows.Forms.Label();
            this.nextServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastServiceDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.maxCargoTextBox = new System.Windows.Forms.TextBox();
            this.aquisitionYearTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.vehicleInfoPanel.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new vehicle";
            // 
            // vehicleInfoPanel
            // 
            this.vehicleInfoPanel.Controls.Add(this.weightInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.nameInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.yearInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.nextServiceDateTimePicker);
            this.vehicleInfoPanel.Controls.Add(this.lastServiceDateTimePick);
            this.vehicleInfoPanel.Controls.Add(this.maxCargoTextBox);
            this.vehicleInfoPanel.Controls.Add(this.aquisitionYearTextBox);
            this.vehicleInfoPanel.Controls.Add(this.nameTextBox);
            this.vehicleInfoPanel.Controls.Add(this.vehicleTypeComboBox);
            this.vehicleInfoPanel.Controls.Add(this.label6);
            this.vehicleInfoPanel.Controls.Add(this.label5);
            this.vehicleInfoPanel.Controls.Add(this.label7);
            this.vehicleInfoPanel.Controls.Add(this.label4);
            this.vehicleInfoPanel.Controls.Add(this.label3);
            this.vehicleInfoPanel.Controls.Add(this.label2);
            this.vehicleInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.vehicleInfoPanel.Name = "vehicleInfoPanel";
            this.vehicleInfoPanel.Size = new System.Drawing.Size(705, 308);
            this.vehicleInfoPanel.TabIndex = 3;
            // 
            // weightInputWarning
            // 
            this.weightInputWarning.AutoSize = true;
            this.weightInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightInputWarning.ForeColor = System.Drawing.Color.Red;
            this.weightInputWarning.Location = new System.Drawing.Point(553, 155);
            this.weightInputWarning.Name = "weightInputWarning";
            this.weightInputWarning.Size = new System.Drawing.Size(140, 19);
            this.weightInputWarning.TabIndex = 4;
            this.weightInputWarning.Text = "⚫ Not a number";
            this.weightInputWarning.Visible = false;
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
            // yearInputWarning
            // 
            this.yearInputWarning.AutoSize = true;
            this.yearInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInputWarning.ForeColor = System.Drawing.Color.Red;
            this.yearInputWarning.Location = new System.Drawing.Point(553, 111);
            this.yearInputWarning.Name = "yearInputWarning";
            this.yearInputWarning.Size = new System.Drawing.Size(113, 19);
            this.yearInputWarning.TabIndex = 4;
            this.yearInputWarning.Text = "⚫ Not a year";
            this.yearInputWarning.Visible = false;
            // 
            // nextServiceDateTimePicker
            // 
            this.nextServiceDateTimePicker.Location = new System.Drawing.Point(262, 230);
            this.nextServiceDateTimePicker.Name = "nextServiceDateTimePicker";
            this.nextServiceDateTimePicker.Size = new System.Drawing.Size(285, 37);
            this.nextServiceDateTimePicker.TabIndex = 3;
            this.nextServiceDateTimePicker.Value = new System.DateTime(2023, 5, 12, 18, 55, 58, 0);
            // 
            // lastServiceDateTimePick
            // 
            this.lastServiceDateTimePick.Location = new System.Drawing.Point(263, 187);
            this.lastServiceDateTimePick.Name = "lastServiceDateTimePick";
            this.lastServiceDateTimePick.Size = new System.Drawing.Size(284, 37);
            this.lastServiceDateTimePick.TabIndex = 3;
            this.lastServiceDateTimePick.Value = new System.DateTime(2023, 5, 14, 13, 5, 6, 0);
            // 
            // maxCargoTextBox
            // 
            this.maxCargoTextBox.Location = new System.Drawing.Point(263, 143);
            this.maxCargoTextBox.Name = "maxCargoTextBox";
            this.maxCargoTextBox.Size = new System.Drawing.Size(284, 37);
            this.maxCargoTextBox.TabIndex = 2;
            this.maxCargoTextBox.Leave += new System.EventHandler(this.maxCargoTextBox_Leave);
            // 
            // aquisitionYearTextBox
            // 
            this.aquisitionYearTextBox.Location = new System.Drawing.Point(263, 100);
            this.aquisitionYearTextBox.Name = "aquisitionYearTextBox";
            this.aquisitionYearTextBox.Size = new System.Drawing.Size(284, 37);
            this.aquisitionYearTextBox.TabIndex = 2;
            this.aquisitionYearTextBox.Leave += new System.EventHandler(this.aquisitionYearTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(262, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(285, 37);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(262, 13);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(285, 38);
            this.vehicleTypeComboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Next service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vehicle type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max. cargo weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aquisition year";
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
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vehicleInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVehicleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add vehicle";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.vehicleInfoPanel.ResumeLayout(false);
            this.vehicleInfoPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel vehicleInfoPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox aquisitionYearTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker nextServiceDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastServiceDateTimePick;
        private System.Windows.Forms.TextBox maxCargoTextBox;
        private System.Windows.Forms.Label weightInputWarning;
        private System.Windows.Forms.Label yearInputWarning;
        private System.Windows.Forms.Label nameInputWarning;
    }
}