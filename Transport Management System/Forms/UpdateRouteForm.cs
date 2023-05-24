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
    public partial class UpdateRouteForm : Form
    {
        internal Route OldRoute { get; set; }

        internal List<Driver> drivers;
        internal List<Customer> customers;
        internal List<Vehicle> vehicles;
        internal Route NewRoute { get; set; }
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        internal UpdateRouteForm(Route oldRoute, List<Driver> drivers, List<Customer> customers, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.OldRoute = oldRoute;
            this.drivers = drivers;
            this.customers = customers;
            this.vehicles = vehicles;
            loadOldRouteData();
            initForm();
        }

        private void initForm()
        {
            newRouteTypeComboBox.DataSource = Enum.GetValues(typeof(RouteType));
            newRouteTypeComboBox.SelectedItem = OldRoute.RouteType;

            newCustomerComboBox.DataSource = customers;
            newCustomerComboBox.ValueMember = "Name";
            newVehicleComboBox.DisplayMember = "Name";

            newDepartureTextBox.Text = OldRoute.StartPoint;
            newDestinationTextBox.Text = OldRoute.EndPoint;

            newArrivalTimeDateTimePick.Value = DateTime.Now;

            newVehicleComboBox.DataSource = vehicles;
            newVehicleComboBox.ValueMember = "Name";
            newVehicleComboBox.DisplayMember = "Name";

            newDriverComboBox.DataSource = drivers;
            newDriverComboBox.ValueMember = "Name";
            newDriverComboBox.DisplayMember = "Name";
        }

        private void loadOldRouteData()
        {
            oldRouteTypeTextBox.Text = OldRoute.RouteType.ToString();
            oldCustomerTextBox.Text = OldRoute.Customer.Name;
            oldDepartureTextBox.Text = OldRoute.StartPoint;
            oldDestinationTextBox.Text = OldRoute.EndPoint;
            oldArrivalTimeTextBox.Text = OldRoute.ArrivalTime.ToString();
            oldVehicleTextBox.Text = OldRoute.AssignedVehicle.Name;
            oldDriverTextBox.Text = OldRoute.AssignedDriver.Name;
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

        private void newDepartureTextBox_Leave(object sender, EventArgs e)
        {
            if(newDepartureTextBox.Text == string.Empty)
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

        private void newDestinationTextBox_Leave(object sender, EventArgs e)
        {
            if(newDestinationTextBox.Text == string.Empty)
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when update button is chosen

            if (incorectInputFlag == false)
            {
                RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), newRouteTypeComboBox.Text);
                Customer customer = (Customer) newCustomerComboBox.SelectedItem;
                string departure = newDepartureTextBox.Text;
                string destination = newDestinationTextBox.Text;
                DateTime arrivalTime = newArrivalTimeDateTimePick.Value;
                Vehicle assignedVehicle = (Vehicle) newVehicleComboBox.SelectedItem;
                Driver assignedDriver = (Driver) newDriverComboBox.SelectedItem;

                NewRoute = new Route(customer, departure, destination, arrivalTime, routeType, assignedVehicle, assignedDriver);

                this.Close();
            }
        }
    }
}
