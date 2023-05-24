namespace Transport_Management_System.Forms
{
    partial class UpdateCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomerForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleInfoPanel = new System.Windows.Forms.Panel();
            this.emailInputWarning = new System.Windows.Forms.Label();
            this.phoneInputWarning = new System.Windows.Forms.Label();
            this.nameInputWarning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldEmailTextBox = new System.Windows.Forms.TextBox();
            this.oldPhoneTextBox = new System.Windows.Forms.TextBox();
            this.oldCityTextBox = new System.Windows.Forms.TextBox();
            this.oldAdressTextBox = new System.Windows.Forms.TextBox();
            this.oldNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cityInputWarning = new System.Windows.Forms.Label();
            this.adressInputWarning = new System.Windows.Forms.Label();
            this.newEmailTextBox = new System.Windows.Forms.TextBox();
            this.newPhoneTextBox = new System.Windows.Forms.TextBox();
            this.newCityTextBox = new System.Windows.Forms.TextBox();
            this.newAdressTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(378, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update customer";
            // 
            // vehicleInfoPanel
            // 
            this.vehicleInfoPanel.Controls.Add(this.emailInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.phoneInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.nameInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.label7);
            this.vehicleInfoPanel.Controls.Add(this.label6);
            this.vehicleInfoPanel.Controls.Add(this.label5);
            this.vehicleInfoPanel.Controls.Add(this.label4);
            this.vehicleInfoPanel.Controls.Add(this.label3);
            this.vehicleInfoPanel.Controls.Add(this.oldEmailTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldPhoneTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldCityTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldAdressTextBox);
            this.vehicleInfoPanel.Controls.Add(this.oldNameTextBox);
            this.vehicleInfoPanel.Controls.Add(this.label9);
            this.vehicleInfoPanel.Controls.Add(this.label8);
            this.vehicleInfoPanel.Controls.Add(this.cityInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.adressInputWarning);
            this.vehicleInfoPanel.Controls.Add(this.newEmailTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newPhoneTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newCityTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newAdressTextBox);
            this.vehicleInfoPanel.Controls.Add(this.newNameTextBox);
            this.vehicleInfoPanel.Controls.Add(this.label15);
            this.vehicleInfoPanel.Controls.Add(this.label14);
            this.vehicleInfoPanel.Controls.Add(this.label12);
            this.vehicleInfoPanel.Controls.Add(this.label11);
            this.vehicleInfoPanel.Controls.Add(this.label10);
            this.vehicleInfoPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleInfoPanel.Location = new System.Drawing.Point(12, 106);
            this.vehicleInfoPanel.Name = "vehicleInfoPanel";
            this.vehicleInfoPanel.Size = new System.Drawing.Size(1013, 312);
            this.vehicleInfoPanel.TabIndex = 3;
            // 
            // emailInputWarning
            // 
            this.emailInputWarning.AutoSize = true;
            this.emailInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInputWarning.ForeColor = System.Drawing.Color.Red;
            this.emailInputWarning.Location = new System.Drawing.Point(808, 258);
            this.emailInputWarning.Name = "emailInputWarning";
            this.emailInputWarning.Size = new System.Drawing.Size(140, 19);
            this.emailInputWarning.TabIndex = 9;
            this.emailInputWarning.Text = "⚫ Not an e-mail";
            this.emailInputWarning.Visible = false;
            // 
            // phoneInputWarning
            // 
            this.phoneInputWarning.AutoSize = true;
            this.phoneInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInputWarning.ForeColor = System.Drawing.Color.Red;
            this.phoneInputWarning.Location = new System.Drawing.Point(808, 214);
            this.phoneInputWarning.Name = "phoneInputWarning";
            this.phoneInputWarning.Size = new System.Drawing.Size(195, 19);
            this.phoneInputWarning.TabIndex = 10;
            this.phoneInputWarning.Text = "⚫ Not a phone number";
            this.phoneInputWarning.Visible = false;
            // 
            // nameInputWarning
            // 
            this.nameInputWarning.AutoSize = true;
            this.nameInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputWarning.ForeColor = System.Drawing.Color.Red;
            this.nameInputWarning.Location = new System.Drawing.Point(809, 85);
            this.nameInputWarning.Name = "nameInputWarning";
            this.nameInputWarning.Size = new System.Drawing.Size(138, 19);
            this.nameInputWarning.TabIndex = 8;
            this.nameInputWarning.Text = "⚫ Field is empty";
            this.nameInputWarning.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "➔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "➔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "➔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "➔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "➔";
            // 
            // oldEmailTextBox
            // 
            this.oldEmailTextBox.Location = new System.Drawing.Point(188, 245);
            this.oldEmailTextBox.Name = "oldEmailTextBox";
            this.oldEmailTextBox.ReadOnly = true;
            this.oldEmailTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldEmailTextBox.TabIndex = 6;
            // 
            // oldPhoneTextBox
            // 
            this.oldPhoneTextBox.Location = new System.Drawing.Point(188, 202);
            this.oldPhoneTextBox.Name = "oldPhoneTextBox";
            this.oldPhoneTextBox.ReadOnly = true;
            this.oldPhoneTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldPhoneTextBox.TabIndex = 6;
            // 
            // oldCityTextBox
            // 
            this.oldCityTextBox.Location = new System.Drawing.Point(188, 159);
            this.oldCityTextBox.Name = "oldCityTextBox";
            this.oldCityTextBox.ReadOnly = true;
            this.oldCityTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldCityTextBox.TabIndex = 6;
            // 
            // oldAdressTextBox
            // 
            this.oldAdressTextBox.Location = new System.Drawing.Point(188, 116);
            this.oldAdressTextBox.Name = "oldAdressTextBox";
            this.oldAdressTextBox.ReadOnly = true;
            this.oldAdressTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldAdressTextBox.TabIndex = 6;
            // 
            // oldNameTextBox
            // 
            this.oldNameTextBox.Location = new System.Drawing.Point(188, 73);
            this.oldNameTextBox.Name = "oldNameTextBox";
            this.oldNameTextBox.ReadOnly = true;
            this.oldNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.oldNameTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 34);
            this.label9.TabIndex = 5;
            this.label9.Text = "Old information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "New information";
            // 
            // cityInputWarning
            // 
            this.cityInputWarning.AutoSize = true;
            this.cityInputWarning.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInputWarning.ForeColor = System.Drawing.Color.Red;
            this.cityInputWarning.Location = new System.Drawing.Point(809, 172);
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
            this.adressInputWarning.Location = new System.Drawing.Point(809, 128);
            this.adressInputWarning.Name = "adressInputWarning";
            this.adressInputWarning.Size = new System.Drawing.Size(138, 19);
            this.adressInputWarning.TabIndex = 4;
            this.adressInputWarning.Text = "⚫ Field is empty";
            this.adressInputWarning.Visible = false;
            // 
            // newEmailTextBox
            // 
            this.newEmailTextBox.Location = new System.Drawing.Point(518, 246);
            this.newEmailTextBox.Name = "newEmailTextBox";
            this.newEmailTextBox.Size = new System.Drawing.Size(284, 37);
            this.newEmailTextBox.TabIndex = 2;
            this.newEmailTextBox.Leave += new System.EventHandler(this.newEmailTextBox_Leave);
            // 
            // newPhoneTextBox
            // 
            this.newPhoneTextBox.Location = new System.Drawing.Point(518, 203);
            this.newPhoneTextBox.Name = "newPhoneTextBox";
            this.newPhoneTextBox.Size = new System.Drawing.Size(284, 37);
            this.newPhoneTextBox.TabIndex = 2;
            this.newPhoneTextBox.Leave += new System.EventHandler(this.newPhoneTextBox_Leave);
            // 
            // newCityTextBox
            // 
            this.newCityTextBox.Location = new System.Drawing.Point(519, 160);
            this.newCityTextBox.Name = "newCityTextBox";
            this.newCityTextBox.Size = new System.Drawing.Size(284, 37);
            this.newCityTextBox.TabIndex = 2;
            this.newCityTextBox.Leave += new System.EventHandler(this.newCityTextBox_Leave);
            // 
            // newAdressTextBox
            // 
            this.newAdressTextBox.Location = new System.Drawing.Point(519, 117);
            this.newAdressTextBox.Name = "newAdressTextBox";
            this.newAdressTextBox.Size = new System.Drawing.Size(284, 37);
            this.newAdressTextBox.TabIndex = 2;
            this.newAdressTextBox.Leave += new System.EventHandler(this.newAdressTextBox_Leave);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(518, 74);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(285, 37);
            this.newNameTextBox.TabIndex = 2;
            this.newNameTextBox.Leave += new System.EventHandler(this.newNameTextBox_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 76);
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
            this.buttonsPanel.Location = new System.Drawing.Point(5, 424);
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
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1033, 505);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.vehicleInfoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update customer";
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
        private System.Windows.Forms.TextBox newAdressTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.TextBox newCityTextBox;
        private System.Windows.Forms.Label cityInputWarning;
        private System.Windows.Forms.Label adressInputWarning;
        private System.Windows.Forms.TextBox oldEmailTextBox;
        private System.Windows.Forms.TextBox oldPhoneTextBox;
        private System.Windows.Forms.TextBox oldCityTextBox;
        private System.Windows.Forms.TextBox oldAdressTextBox;
        private System.Windows.Forms.TextBox oldNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameInputWarning;
        private System.Windows.Forms.TextBox newEmailTextBox;
        private System.Windows.Forms.TextBox newPhoneTextBox;
        private System.Windows.Forms.Label emailInputWarning;
        private System.Windows.Forms.Label phoneInputWarning;
    }
}