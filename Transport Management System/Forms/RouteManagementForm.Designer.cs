namespace Transport_Management_System.Forms
{
    partial class RouteManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteManagementForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.routeDataViewPanel = new System.Windows.Forms.Panel();
            this.routesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.updateSelectedButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.routeDataViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
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
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(943, 100);
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
            this.exitButton.Location = new System.Drawing.Point(915, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(884, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route Management";
            // 
            // routeDataViewPanel
            // 
            this.routeDataViewPanel.Controls.Add(this.routesDataGridView);
            this.routeDataViewPanel.Location = new System.Drawing.Point(12, 106);
            this.routeDataViewPanel.Name = "routeDataViewPanel";
            this.routeDataViewPanel.Size = new System.Drawing.Size(919, 258);
            this.routeDataViewPanel.TabIndex = 3;
            // 
            // routesDataGridView
            // 
            this.routesDataGridView.AllowUserToAddRows = false;
            this.routesDataGridView.AllowUserToDeleteRows = false;
            this.routesDataGridView.AllowUserToResizeRows = false;
            this.routesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.routesDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.routesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesDataGridView.Location = new System.Drawing.Point(4, 4);
            this.routesDataGridView.MultiSelect = false;
            this.routesDataGridView.Name = "routesDataGridView";
            this.routesDataGridView.ReadOnly = true;
            this.routesDataGridView.RowHeadersWidth = 62;
            this.routesDataGridView.RowTemplate.Height = 28;
            this.routesDataGridView.Size = new System.Drawing.Size(912, 251);
            this.routesDataGridView.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonsPanel.Controls.Add(this.removeSelectedButton);
            this.buttonsPanel.Controls.Add(this.updateSelectedButton);
            this.buttonsPanel.Controls.Add(this.addNewButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 374);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(943, 84);
            this.buttonsPanel.TabIndex = 4;
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.Color.Red;
            this.removeSelectedButton.FlatAppearance.BorderSize = 0;
            this.removeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeSelectedButton.Location = new System.Drawing.Point(687, 13);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(245, 58);
            this.removeSelectedButton.TabIndex = 0;
            this.removeSelectedButton.Text = "Remove selected";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // updateSelectedButton
            // 
            this.updateSelectedButton.BackColor = System.Drawing.Color.ForestGreen;
            this.updateSelectedButton.FlatAppearance.BorderSize = 0;
            this.updateSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSelectedButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSelectedButton.Location = new System.Drawing.Point(263, 13);
            this.updateSelectedButton.Name = "updateSelectedButton";
            this.updateSelectedButton.Size = new System.Drawing.Size(418, 58);
            this.updateSelectedButton.TabIndex = 0;
            this.updateSelectedButton.Text = "Update selected";
            this.updateSelectedButton.UseVisualStyleBackColor = false;
            this.updateSelectedButton.Click += new System.EventHandler(this.updateSelectedButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.Gold;
            this.addNewButton.FlatAppearance.BorderSize = 0;
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(12, 13);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(245, 58);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add new";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // RouteManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(943, 458);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.routeDataViewPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouteManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Route Management";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.routeDataViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel routeDataViewPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Button updateSelectedButton;
        private System.Windows.Forms.DataGridView routesDataGridView;
    }
}