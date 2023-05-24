using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_Management_System.Models;

namespace Transport_Management_System.Forms
{
    public partial class AddCustomerForm : Form
    {
        internal Customer NewCustomer { get; set; }
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        public AddCustomerForm()
        {
            InitializeComponent();
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


        private void customerNameTextBox_Leave(object sender, EventArgs e)
        {
            if(customerNameTextBox.Text == string.Empty)
            {
                nameInputWarning.Visible = true;
                incorectInputFlag = true;
            }
            else
            {
                nameInputWarning.Visible = false;
                incorectInputFlag = false;
            }
        }

        private void customerAdressTextBox_Leave(object sender, EventArgs e)
        {
            if (customerAdressTextBox.Text == string.Empty)
            {
                adressInputWarning.Visible = true;
                incorectInputFlag = true;
            }
            else
            {
                adressInputWarning.Visible = false;
                incorectInputFlag = false;
            }
        }

        private void customerCityTextBox_Leave(object sender, EventArgs e)
        {
            if (customerCityTextBox.Text == string.Empty)
            {
                cityInputWarning.Visible = true;
                incorectInputFlag = true;
            }
            else
            {
                cityInputWarning.Visible = false;
                incorectInputFlag = false;
            }
        }

        private void customerPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(customerPhoneTextBox.Text, @"[0-9]+$"))
            {
                phoneInputWarning.Visible = false;
                incorectInputFlag = false;
            }
            else
            {
                phoneInputWarning.Visible = true;
                incorectInputFlag = true;
            }
        }

        private bool checkEmail(string email)
        {
            var trimmedEmail = email;
            if (trimmedEmail.EndsWith("."))
                return false;

            try
            {
                var mailAdress = new MailAddress(email);
                return mailAdress.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void customerEmailTextBox_Leave(object sender, EventArgs e)
        {
            if(checkEmail(customerEmailTextBox.Text) == true)
            {
                emailInputWarning.Visible = false;
                incorectInputFlag = false;
            }
            else
            {
                emailInputWarning.Visible = true;
                incorectInputFlag = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when add button is chosen

            if (incorectInputFlag == false)
            {
                string name = customerNameTextBox.Text;
                string adress = customerAdressTextBox.Text;
                string city = customerCityTextBox.Text;
                string phone = customerPhoneTextBox.Text;
                string email = customerEmailTextBox.Text;

                NewCustomer = new Customer(name, adress, city, phone, email);

                this.Close();
            }
        }
    }
}
