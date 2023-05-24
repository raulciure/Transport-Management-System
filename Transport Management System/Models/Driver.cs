using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    internal class Driver : Employee
    {
        private RouteType routeType;

        public Driver(string name, DateTime birthday, int employmentYear, int salary, RouteType routeType) 
            : base(name, birthday, employmentYear, salary)
        {
            this.routeType = routeType;
        }

        public RouteType RouteType { get => routeType; set => routeType = value; }

        public override string ToString()
        {
            return (base.ToString() + "," + this.RouteType.ToString());
        }
    }
}
