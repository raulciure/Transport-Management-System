using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    internal class Customer
    {
        private string name;
        private string adress;
        private string city;
        private string phone;
        private string email;

        public Customer(string name, string adress, string city, string phone, string email)
        {
            this.name = name;
            this.adress = adress;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string City { get =>  city; set => city = value; }
        public string Phone { get =>  phone; set => phone = value; }
        public string Email { get =>  email; set => email = value; }

        public override string ToString()
        {
            return (Name + "," + Adress + "," + City + ","
                + Phone + "," + Email);
        }
    }
}
