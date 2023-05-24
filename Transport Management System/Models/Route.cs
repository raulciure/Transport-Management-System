using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    internal enum RouteType
    {
        DOMESTIC,
        INTERNATIONAL
    }

    internal class Route
    {
        private Customer customer;
        private string startPoint;
        private string endPoint;
        private DateTime arrivalTime;
        private RouteType routeType;
        private Vehicle assignedVehicle;
        private Driver assignedDriver;

        public Route(Customer customer, string startPoint, string endPoint, DateTime arrivalTime, RouteType routeType, Vehicle assignedVehicle, Driver assignedDriver)
        {
            this.customer = customer;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.arrivalTime = arrivalTime;
            this.routeType = routeType;
            this.assignedVehicle = assignedVehicle;
            this.assignedDriver = assignedDriver;
        }

        public Customer Customer { get => customer; set => customer = value; }
        public string StartPoint { get => startPoint; set => startPoint = value; }
        public string EndPoint { get => endPoint; set => endPoint = value; }
        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public RouteType RouteType { get => routeType; set => routeType = value; }
        public Vehicle AssignedVehicle { get => assignedVehicle; set => assignedVehicle = value; }
        public Driver AssignedDriver { get => assignedDriver; set => assignedDriver = value; }

        public override string ToString()
        {
            return (Customer.Name + "," + StartPoint + "," + EndPoint + "," + ArrivalTime + ","
                + RouteType.ToString() + "," + AssignedVehicle.Name + "," + AssignedDriver.Name);
        }
    }
}
