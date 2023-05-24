using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_Management_System.Models;

namespace Transport_Management_System.Forms
{
    public partial class CustomersManagementForm : Form
    {
        private List<Customer> customers = new List<Customer>();

        internal CustomersManagementForm(List<Customer> customers)
        {
            InitializeComponent();
            this.customers = customers;
            showData();
        }

        private void showData()
        {
            customersDataGridView.DataSource = null;
            customersDataGridView.DataSource = customers;
        }

        private void saveData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\" + "customers_data.csv"))
                {
                    customers.ForEach(customer => writer.WriteLine(customer));
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to save to file!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // [Start] Move window from banner operation
        private bool mouseDown = false;
        private Point lastLoc;

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLoc = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y);
                this.Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        // [End]

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            saveData();
            this.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
            if(form.ButtonFlag == true)
            {
                Customer newCustomer = form.NewCustomer;
                customers.Add(newCustomer);
                showData();
            }
        }

        private void updateSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer selectedCustomer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;

                UpdateCustomerForm form = new UpdateCustomerForm(selectedCustomer);
                form.ShowDialog();
                if (form.ButtonFlag == true)
                {
                    Customer newCustomer = form.NewCustomer;
                    var index = customers.IndexOf(selectedCustomer);
                    if(index >= 0) customers[index] = newCustomer;
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveConfirmationForm form = new RemoveConfirmationForm();
                form.ShowDialog();
                if (form.RemoveStatus == true)
                {
                    Customer removeCustomer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;
                    customers.Remove(removeCustomer);
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
