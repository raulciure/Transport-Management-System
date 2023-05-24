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
    public partial class AddRouteForm : Form
    {
        internal Route NewRoute { get; set; }

        internal List<Driver> drivers;
        internal List<Customer> customers;
        internal List<Vehicle> vehicles;
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        internal AddRouteForm(List<Driver> drivers, List<Customer> customers, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.drivers = drivers;
            this.customers = customers;
            this.vehicles = vehicles;
            initForm();
        }

        private void initForm()
        {
            routeTypeComboBox.DataSource = Enum.GetValues(typeof(RouteType));

            customersComboBox.DataSource = customers;
            customersComboBox.ValueMember = "Name";
            customersComboBox.DisplayMember = "Name";

            arrivalTimeDateTimePick.Value = DateTime.Now;

            vehiclesComboBox.DataSource = vehicles;
            vehiclesComboBox.ValueMember = "Name";
            vehiclesComboBox.DisplayMember = "Name";

            driversComboBox.DataSource = drivers;
            driversComboBox.ValueMember = "Name";
            driversComboBox.DisplayMember = "Name";
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

        private void departureTextBox_Leave(object sender, EventArgs e)
        {
            if (departureTextBox.Text == string.Empty)
            {
                departureInputWarning.Visible = true;
                incorectInputFlag = true;
            }
            else
            {
                departureInputWarning.Visible = false;
                incorectInputFlag = false;
            }
        }

        private void destinationTextBox_Leave(object sender, EventArgs e)
        {
            if (destinationTextBox.Text == string.Empty)
            {
                destinationInputWarning.Visible = true;
                incorectInputFlag = true;
            }
            else
            {
                destinationInputWarning.Visible = false;
                incorectInputFlag = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when add button is chosen

            if (incorectInputFlag == false)
            {
                RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), routeTypeComboBox.SelectedItem.ToString());
                //Customer customer = customers.Find(x => x.Name.Equals(customersComboBox.SelectedItem.ToString()));
                Customer customer = (Customer) customersComboBox.SelectedItem;
                string departure = departureTextBox.Text;
                string destination = destinationTextBox.Text;
                DateTime arrivalTime = arrivalTimeDateTimePick.Value;
                //Vehicle vehicle = vehicles.Find(x => x.Name.Equals(vehiclesComboBox.SelectedItem.ToString()));
                //Driver driver = drivers.Find(x => x.Name.Equals(driversComboBox.SelectedItem.ToString()));
                Vehicle vehicle = (Vehicle) vehiclesComboBox.SelectedItem;
                Driver driver = (Driver) driversComboBox.SelectedItem;

                NewRoute = new Route(customer, departure, destination, arrivalTime, routeType, vehicle, driver);

                this.Close();
            }
        }
    }
}
