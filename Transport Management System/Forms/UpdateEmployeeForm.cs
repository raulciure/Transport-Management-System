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
    public partial class UpdateEmployeeForm : Form
    {
        internal Employee OldEmployee { get; set; }
        internal Employee NewEmployee { get; set; }
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        internal UpdateEmployeeForm(Employee oldEmployee)
        {
            InitializeComponent();
            this.OldEmployee = oldEmployee;
            loadOldEmployeeData();
            initForm();
        }

        private void initForm()
        {
            newEmployeeTypeComboBox.DataSource = new List<string> { "Regular employee", "Driver" };
            newNameTextBox.Text = OldEmployee.Name;
            newBirthdayDateTimePicker.Value = DateTime.Now;
            newEmploymenyYearTextBox.Text = OldEmployee.EmploymentYear.ToString();
            newSalaryTextBox.Text = OldEmployee.Salary.ToString();
        }

        private void loadOldEmployeeData()
        {
            oldNameTextBox.Text = OldEmployee.Name;
            oldBirthdayTextBox.Text = OldEmployee.Birthday.ToShortDateString();
            oldEmploymentYearTextBox.Text = OldEmployee.EmploymentYear.ToString();
            oldSalaryTextBox.Text = OldEmployee.Salary.ToString();
            routeTypeComboBox.DataSource = Enum.GetValues(typeof(RouteType));

            string oldEmployeeType = string.Empty;
            if(OldEmployee is Driver)
            {
                Driver localDriver = (Driver)OldEmployee;
                oldEmployeeType = "Driver";

                driverLabel.Visible = true;
                oldDriverRouteTypeTextBox.Visible = true;
                oldDriverRouteTypeTextBox.Text = localDriver.RouteType.ToString();
            }
            else
            {
                oldEmployeeType = "Regular employee";
                driverLabel.Visible = false;
                oldDriverRouteTypeTextBox.Visible = false;
            }
            oldEmployeeTypeTextBox.Text = oldEmployeeType;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = false; // false when cancel button is chosen
            this.Close();
        }

        private void newEmployeeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newEmployeeTypeComboBox.SelectedItem.Equals("Driver"))
            {
                driverArrow.Visible = true;
                routeTypeComboBox.Visible = true;
            }
            else
            {
                driverArrow.Visible = false;
                routeTypeComboBox.Visible= false;
            }
        }

        private void newEmploymenyYearTextBox_Leave(object sender, EventArgs e)
        {
            string employmentYear_String = newEmploymenyYearTextBox.Text;
            if (Int32.TryParse(employmentYear_String, out int employmentYear_int) == false)
            {
                incorectInputFlag = true;
                yearInputWarning.Visible = true;
            }
            else if (!(employmentYear_int >= 1950 && employmentYear_int <= DateTime.Now.Year))
            {
                incorectInputFlag = true;
                yearInputWarning.Visible = true;
            }
            else
            {
                incorectInputFlag = false;
                yearInputWarning.Visible = false;
            }
        }

        private void newSalaryTextBox_Leave(object sender, EventArgs e)
        {
            string salary_String = newSalaryTextBox.Text;
            if(Int32.TryParse(salary_String, out _) == false)
            {
                incorectInputFlag = true;
                weightInputWarning.Visible = true;
            }
            else
            {
                incorectInputFlag = false;
                weightInputWarning.Visible = false;
            }
        }

        private void newNameTextBox_Leave(object sender, EventArgs e)
        {
            if(newNameTextBox.Text == string.Empty)
            {
                nameInputWarning.Visible = true;
            }
            else
            {
                nameInputWarning.Visible = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when update button is chosen

            if (incorectInputFlag == false)
            {
                string name = newNameTextBox.Text;
                DateTime birthday = newBirthdayDateTimePicker.Value.Date;
                int employmentYear = Int32.Parse(newEmploymenyYearTextBox.Text);
                int salary = Int32.Parse(newSalaryTextBox.Text);

                if(newEmployeeTypeComboBox.SelectedItem.Equals("Driver"))
                {
                    RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), routeTypeComboBox.SelectedItem.ToString());

                    NewEmployee = new Driver(name, birthday, employmentYear, salary, routeType);
                }
                else
                {
                    NewEmployee = new Employee(name, birthday, employmentYear, salary);
                }

                this.Close();
            }
        }
    }
}
