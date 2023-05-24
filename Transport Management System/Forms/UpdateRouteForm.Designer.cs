namespace Transport_Management_System.Forms
{
    partial class UpdateRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRouteForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleInfoPanel = new System.Windows.Forms.Panel();
            this.destinationInputWarning = new System.Windows.Forms.Label();
            this.departureInputWarning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldDriverTextBox = new System.Windows.Forms.TextBox();
            this.oldVehicleTextBox = new System.Windows.Forms.TextBox();
            this.oldArrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.oldDestinationTextBox = new System.Windows.Forms.TextBox();
            this.oldDepartureTextBox = new System.Windows.Forms.TextBox();
            this.oldCustomerTextBox = new System.Windows.Forms.TextBox();
            this.oldRouteTypeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newDestinationTextBox = new System.Windows.Forms.TextBox();
            this.newArrivalTimeDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.newDepartureTextBox = new System.Windows.Forms.TextBox();
            this.newDriverComboBox = new System.Windows.Forms.ComboBox();
            this.newVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.newCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.newRouteTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(408, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update route";
            // 
            // vehicleInfoPanel
            // 
            this.vehicleInfoPanel.Controls.Add(this.destinationInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.departureInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.label7);
            this.vehicleInfoPanel.Controls.Add(this.label6);
            this.vehicleInfoPanel.Controls.Add(this.label5);
            this.vehicleInfoPanel.Controls.Add(this.label17);
            this.vehicleInfoPanel.Controls.Add(this.label4);
            this.vehicleInfoPanel.Controls.Add(this.label3);
            this.vehicleInfoPanel.Controls.Add(this.label2);
            this.vehicleInfoPanel.Controls.Add(this.oldDriverTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldVehicleTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldArrivalTimeTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldDestinationTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldDepartureTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldCustomerTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldRouteTypeTextBox);
            this.vehicleInfoPanel.Controls.Add(this.label9);
            this.vehicleInfoPanel.Controls.Add(this.label8);
            this.vehicleInfoPanel.Controls.Add(this.newDestinationTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newArrivalTimeDateTimePick);
            this.vehicleInfoPanel.Controls.Add(this.newDepartureTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newDriverComboBox);
            this.vehicleInfoPanel.Controls.Add(this.newVehicleComboBox);
            this.vehicleInfoPanel.Controls.Add(this.newCustomerComboBox);
            this.vehicleInfoPanel.Controls.Add(this.newRouteTypeComboBox);
            this.vehicleInfoPanel.Controls.Add(this.label15);
            this.vehicleInfoPanel.Controls.Add(this.label14);
            this.vehicleInfoPanel.Controls.Add(this.label13);
            this.vehicleInfoPanel.Controls.Add(this.label16);
            this.vehicleInfoPanel.Controls.Add(this.label12);
            this.vehicleInfoPanel.Controls.Add(this.label11);
            this.vehicleInfoPanel.Controls.Add(this.label10);
            this.vehicleInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.vehicleInfoPanel.Name = "vehicleInfoPanel";
            this.vehicleInfoPanel.Size = new System.Drawing.Size(1013, 407);
            this.vehicleInfoPanel.TabIndex = 3;
            // 
            // destinationInputWarning
            // 
            this.destinationInputWarning.AutoSize = true;
            this.destinationInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationInputWarning.ForeColor = System.Drawing.Color.Red;
            this.destinationInputWarning.Location = new System.Drawing.Point(871, 228);
            this.destinationInputWarning.Name = "destinationInputWarning";
            this.destinationInputWarning.Size = new System.Drawing.Size(138, 19);
            this.destinationInputWarning.TabIndex = 8;
            this.destinationInputWarning.Text = "⚫ Field is empty";
            this.destinationInputWarning.Visible = false;
            // 
            // departureInputWarning
            // 
            this.departureInputWarning.AutoSize = true;
            this.departureInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureInputWarning.ForeColor = System.Drawing.Color.Red;
            this.departureInputWarning.Location = new System.Drawing.Point(871, 185);
            this.departureInputWarning.Name = "departureInputWarning";
            this.departureInputWarning.Size = new System.Drawing.Size(138, 19);
            this.departureInputWarning.TabIndex = 8;
            this.departureInputWarning.Text = "⚫ Field is empty";
            this.departureInputWarning.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "➔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "➔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "➔";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(541, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 28);
            this.label17.TabIndex = 7;
            this.label17.Text = "➔";
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
            // oldDriverTextBox
            // 
            this.oldDriverTextBox.Location = new System.Drawing.Point(250, 345);
            this.oldDriverTextBox.Name = "oldDriverTextBox";
            this.oldDriverTextBox.ReadOnly = true;
            this.oldDriverTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldDriverTextBox.TabIndex = 6;
            // 
            // oldVehicleTextBox
            // 
            this.oldVehicleTextBox.Location = new System.Drawing.Point(250, 302);
            this.oldVehicleTextBox.Name = "oldVehicleTextBox";
            this.oldVehicleTextBox.ReadOnly = true;
            this.oldVehicleTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldVehicleTextBox.TabIndex = 6;
            // 
            // oldArrivalTimeTextBox
            // 
            this.oldArrivalTimeTextBox.Location = new System.Drawing.Point(250, 259);
            this.oldArrivalTimeTextBox.Name = "oldArrivalTimeTextBox";
            this.oldArrivalTimeTextBox.ReadOnly = true;
            this.oldArrivalTimeTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldArrivalTimeTextBox.TabIndex = 6;
            // 
            // oldDestinationTextBox
            // 
            this.oldDestinationTextBox.Location = new System.Drawing.Point(250, 216);
            this.oldDestinationTextBox.Name = "oldDestinationTextBox";
            this.oldDestinationTextBox.ReadOnly = true;
            this.oldDestinationTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldDestinationTextBox.TabIndex = 6;
            // 
            // oldDepartureTextBox
            // 
            this.oldDepartureTextBox.Location = new System.Drawing.Point(250, 173);
            this.oldDepartureTextBox.Name = "oldDepartureTextBox";
            this.oldDepartureTextBox.ReadOnly = true;
            this.oldDepartureTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldDepartureTextBox.TabIndex = 6;
            // 
            // oldCustomerTextBox
            // 
            this.oldCustomerTextBox.Location = new System.Drawing.Point(250, 130);
            this.oldCustomerTextBox.Name = "oldCustomerTextBox";
            this.oldCustomerTextBox.ReadOnly = true;
            this.oldCustomerTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldCustomerTextBox.TabIndex = 6;
            // 
            // oldRouteTypeTextBox
            // 
            this.oldRouteTypeTextBox.Location = new System.Drawing.Point(250, 87);
            this.oldRouteTypeTextBox.Name = "oldRouteTypeTextBox";
            this.oldRouteTypeTextBox.ReadOnly = true;
            this.oldRouteTypeTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldRouteTypeTextBox.TabIndex = 6;
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
            // newDestinationTextBox
            // 
            this.newDestinationTextBox.Location = new System.Drawing.Point(581, 217);
            this.newDestinationTextBox.Name = "newDestinationTextBox";
            this.newDestinationTextBox.Size = new System.Drawing.Size(284, 37);
            this.newDestinationTextBox.TabIndex = 2;
            this.newDestinationTextBox.Leave += new System.EventHandler(this.newDestinationTextBox_Leave);
            // 
            // newArrivalTimeDateTimePick
            // 
            this.newArrivalTimeDateTimePick.Location = new System.Drawing.Point(580, 260);
            this.newArrivalTimeDateTimePick.Name = "newArrivalTimeDateTimePick";
            this.newArrivalTimeDateTimePick.Size = new System.Drawing.Size(284, 37);
            this.newArrivalTimeDateTimePick.TabIndex = 3;
            this.newArrivalTimeDateTimePick.Value = new System.DateTime(2023, 5, 12, 18, 55, 58, 0);
            // 
            // newDepartureTextBox
            // 
            this.newDepartureTextBox.Location = new System.Drawing.Point(581, 174);
            this.newDepartureTextBox.Name = "newDepartureTextBox";
            this.newDepartureTextBox.Size = new System.Drawing.Size(284, 37);
            this.newDepartureTextBox.TabIndex = 2;
            this.newDepartureTextBox.Leave += new System.EventHandler(this.newDepartureTextBox_Leave);
            // 
            // newDriverComboBox
            // 
            this.newDriverComboBox.FormattingEnabled = true;
            this.newDriverComboBox.Location = new System.Drawing.Point(581, 347);
            this.newDriverComboBox.Name = "newDriverComboBox";
            this.newDriverComboBox.Size = new System.Drawing.Size(285, 38);
            this.newDriverComboBox.TabIndex = 1;
            // 
            // newVehicleComboBox
            // 
            this.newVehicleComboBox.FormattingEnabled = true;
            this.newVehicleComboBox.Location = new System.Drawing.Point(581, 303);
            this.newVehicleComboBox.Name = "newVehicleComboBox";
            this.newVehicleComboBox.Size = new System.Drawing.Size(285, 38);
            this.newVehicleComboBox.TabIndex = 1;
            // 
            // newCustomerComboBox
            // 
            this.newCustomerComboBox.FormattingEnabled = true;
            this.newCustomerComboBox.Location = new System.Drawing.Point(581, 131);
            this.newCustomerComboBox.Name = "newCustomerComboBox";
            this.newCustomerComboBox.Size = new System.Drawing.Size(285, 38);
            this.newCustomerComboBox.TabIndex = 1;
            // 
            // newRouteTypeComboBox
            // 
            this.newRouteTypeComboBox.FormattingEnabled = true;
            this.newRouteTypeComboBox.Location = new System.Drawing.Point(580, 87);
            this.newRouteTypeComboBox.Name = "newRouteTypeComboBox";
            this.newRouteTypeComboBox.Size = new System.Drawing.Size(285, 38);
            this.newRouteTypeComboBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "Driver";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Vehicle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Route type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Destination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Arrival time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Departure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Customer";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.updateButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(5, 519);
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
            // UpdateRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1033, 600);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vehicleInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateRouteForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update route";
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
        private System.Windows.Forms.TextBox newDepartureTextBox;
        private System.Windows.Forms.ComboBox newRouteTypeComboBox;
        private System.Windows.Forms.DateTimePicker newArrivalTimeDateTimePick;
        private System.Windows.Forms.TextBox oldDriverTextBox;
        private System.Windows.Forms.TextBox oldVehicleTextBox;
        private System.Windows.Forms.TextBox oldArrivalTimeTextBox;
        private System.Windows.Forms.TextBox oldDepartureTextBox;
        private System.Windows.Forms.TextBox oldCustomerTextBox;
        private System.Windows.Forms.TextBox oldRouteTypeTextBox;
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
        private System.Windows.Forms.Label departureInputWarning;
        private System.Windows.Forms.ComboBox newCustomerComboBox;
        private System.Windows.Forms.ComboBox newDriverComboBox;
        private System.Windows.Forms.ComboBox newVehicleComboBox;
        private System.Windows.Forms.Label destinationInputWarning;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox oldDestinationTextBox;
        private System.Windows.Forms.TextBox newDestinationTextBox;
        private System.Windows.Forms.Label label16;
    }
}