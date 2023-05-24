namespace Transport_Management_System.Forms
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeInfoPanel = new System.Windows.Forms.Panel();
            this.cityInputWarning = new System.Windows.Forms.Label();
            this.adressInputWarning = new System.Windows.Forms.Label();
            this.nameInputWarning = new System.Windows.Forms.Label();
            this.emailInputWarning = new System.Windows.Forms.Label();
            this.phoneInputWarning = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerAdressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(211, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new customer";
            // 
            // employeeInfoPanel
            // 
            this.employeeInfoPanel.Controls.Add(this.cityInputWarning);
            this.employeeInfoPanel.Controls.Add(this.adressInputWarning);
            this.employeeInfoPanel.Controls.Add(this.nameInputWarning);
            this.employeeInfoPanel.Controls.Add(this.emailInputWarning);
            this.employeeInfoPanel.Controls.Add(this.phoneInputWarning);
            this.employeeInfoPanel.Controls.Add(this.customerEmailTextBox);
            this.employeeInfoPanel.Controls.Add(this.customerPhoneTextBox);
            this.employeeInfoPanel.Controls.Add(this.customerCityTextBox);
            this.employeeInfoPanel.Controls.Add(this.customerAdressTextBox);
            this.employeeInfoPanel.Controls.Add(this.label6);
            this.employeeInfoPanel.Controls.Add(this.customerNameTextBox);
            this.employeeInfoPanel.Controls.Add(this.label5);
            this.employeeInfoPanel.Controls.Add(this.label4);
            this.employeeInfoPanel.Controls.Add(this.label3);
            this.employeeInfoPanel.Controls.Add(this.label2);
            this.employeeInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.employeeInfoPanel.Name = "employeeInfoPanel";
            this.employeeInfoPanel.Size = new System.Drawing.Size(705, 308);
            this.employeeInfoPanel.TabIndex = 3;
            // 
            // cityInputWarning
            // 
            this.cityInputWarning.AutoSize = true;
            this.cityInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInputWarning.ForeColor = System.Drawing.Color.Red;
            this.cityInputWarning.Location = new System.Drawing.Point(502, 141);
            this.cityInputWarning.Name = "cityInputWarning";
            this.cityInputWarning.Size = new System.Drawing.Size(138, 19);
            this.cityInputWarning.TabIndex = 4;
            this.cityInputWarning.Text = "⚫ Field is empty";
            this.cityInputWarning.Visible = false;
            // 
            // adressInputWarning
            // 
            this.adressInputWarning.AutoSize = true;
            this.adressInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressInputWarning.ForeColor = System.Drawing.Color.Red;
            this.adressInputWarning.Location = new System.Drawing.Point(502, 98);
            this.adressInputWarning.Name = "adressInputWarning";
            this.adressInputWarning.Size = new System.Drawing.Size(138, 19);
            this.adressInputWarning.TabIndex = 4;
            this.adressInputWarning.Text = "⚫ Field is empty";
            this.adressInputWarning.Visible = false;
            // 
            // nameInputWarning
            // 
            this.nameInputWarning.AutoSize = true;
            this.nameInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputWarning.ForeColor = System.Drawing.Color.Red;
            this.nameInputWarning.Location = new System.Drawing.Point(502, 55);
            this.nameInputWarning.Name = "nameInputWarning";
            this.nameInputWarning.Size = new System.Drawing.Size(138, 19);
            this.nameInputWarning.TabIndex = 4;
            this.nameInputWarning.Text = "⚫ Field is empty";
            this.nameInputWarning.Visible = false;
            // 
            // emailInputWarning
            // 
            this.emailInputWarning.AutoSize = true;
            this.emailInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInputWarning.ForeColor = System.Drawing.Color.Red;
            this.emailInputWarning.Location = new System.Drawing.Point(502, 227);
            this.emailInputWarning.Name = "emailInputWarning";
            this.emailInputWarning.Size = new System.Drawing.Size(140, 19);
            this.emailInputWarning.TabIndex = 4;
            this.emailInputWarning.Text = "⚫ Not an e-mail";
            this.emailInputWarning.Visible = false;
            // 
            // phoneInputWarning
            // 
            this.phoneInputWarning.AutoSize = true;
            this.phoneInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInputWarning.ForeColor = System.Drawing.Color.Red;
            this.phoneInputWarning.Location = new System.Drawing.Point(502, 184);
            this.phoneInputWarning.Name = "phoneInputWarning";
            this.phoneInputWarning.Size = new System.Drawing.Size(195, 19);
            this.phoneInputWarning.TabIndex = 4;
            this.phoneInputWarning.Text = "⚫ Not a phone number";
            this.phoneInputWarning.Visible = false;
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(211, 215);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(284, 37);
            this.customerEmailTextBox.TabIndex = 2;
            this.customerEmailTextBox.Leave += new System.EventHandler(this.customerEmailTextBox_Leave);
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(212, 172);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(284, 37);
            this.customerPhoneTextBox.TabIndex = 2;
            this.customerPhoneTextBox.Leave += new System.EventHandler(this.customerPhoneTextBox_Leave);
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.Location = new System.Drawing.Point(212, 129);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(284, 37);
            this.customerCityTextBox.TabIndex = 2;
            this.customerCityTextBox.Leave += new System.EventHandler(this.customerCityTextBox_Leave);
            // 
            // customerAdressTextBox
            // 
            this.customerAdressTextBox.Location = new System.Drawing.Point(211, 86);
            this.customerAdressTextBox.Name = "customerAdressTextBox";
            this.customerAdressTextBox.Size = new System.Drawing.Size(285, 37);
            this.customerAdressTextBox.TabIndex = 2;
            this.customerAdressTextBox.Leave += new System.EventHandler(this.customerAdressTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-mail";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(211, 43);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.customerNameTextBox.TabIndex = 2;
            this.customerNameTextBox.Leave += new System.EventHandler(this.customerNameTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
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
            // AddCustomerForm
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
            this.Name = "AddCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add customer";
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
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.Label phoneInputWarning;
        private System.Windows.Forms.Label nameInputWarning;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label adressInputWarning;
        private System.Windows.Forms.TextBox customerAdressTextBox;
        private System.Windows.Forms.Label cityInputWarning;
        private System.Windows.Forms.Label emailInputWarning;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label label6;
    }
}