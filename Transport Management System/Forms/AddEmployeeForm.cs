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
    public partial class AddEmployeeForm : Form
    {
        internal Employee NewEmployee { get; set; }
        internal bool ButtonFlag { get; set; } = false;
        internal bool IsDriverFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        public AddEmployeeForm()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            employeeTypeComboBox.Items.Clear();
            employeeTypeComboBox.Items.Add("Regular employee");
            employeeTypeComboBox.Items.Add("Driver");

            birthdayDateTimePick.Value = DateTime.Now;

            driverRouteTypeComboBox.DataSource = Enum.GetValues(typeof(RouteType));

            driverLabel.Visible = false;
            driverRouteTypeComboBox.Visible = false;
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

        private void employeeTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(employeeTypeComboBox.SelectedItem.Equals("Driver"))
            {
                IsDriverFlag = true;
                driverRouteTypeComboBox.Visible = true;
                driverLabel.Visible = true;
            }
            else
            {
                IsDriverFlag = false;
                driverRouteTypeComboBox.Visible = false;
                driverLabel.Visible = false;
            }
        }

        private void employeeNameTextBox_Leave(object sender, EventArgs e)
        {
            if (employeeNameTextBox.Text == string.Empty)
            {
                incorectInputFlag = true;
                nameInputWarning.Visible = true;
            }
            else
            {
                incorectInputFlag |= false;
                nameInputWarning.Visible = false;
            }
        }

        private void employmentYearTextBox_Leave(object sender, EventArgs e)
        {
            string employmentYear_String = employmentYearTextBox.Text;
            if (Int32.TryParse(employmentYear_String, out int employmentYear_int) == false)
            {
                incorectInputFlag = true;
                yearInputWarning.Visible = true;
            }
            else if(!(employmentYear_int >= 1950 && employmentYear_int <= DateTime.Now.Year))
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

        private void salaryTextBox_Leave(object sender, EventArgs e)
        {
            string salary_String = salaryTextBox.Text;
            if(Int32.TryParse(salary_String, out _) == false)
            {
                incorectInputFlag = true;
                salaryInputWarning.Visible = true;
            }
            else
            {
                incorectInputFlag = false;
                salaryInputWarning.Visible = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when add button is chosen

            if (incorectInputFlag == false)
            {
                string name = employeeNameTextBox.Text;
                DateTime birthday = birthdayDateTimePick.Value.Date;
                int employmentYear = Int32.Parse(employmentYearTextBox.Text);
                int salary = Int32.Parse(salaryTextBox.Text);

                if (employeeTypeComboBox.SelectedItem.Equals("Driver"))
                {
                    RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), driverRouteTypeComboBox.Text);

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
