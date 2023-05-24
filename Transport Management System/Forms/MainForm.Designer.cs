namespace Transport_Management_System.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.todayDeliveryBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.manageRoutesButton = new System.Windows.Forms.Button();
            this.manageCustomersButton = new System.Windows.Forms.Button();
            this.manageEmployeesButton = new System.Windows.Forms.Button();
            this.manageFleetButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1065, 100);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1037, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 5;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1006, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport Management System";
            // 
            // todayDeliveryBox
            // 
            this.todayDeliveryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todayDeliveryBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.todayDeliveryBox.FormattingEnabled = true;
            this.todayDeliveryBox.IntegralHeight = false;
            this.todayDeliveryBox.ItemHeight = 30;
            this.todayDeliveryBox.Location = new System.Drawing.Point(0, 0);
            this.todayDeliveryBox.Margin = new System.Windows.Forms.Padding(2);
            this.todayDeliveryBox.Name = "todayDeliveryBox";
            this.todayDeliveryBox.Size = new System.Drawing.Size(324, 316);
            this.todayDeliveryBox.TabIndex = 1;
            this.todayDeliveryBox.SelectedIndexChanged += new System.EventHandler(this.todayDeliveryBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deliveries due today:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.deliveryDetailsTextBox);
            this.panel1.Controls.Add(this.todayDeliveryBox);
            this.panel1.Location = new System.Drawing.Point(8, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 316);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "➔";
            // 
            // deliveryDetailsTextBox
            // 
            this.deliveryDetailsTextBox.AcceptsReturn = true;
            this.deliveryDetailsTextBox.AcceptsTab = true;
            this.deliveryDetailsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.deliveryDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryDetailsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.deliveryDetailsTextBox.Location = new System.Drawing.Point(365, 0);
            this.deliveryDetailsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryDetailsTextBox.Multiline = true;
            this.deliveryDetailsTextBox.Name = "deliveryDetailsTextBox";
            this.deliveryDetailsTextBox.ReadOnly = true;
            this.deliveryDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deliveryDetailsTextBox.Size = new System.Drawing.Size(680, 316);
            this.deliveryDetailsTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Details on selected delivery:";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonsPanel.Controls.Add(this.manageRoutesButton);
            this.buttonsPanel.Controls.Add(this.manageCustomersButton);
            this.buttonsPanel.Controls.Add(this.manageEmployeesButton);
            this.buttonsPanel.Controls.Add(this.manageFleetButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 469);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1065, 100);
            this.buttonsPanel.TabIndex = 4;
            // 
            // manageRoutesButton
            // 
            this.manageRoutesButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageRoutesButton.FlatAppearance.BorderSize = 0;
            this.manageRoutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageRoutesButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRoutesButton.Location = new System.Drawing.Point(800, 13);
            this.manageRoutesButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageRoutesButton.Name = "manageRoutesButton";
            this.manageRoutesButton.Size = new System.Drawing.Size(250, 75);
            this.manageRoutesButton.TabIndex = 0;
            this.manageRoutesButton.Text = "Manage routes";
            this.manageRoutesButton.UseVisualStyleBackColor = false;
            this.manageRoutesButton.Click += new System.EventHandler(this.manageRoutesButton_Click);
            // 
            // manageCustomersButton
            // 
            this.manageCustomersButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageCustomersButton.FlatAppearance.BorderSize = 0;
            this.manageCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCustomersButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomersButton.Location = new System.Drawing.Point(538, 13);
            this.manageCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageCustomersButton.Name = "manageCustomersButton";
            this.manageCustomersButton.Size = new System.Drawing.Size(250, 75);
            this.manageCustomersButton.TabIndex = 0;
            this.manageCustomersButton.Text = "Manage customers";
            this.manageCustomersButton.UseVisualStyleBackColor = false;
            this.manageCustomersButton.Click += new System.EventHandler(this.manageCustomersButton_Click);
            // 
            // manageEmployeesButton
            // 
            this.manageEmployeesButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageEmployeesButton.FlatAppearance.BorderSize = 0;
            this.manageEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageEmployeesButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeesButton.Location = new System.Drawing.Point(276, 13);
            this.manageEmployeesButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageEmployeesButton.Name = "manageEmployeesButton";
            this.manageEmployeesButton.Size = new System.Drawing.Size(250, 75);
            this.manageEmployeesButton.TabIndex = 0;
            this.manageEmployeesButton.Text = "Manage employees";
            this.manageEmployeesButton.UseVisualStyleBackColor = false;
            this.manageEmployeesButton.Click += new System.EventHandler(this.manageEmployeesButton_Click);
            // 
            // manageFleetButton
            // 
            this.manageFleetButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageFleetButton.FlatAppearance.BorderSize = 0;
            this.manageFleetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageFleetButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageFleetButton.Location = new System.Drawing.Point(14, 13);
            this.manageFleetButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageFleetButton.Name = "manageFleetButton";
            this.manageFleetButton.Size = new System.Drawing.Size(250, 75);
            this.manageFleetButton.TabIndex = 0;
            this.manageFleetButton.Text = "Manage fleet";
            this.manageFleetButton.UseVisualStyleBackColor = false;
            this.manageFleetButton.Click += new System.EventHandler(this.manageFleetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1065, 569);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox todayDeliveryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button manageFleetButton;
        private System.Windows.Forms.TextBox deliveryDetailsTextBox;
        private System.Windows.Forms.Button manageRoutesButton;
        private System.Windows.Forms.Button manageCustomersButton;
        private System.Windows.Forms.Button manageEmployeesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}