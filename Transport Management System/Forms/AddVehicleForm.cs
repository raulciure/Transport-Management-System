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
    public partial class AddVehicleForm : Form
    {
        internal Vehicle NewVehicle { get; set; }
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        public AddVehicleForm()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            vehicleTypeComboBox.DataSource = Enum.GetValues(typeof(VehicleType));
            lastServiceDateTimePick.Value = DateTime.Now;
            nextServiceDateTimePicker.Value = DateTime.Now;
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

        private void aquisitionYearTextBox_Leave(object sender, EventArgs e)
        {
            string aqusitionYear_String = aquisitionYearTextBox.Text;
            if (Int32.TryParse(aqusitionYear_String, out int aquisitionYear_int) == false)
            {
                incorectInputFlag = true;
                yearInputWarning.Visible = true;
            }
            else if(!(aquisitionYear_int >= 1950 && aquisitionYear_int <= DateTime.Now.Year))
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

        private void maxCargoTextBox_Leave(object sender, EventArgs e)
        {
            string maxCargoWeight_String = maxCargoTextBox.Text;
            if(Int32.TryParse(maxCargoWeight_String, out _) == false)
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

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                nameInputWarning.Visible = true;
            }
            else
            {
                nameInputWarning.Visible = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when add button is chosen

            if (incorectInputFlag == false)
            {
                VehicleType vehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), vehicleTypeComboBox.Text);
                string name = nameTextBox.Text;
                int aquisitionYear = Int32.Parse(aquisitionYearTextBox.Text);
                int maxCargoWeight = Int32.Parse(maxCargoTextBox.Text);
                DateTime lastService = lastServiceDateTimePick.Value.Date;
                DateTime nextService = nextServiceDateTimePicker.Value.Date;

                NewVehicle = new Vehicle(name, aquisitionYear, vehicleType, maxCargoWeight, lastService, nextService);

                this.Close();
            }
        }
    }
}
