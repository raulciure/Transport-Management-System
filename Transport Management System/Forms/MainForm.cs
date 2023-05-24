using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Transport_Management_System.Models;

namespace Transport_Management_System.Forms
{
    public partial class MainForm : Form
    {
        private List<Route> routes = new List<Route>();
        private List<Customer> customers = new List<Customer>();
        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<Employee> employees = new List<Employee>();


        public MainForm()
        {
            InitializeComponent();

            loadCustomersData();
            loadEmployeesData();
            loadVehicleData();
            loadRoutesData();
            
            initForm();
        }

        private void loadCustomersData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + "customers_data.csv"))
                {
                    customers.Clear();

                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var lineContent = line.Split(',');

                        string name = lineContent[0].Trim();
                        string adress = lineContent[1].Trim();
                        string city = lineContent[2].Trim();
                        string phone = lineContent[3].Trim();
                        string email = lineContent[4].Trim();

                        Customer newCustomer = new Customer(name, adress, city, phone, email);
                        customers.Add(newCustomer);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Customers data file not found!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadEmployeesData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + "employees_data.csv"))
                {
                    employees.Clear();

                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var lineContent = line.Split(',');

                        string name = lineContent[0].Trim();
                        DateTime birthday = DateTime.Parse(lineContent[1].Trim());
                        int employmentYear = Int32.Parse(lineContent[2].Trim());
                        int salary = Int32.Parse(lineContent[3].Trim());

                        if(lineContent.Length == 5)
                        {
                            RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), lineContent[4].Trim());
                            Driver newDriver = new Driver(name, birthday, employmentYear, salary, routeType);
                            employees.Add(newDriver);
                        }
                        else
                        {
                            Employee newEmployee = new Employee(name, birthday, employmentYear, salary);
                            employees.Add(newEmployee);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Employees data file not found!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadVehicleData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + "vehicles_data.csv"))
                {
                    vehicles.Clear();

                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var lineContent = line.Split(',');

                        string name = lineContent[0].Trim();
                        int aquisitionYear = Int32.Parse(lineContent[1].Trim());
                        VehicleType vehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), lineContent[2].Trim());
                        int maxCargoWeight = Int32.Parse(lineContent[3].Trim());
                        DateTime lastService = DateTime.Parse(lineContent[4].Trim());
                        DateTime nextService = DateTime.Parse(lineContent[5].Trim());

                        Vehicle newVehicle = new Vehicle(name, aquisitionYear, vehicleType, maxCargoWeight, lastService, nextService);
                        vehicles.Add(newVehicle);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Vehicles data file not found!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadRoutesData()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + "routes_data.csv"))
                {
                    routes.Clear();

                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        var lineContent = line.Split(',');

                        string customerName = lineContent[0].Trim();
                        Customer customer = customers.Find(x => x.Name.Equals(customerName));

                        DateTime arrivalTime = DateTime.Parse(lineContent[3].Trim());

                        RouteType routeType = (RouteType)Enum.Parse(typeof(RouteType), lineContent[4].Trim());

                        string vehicleName = lineContent[5].Trim();
                        Vehicle vehicle = vehicles.Find(x => x.Name.Equals(vehicleName));

                        string driverName = lineContent[6].Trim();
                        Driver driver = (Driver)employees.Find(x => x.GetType() == typeof(Driver) && x.Name.Equals(driverName));

                        Route route = new Route(customer, lineContent[1].Trim(), lineContent[2].Trim(), arrivalTime, routeType, vehicle, driver);

                        routes.Add(route);
                    }
                }

                //List<string> routesNameList = routes.Select(x => x.Customer.Name).ToList();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Routes data file not found!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initForm()
        {
            todayDeliveryBox.DataSource = routes.FindAll(x => x.ArrivalTime.Date == DateTime.Now.Date)
                .Select(x => x.Customer.Name).ToList();
            deliveryDetailsTextBox.Text = string.Empty;
        }

        private string routeToString(Route route)
        {
            // Inherent route attributes
            string startPoint = route.StartPoint;
            string endPoint = route.EndPoint;
            string arrivalTime = route.ArrivalTime.ToString();
            string routeType = route.RouteType.ToString();

            // Customer attributes
            string customerName = route.Customer.Name;
            string customerAdress = route.Customer.Adress;
            string customerCity = route.Customer.City;
            string customerPhone = route.Customer.Phone;
            string customerEmail = route.Customer.Email;

            // Vehicle attributes
            string assignedVehicleName = route.AssignedVehicle.Name;
            int assignedVehicleAquisitionYear = route.AssignedVehicle.AquisitionYear;
            string assignedVehicleType = route.AssignedVehicle.Type.ToString();
            int assignedVehicleMaxCargoWeight = route.AssignedVehicle.MaxCargoWeight;
            string assignedVehicleLastService = route.AssignedVehicle.LastService.ToString();
            string assignedVehicleNextService = route.AssignedVehicle.NextService.ToString();

            // Driver attributes
            string assignedDriverName = route.AssignedDriver.Name;

            DateTime assignedDriverBirthday = route.AssignedDriver.Birthday;
            DateTime nowDate = DateTime.Now;
            TimeSpan timeSpan = nowDate - assignedDriverBirthday;
            DateTime zeorTime = new DateTime(1, 1, 1);
            int assignedDriverAge = (zeorTime + timeSpan).Year - 1;

            int assignedDriverEmploymentYear = route.AssignedDriver.EmploymentYear;
            int assignedDriverSalary = route.AssignedDriver.Salary;
            string assignedDriverRouteType = route.AssignedDriver.RouteType.ToString();

            string output = "Customer: "
                + "\r\n\tName: " + customerName
                + "\r\n\tAdress: " + customerAdress
                + "\r\n\tCity: " + customerCity
                + "\r\n\tPhone: " + customerPhone
                + "\r\n\tEmail: " + customerEmail
                + "\r\nDeparture: " + startPoint
                + "\r\nDestination: " + endPoint
                + "\r\nArrival date/time: " + arrivalTime
                + "\r\nRoute type: " + routeType
                + "\r\nVehicle:"
                + "\r\n\tName: " + assignedVehicleName
                + "\r\n\tAquisition year: " + assignedVehicleAquisitionYear
                + "\r\n\tType: " + assignedVehicleType
                + "\r\n\tMax. cargo load: " + assignedVehicleMaxCargoWeight
                + "\r\n\tLast service: " + assignedVehicleLastService
                + "\r\n\tNext service: " + assignedVehicleNextService
                + "\r\nDriver:"
                + "\r\n\tName: " + assignedDriverName
                + "\r\n\tAge: " + assignedDriverAge
                + "\r\n\tEmployment year: " + assignedDriverEmploymentYear
                + "\r\n\tSalary: " + assignedDriverSalary
                + "\r\n\tRoute type: " + assignedDriverRouteType;

            return output;
        }

        private void todayDeliveryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Route selectedRoute = routes.Find(x => x.Customer.Name.Equals(todayDeliveryBox.SelectedItem));
            if (selectedRoute != null)
            {
                deliveryDetailsTextBox.Text = routeToString(selectedRoute);
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
            ExitConfirmationForm exitForm = new ExitConfirmationForm();
            exitForm.ShowDialog();
        }

        private void manageFleetButton_Click(object sender, EventArgs e)
        {
            FleetManagementForm fmForm = new FleetManagementForm(vehicles);
            fmForm.ShowDialog();

            // reload data after child form has output to file
            loadVehicleData();
        }

        private void manageEmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm emForm = new EmployeeManagementForm(employees);
            emForm.ShowDialog();

            // reload data after child form has output to file
            loadEmployeesData();
        }

        private void manageRoutesButton_Click(object sender, EventArgs e)
        {
            var drivers = getDrivers();
            RouteManagementForm rmForm = new RouteManagementForm(routes, customers, drivers, vehicles);
            rmForm.ShowDialog();

            // reload data after child form has output to file
            loadRoutesData();
            initForm();
        }

        private void manageCustomersButton_Click(object sender, EventArgs e)
        {
            CustomersManagementForm cmForm = new CustomersManagementForm(customers);
            cmForm.ShowDialog();

            // reload data after child form has output to file
            loadCustomersData();
        }

        private List<Driver> getDrivers()
        {
            List<Driver> result = new List<Driver>();
            foreach (Employee e in employees)
            {
                if (e is Driver)
                    result.Add((Driver)e);
            }
            return result;
        }
    }
}
