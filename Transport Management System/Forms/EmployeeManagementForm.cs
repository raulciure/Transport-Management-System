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
    public partial class EmployeeManagementForm : Form
    {
        private List<Employee> employees = new List<Employee>();

        private Employee selectedEmployee;

        internal EmployeeManagementForm(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            showData();
        }

        private List<Employee> getRegularEmployees()
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee e in employees)
            {
                if(!(e is Driver))
                    result.Add(e);
            }
            return result;
        }

        private List<Driver> getDrivers()
        {
            List<Driver> result = new List<Driver>();
            foreach (Employee e in employees)
            {
                if(e is Driver)
                    result.Add((Driver)e);
            }
            return result;
        }

        private void showData()
        {
            employeesDataGridView.DataSource = null;
            employeesDataGridView.DataSource = getRegularEmployees(); ;

            driversDataGridView.DataSource = null;
            driversDataGridView.DataSource = getDrivers();
        }

        private void saveData()
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\" + "employees_data.csv"))
                {
                    foreach (Employee e in employees)
                    {
                        if (e is Driver)
                        {
                            var driver = (Driver)e;
                            writer.WriteLine(driver);
                        }
                        else
                        {
                            writer.WriteLine(e);
                        }
                    }
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

        private void employeesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(employeesDataGridView.CurrentRow == null)
            {
                selectedEmployee = null;
            }
            else
            {
                selectedEmployee = (Employee)employeesDataGridView.CurrentRow.DataBoundItem;
            }
        }

        private void driversDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(driversDataGridView.CurrentRow == null)
            {
                selectedEmployee = null;
            }
            else
            {
                selectedEmployee = (Driver)driversDataGridView.CurrentRow.DataBoundItem;
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            if(addEmployeeForm.ButtonFlag == true)
            {
                Employee newEmployee = addEmployeeForm.NewEmployee;
                employees.Add(newEmployee);
                showData();
            }
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveConfirmationForm rcForm = new RemoveConfirmationForm();
                rcForm.ShowDialog();
                if (rcForm.RemoveStatus == true)
                {
                    employees.Remove(selectedEmployee);
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void updateSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm(selectedEmployee);
                updateEmployeeForm.ShowDialog();
                bool buttonFlag = updateEmployeeForm.ButtonFlag;
                if (buttonFlag)
                {
                    Employee newEmployee = updateEmployeeForm.NewEmployee;
                    var index = employees.IndexOf(selectedEmployee);
                    if(index >= 0) employees[index] = newEmployee;
                    showData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
