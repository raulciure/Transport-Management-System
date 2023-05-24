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
    public partial class UpdateVehicleForm : Form
    {
        internal Vehicle OldVehicle { get; set; }
        internal Vehicle NewVehicle { get; set; }
        internal bool ButtonFlag { get; set; } = false;

        private bool incorectInputFlag = true;

        internal UpdateVehicleForm(Vehicle oldVehicle)
        {
            InitializeComponent();
            this.OldVehicle = oldVehicle;
            loadOldVehicleData();
            initForm();
        }

        private void initForm()
        {
            newVehicleTypeComboBox.DataSource = Enum.GetValues(typeof(VehicleType));
            newVehicleTypeComboBox.SelectedItem = OldVehicle.Type;

            newVehicleNameTextBox.Text = OldVehicle.Name;

            newAquisitionYearTextBox.Text = OldVehicle.AquisitionYear.ToString();

            newMaxCargoTextBox.Text = OldVehicle.MaxCargoWeight.ToString();

            newLastServiceDateTimePick.Value = OldVehicle.LastService;
            newNextServiceDateTimePicker.Value = OldVehicle.NextService;
        }

        private void loadOldVehicleData()
        {
            oldVehicleTypeTextBox.Text = OldVehicle.Type.ToString();
            oldNameTextBox.Text = OldVehicle.Name;
            oldAquisitionYearTextBox.Text = OldVehicle.AquisitionYear.ToString();
            oldMaxCargoWeightTextBox.Text = OldVehicle.MaxCargoWeight.ToString();
            oldLastServiceTextBox.Text = OldVehicle.LastService.ToShortDateString();
            oldNextServiceTextBox.Text = OldVehicle.NextService.ToShortDateString();
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

        private void newAquisitionYearTextBox_Leave(object sender, EventArgs e)
        {
            string aqusitionYear_String = newAquisitionYearTextBox.Text;
            if (Int32.TryParse(aqusitionYear_String, out int aquisitionYear_int) == false)
            {
                incorectInputFlag = true;
                yearInputWarning.Visible = true;
            }
            else if (!(aquisitionYear_int >= 1950 && aquisitionYear_int <= DateTime.Now.Year))
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

        private void newMaxCargoTextBox_Leave(object sender, EventArgs e)
        {
            string maxCargoWeight_String = newMaxCargoTextBox.Text;
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

        private void newNameTextBox_Leave(object sender, EventArgs e)
        {
            if(newVehicleNameTextBox.Text == string.Empty)
            {
                nameInputWarning.Visible = true;
            }
            else
            {
                nameInputWarning.Visible = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ButtonFlag = true; // true when update button is chosen

            if (incorectInputFlag == false)
            {
                VehicleType vehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), newVehicleTypeComboBox.Text);
                string name = newVehicleNameTextBox.Text;
                int aquisitionYear = Int32.Parse(newAquisitionYearTextBox.Text);
                int maxCargoWeight = Int32.Parse(newMaxCargoTextBox.Text);
                DateTime lastService = newLastServiceDateTimePick.Value.Date;
                DateTime nextService = newNextServiceDateTimePicker.Value.Date;

                NewVehicle = new Vehicle(name, aquisitionYear, vehicleType, maxCargoWeight, lastService, nextService);

                this.Close();
            }
        }
    }
}
