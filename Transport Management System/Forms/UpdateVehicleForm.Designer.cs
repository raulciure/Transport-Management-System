namespace Transport_Management_System.Forms
{
    partial class UpdateVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVehicleForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleInfoPanel = new System.Windows.Forms.Panel();
            this.nameInputWarning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldNextServiceTextBox = new System.Windows.Forms.TextBox();
            this.oldLastServiceTextBox = new System.Windows.Forms.TextBox();
            this.oldMaxCargoWeightTextBox = new System.Windows.Forms.TextBox();
            this.oldAquisitionYearTextBox = new System.Windows.Forms.TextBox();
            this.oldNameTextBox = new System.Windows.Forms.TextBox();
            this.oldVehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weightInputWarning = new System.Windows.Forms.Label();
            this.yearInputWarning = new System.Windows.Forms.Label();
            this.newNextServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newLastServiceDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.newMaxCargoTextBox = new System.Windows.Forms.TextBox();
            this.newAquisitionYearTextBox = new System.Windows.Forms.TextBox();
            this.newVehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.newVehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
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
            this.headerPanel.Size = new System.Drawing.Size(1023, 100);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update vehicle";
            // 
            // vehicleInfoPanel
            // 
            this.vehicleInfoPanel.Controls.Add(this.nameInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.label7);
            this.vehicleInfoPanel.Controls.Add(this.label6);
            this.vehicleInfoPanel.Controls.Add(this.label5);
            this.vehicleInfoPanel.Controls.Add(this.label4);
            this.vehicleInfoPanel.Controls.Add(this.label3);
            this.vehicleInfoPanel.Controls.Add(this.label2);
            this.vehicleInfoPanel.Controls.Add(this.oldNextServiceTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldLastServiceTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldMaxCargoWeightTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldAquisitionYearTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldNameTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldVehicleTypeTextBox);
            this.vehicleInfoPanel.Controls.Add(this.label9);
            this.vehicleInfoPanel.Controls.Add(this.label8);
            this.vehicleInfoPanel.Controls.Add(this.weightInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.yearInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.newNextServiceDateTimePicker);
            this.vehicleInfoPanel.Controls.Add(this.newLastServiceDateTimePick);
            this.vehicleInfoPanel.Controls.Add(this.newMaxCargoTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newAquisitionYearTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newVehicleNameTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newVehicleTypeComboBox);
            this.vehicleInfoPanel.Controls.Add(this.label15);
            this.vehicleInfoPanel.Controls.Add(this.label14);
            this.vehicleInfoPanel.Controls.Add(this.label13);
            this.vehicleInfoPanel.Controls.Add(this.label12);
            this.vehicleInfoPanel.Controls.Add(this.label11);
            this.vehicleInfoPanel.Controls.Add(this.label10);
            this.vehicleInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.vehicleInfoPanel.Name = "vehicleInfoPanel";
            this.vehicleInfoPanel.Size = new System.Drawing.Size(1013, 360);
            this.vehicleInfoPanel.TabIndex = 3;
            // 
            // nameInputWarning
            // 
            this.nameInputWarning.AutoSize = true;
            this.nameInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputWarning.ForeColor = System.Drawing.Color.Red;
            this.nameInputWarning.Location = new System.Drawing.Point(871, 142);
            this.nameInputWarning.Name = "nameInputWarning";
            this.nameInputWarning.Size = new System.Drawing.Size(128, 19);
            this.nameInputWarning.TabIndex = 8;
            this.nameInputWarning.Text = "⚫ Name is null";
            this.nameInputWarning.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "➔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "➔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "➔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "➔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "➔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "➔";
            // 
            // oldNextServiceTextBox
            // 
            this.oldNextServiceTextBox.Location = new System.Drawing.Point(250, 302);
            this.oldNextServiceTextBox.Name = "oldNextServiceTextBox";
            this.oldNextServiceTextBox.ReadOnly = true;
            this.oldNextServiceTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldNextServiceTextBox.TabIndex = 6;
            // 
            // oldLastServiceTextBox
            // 
            this.oldLastServiceTextBox.Location = new System.Drawing.Point(250, 259);
            this.oldLastServiceTextBox.Name = "oldLastServiceTextBox";
            this.oldLastServiceTextBox.ReadOnly = true;
            this.oldLastServiceTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldLastServiceTextBox.TabIndex = 6;
            // 
            // oldMaxCargoWeightTextBox
            // 
            this.oldMaxCargoWeightTextBox.Location = new System.Drawing.Point(250, 216);
            this.oldMaxCargoWeightTextBox.Name = "oldMaxCargoWeightTextBox";
            this.oldMaxCargoWeightTextBox.ReadOnly = true;
            this.oldMaxCargoWeightTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldMaxCargoWeightTextBox.TabIndex = 6;
            // 
            // oldAquisitionYearTextBox
            // 
            this.oldAquisitionYearTextBox.Location = new System.Drawing.Point(250, 173);
            this.oldAquisitionYearTextBox.Name = "oldAquisitionYearTextBox";
            this.oldAquisitionYearTextBox.ReadOnly = true;
            this.oldAquisitionYearTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldAquisitionYearTextBox.TabIndex = 6;
            // 
            // oldNameTextBox
            // 
            this.oldNameTextBox.Location = new System.Drawing.Point(250, 130);
            this.oldNameTextBox.Name = "oldNameTextBox";
            this.oldNameTextBox.ReadOnly = true;
            this.oldNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldNameTextBox.TabIndex = 6;
            // 
            // oldVehicleTypeTextBox
            // 
            this.oldVehicleTypeTextBox.Location = new System.Drawing.Point(250, 87);
            this.oldVehicleTypeTextBox.Name = "oldVehicleTypeTextBox";
            this.oldVehicleTypeTextBox.ReadOnly = true;
            this.oldVehicleTypeTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldVehicleTypeTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Old information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "New information";
            // 
            // weightInputWarning
            // 
            this.weightInputWarning.AutoSize = true;
            this.weightInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightInputWarning.ForeColor = System.Drawing.Color.Red;
            this.weightInputWarning.Location = new System.Drawing.Point(871, 229);
            this.weightInputWarning.Name = "weightInputWarning";
            this.weightInputWarning.Size = new System.Drawing.Size(140, 19);
            this.weightInputWarning.TabIndex = 4;
            this.weightInputWarning.Text = "⚫ Not a number";
            this.weightInputWarning.Visible = false;
            // 
            // yearInputWarning
            // 
            this.yearInputWarning.AutoSize = true;
            this.yearInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInputWarning.ForeColor = System.Drawing.Color.Red;
            this.yearInputWarning.Location = new System.Drawing.Point(871, 185);
            this.yearInputWarning.Name = "yearInputWarning";
            this.yearInputWarning.Size = new System.Drawing.Size(113, 19);
            this.yearInputWarning.TabIndex = 4;
            this.yearInputWarning.Text = "⚫ Not a year";
            this.yearInputWarning.Visible = false;
            // 
            // newNextServiceDateTimePicker
            // 
            this.newNextServiceDateTimePicker.Location = new System.Drawing.Point(580, 304);
            this.newNextServiceDateTimePicker.Name = "newNextServiceDateTimePicker";
            this.newNextServiceDateTimePicker.Size = new System.Drawing.Size(285, 37);
            this.newNextServiceDateTimePicker.TabIndex = 3;
            this.newNextServiceDateTimePicker.Value = new System.DateTime(2023, 5, 12, 18, 55, 58, 0);
            // 
            // newLastServiceDateTimePick
            // 
            this.newLastServiceDateTimePick.Location = new System.Drawing.Point(581, 261);
            this.newLastServiceDateTimePick.Name = "newLastServiceDateTimePick";
            this.newLastServiceDateTimePick.Size = new System.Drawing.Size(284, 37);
            this.newLastServiceDateTimePick.TabIndex = 3;
            this.newLastServiceDateTimePick.Value = new System.DateTime(2023, 5, 12, 18, 55, 58, 0);
            // 
            // newMaxCargoTextBox
            // 
            this.newMaxCargoTextBox.Location = new System.Drawing.Point(581, 217);
            this.newMaxCargoTextBox.Name = "newMaxCargoTextBox";
            this.newMaxCargoTextBox.Size = new System.Drawing.Size(284, 37);
            this.newMaxCargoTextBox.TabIndex = 2;
            this.newMaxCargoTextBox.Leave += new System.EventHandler(this.newMaxCargoTextBox_Leave);
            // 
            // newAquisitionYearTextBox
            // 
            this.newAquisitionYearTextBox.Location = new System.Drawing.Point(581, 174);
            this.newAquisitionYearTextBox.Name = "newAquisitionYearTextBox";
            this.newAquisitionYearTextBox.Size = new System.Drawing.Size(284, 37);
            this.newAquisitionYearTextBox.TabIndex = 2;
            this.newAquisitionYearTextBox.Leave += new System.EventHandler(this.newAquisitionYearTextBox_Leave);
            // 
            // newVehicleNameTextBox
            // 
            this.newVehicleNameTextBox.Location = new System.Drawing.Point(580, 131);
            this.newVehicleNameTextBox.Name = "newVehicleNameTextBox";
            this.newVehicleNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.newVehicleNameTextBox.TabIndex = 2;
            this.newVehicleNameTextBox.Leave += new System.EventHandler(this.newNameTextBox_Leave);
            // 
            // newVehicleTypeComboBox
            // 
            this.newVehicleTypeComboBox.FormattingEnabled = true;
            this.newVehicleTypeComboBox.Location = new System.Drawing.Point(580, 87);
            this.newVehicleTypeComboBox.Name = "newVehicleTypeComboBox";
            this.newVehicleTypeComboBox.Size = new System.Drawing.Size(285, 38);
            this.newVehicleTypeComboBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "Next service";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Last service";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Vehicle type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Max. cargo weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Aquisition year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.updateButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(5, 472);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1023, 76);
            this.buttonsPanel.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(611, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 58);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Orange;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(212, 9);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 58);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1033, 553);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vehicleInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateVehicleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update vehicle";
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
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox newAquisitionYearTextBox;
        private System.Windows.Forms.TextBox newVehicleNameTextBox;
        private System.Windows.Forms.ComboBox newVehicleTypeComboBox;
        private System.Windows.Forms.DateTimePicker newNextServiceDateTimePicker;
        private System.Windows.Forms.DateTimePicker newLastServiceDateTimePick;
        private System.Windows.Forms.TextBox newMaxCargoTextBox;
        private System.Windows.Forms.Label weightInputWarning;
        private System.Windows.Forms.Label yearInputWarning;
        private System.Windows.Forms.TextBox oldNextServiceTextBox;
        private System.Windows.Forms.TextBox oldLastServiceTextBox;
        private System.Windows.Forms.TextBox oldMaxCargoWeightTextBox;
        private System.Windows.Forms.TextBox oldAquisitionYearTextBox;
        private System.Windows.Forms.TextBox oldNameTextBox;
        private System.Windows.Forms.TextBox oldVehicleTypeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameInputWarning;
    }
}