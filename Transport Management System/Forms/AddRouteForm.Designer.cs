namespace Transport_Management_System.Forms
{
    partial class AddRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRouteForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleInfoPanel = new System.Windows.Forms.Panel();
            this.destinationInputWarning = new System.Windows.Forms.Label();
            this.departureInputWarning = new System.Windows.Forms.Label();
            this.arrivalTimeDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.driversComboBox = new System.Windows.Forms.ComboBox();
            this.vehiclesComboBox = new System.Windows.Forms.ComboBox();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.routeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new route";
            // 
            // vehicleInfoPanel
            // 
            this.vehicleInfoPanel.Controls.Add(this.destinationInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.departureInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.arrivalTimeDateTimePick);
            this.vehicleInfoPanel.Controls.Add(this.destinationTextBox);
            this.vehicleInfoPanel.Controls.Add(this.departureTextBox);
            this.vehicleInfoPanel.Controls.Add(this.driversComboBox);
            this.vehicleInfoPanel.Controls.Add(this.vehiclesComboBox);
            this.vehicleInfoPanel.Controls.Add(this.customersComboBox);
            this.vehicleInfoPanel.Controls.Add(this.routeTypeComboBox);
            this.vehicleInfoPanel.Controls.Add(this.label8);
            this.vehicleInfoPanel.Controls.Add(this.label6);
            this.vehicleInfoPanel.Controls.Add(this.label5);
            this.vehicleInfoPanel.Controls.Add(this.label7);
            this.vehicleInfoPanel.Controls.Add(this.label4);
            this.vehicleInfoPanel.Controls.Add(this.label3);
            this.vehicleInfoPanel.Controls.Add(this.label2);
            this.vehicleInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleInfoPanel.Location = new System.Drawing.Point(8, 106);
            this.vehicleInfoPanel.Name = "vehicleInfoPanel";
            this.vehicleInfoPanel.Size = new System.Drawing.Size(709, 324);
            this.vehicleInfoPanel.TabIndex = 3;
            // 
            // destinationInputWarning
            // 
            this.destinationInputWarning.AutoSize = true;
            this.destinationInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationInputWarning.ForeColor = System.Drawing.Color.Red;
            this.destinationInputWarning.Location = new System.Drawing.Point(553, 155);
            this.destinationInputWarning.Name = "destinationInputWarning";
            this.destinationInputWarning.Size = new System.Drawing.Size(138, 19);
            this.destinationInputWarning.TabIndex = 5;
            this.destinationInputWarning.Text = "⚫ Field is empty";
            this.destinationInputWarning.Visible = false;
            // 
            // departureInputWarning
            // 
            this.departureInputWarning.AutoSize = true;
            this.departureInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureInputWarning.ForeColor = System.Drawing.Color.Red;
            this.departureInputWarning.Location = new System.Drawing.Point(553, 112);
            this.departureInputWarning.Name = "departureInputWarning";
            this.departureInputWarning.Size = new System.Drawing.Size(138, 19);
            this.departureInputWarning.TabIndex = 5;
            this.departureInputWarning.Text = "⚫ Field is empty";
            this.departureInputWarning.Visible = false;
            // 
            // arrivalTimeDateTimePick
            // 
            this.arrivalTimeDateTimePick.Location = new System.Drawing.Point(263, 187);
            this.arrivalTimeDateTimePick.Name = "arrivalTimeDateTimePick";
            this.arrivalTimeDateTimePick.Size = new System.Drawing.Size(284, 37);
            this.arrivalTimeDateTimePick.TabIndex = 3;
            this.arrivalTimeDateTimePick.Value = new System.DateTime(2023, 5, 14, 13, 5, 6, 0);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(263, 143);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(284, 37);
            this.destinationTextBox.TabIndex = 2;
            this.destinationTextBox.Leave += new System.EventHandler(this.destinationTextBox_Leave);
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(263, 100);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(284, 37);
            this.departureTextBox.TabIndex = 2;
            this.departureTextBox.Leave += new System.EventHandler(this.departureTextBox_Leave);
            // 
            // driversComboBox
            // 
            this.driversComboBox.FormattingEnabled = true;
            this.driversComboBox.Location = new System.Drawing.Point(263, 274);
            this.driversComboBox.Name = "driversComboBox";
            this.driversComboBox.Size = new System.Drawing.Size(285, 38);
            this.driversComboBox.TabIndex = 1;
            // 
            // vehiclesComboBox
            // 
            this.vehiclesComboBox.FormattingEnabled = true;
            this.vehiclesComboBox.Location = new System.Drawing.Point(262, 230);
            this.vehiclesComboBox.Name = "vehiclesComboBox";
            this.vehiclesComboBox.Size = new System.Drawing.Size(285, 38);
            this.vehiclesComboBox.TabIndex = 1;
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(262, 57);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(285, 38);
            this.customersComboBox.TabIndex = 1;
            // 
            // routeTypeComboBox
            // 
            this.routeTypeComboBox.FormattingEnabled = true;
            this.routeTypeComboBox.Location = new System.Drawing.Point(262, 13);
            this.routeTypeComboBox.Name = "routeTypeComboBox";
            this.routeTypeComboBox.Size = new System.Drawing.Size(285, 38);
            this.routeTypeComboBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Driver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arrival time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Route type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destionation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.addButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(5, 436);
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
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(722, 517);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vehicleInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRouteForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add route";
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
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.ComboBox routeTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker arrivalTimeDateTimePick;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ComboBox driversComboBox;
        private System.Windows.Forms.ComboBox vehiclesComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label departureInputWarning;
        private System.Windows.Forms.Label destinationInputWarning;
    }
}