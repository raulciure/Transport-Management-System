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
    public partial class RouteManagementForm : Form
    {
        private List<Route> routes = new List<Route>();
        private List<Customer> customers = new List<Customer>();
        private List<Driver> drivers = new List<Driver>();
        private List<Vehicle> vehicles = new List<Vehicle>();

        internal RouteManagementForm(List<Route> routes, List<Customer> customers, List<Driver> drivers, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.routes = routes;
            this.customers = customers;
            this.drivers = drivers;
            this.vehicles = vehicles;
            showData();
        }

        private void showData()
        {
            routesDataGridView.DataSource = null;
            routesDataGridView.DataSource = routes;
        }

        private void saveData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\" + "routes_data.csv"))
                {
                    routes.ForEach(route => writer.WriteLine(route));
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
            AddRouteForm form = new AddRouteForm(drivers, customers, vehicles);
            form.ShowDialog();
            if(form.ButtonFlag == true)
            {
                Route newRoute = form.NewRoute;
                routes.Add(newRoute);
                showData();
            }
        }

        private void updateSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                Route selectedRoute = (Route)routesDataGridView.CurrentRow.DataBoundItem;

                UpdateRouteForm form = new UpdateRouteForm(selectedRoute, drivers, customers, vehicles);
                form.ShowDialog();
                if (form.ButtonFlag == true)
                {
                    Route updatedRoute = form.NewRoute;
                    var index = routes.IndexOf(selectedRoute);
                    if(index >= 0) routes[index] = updatedRoute;
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
                    Route removeRoute = (Route)routesDataGridView.CurrentRow.DataBoundItem;
                    routes.Remove(removeRoute);
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
