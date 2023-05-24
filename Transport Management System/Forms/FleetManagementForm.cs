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
    public partial class FleetManagementForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        internal FleetManagementForm(List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            initForm();
            showData();
        }

        private void initForm()
        {
            updateSelectedButton.Enabled = false;
            removeSelectedButton.Enabled = false;
        }

        private void showData()
        {
            fleetDataGridView.DataSource = null;
            fleetDataGridView.DataSource = vehicles;
        }

        private void saveData()
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\" + "vehicles_data.csv"))
                {
                    vehicles.ForEach(vehicle => writer.WriteLine(vehicle) );
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
            //MessageBox.Show("Elemets in list: " + vehicles.Count.ToString());
            saveData();
            this.Close();
        }

        private void fleetDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateSelectedButton.Enabled = true;
            removeSelectedButton.Enabled = true;
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveConfirmationForm form = new RemoveConfirmationForm();
                form.ShowDialog();
                if (form.RemoveStatus == true)
                {
                    Vehicle removeVehicle = (Vehicle)fleetDataGridView.CurrentRow.DataBoundItem;
                    vehicles.Remove(removeVehicle);
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.ShowDialog();
            if(addVehicleForm.ButtonFlag == true)
            {
                Vehicle newVehicle = addVehicleForm.NewVehicle;
                vehicles.Add(newVehicle);
                showData();
            }
        }

        private void updateSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle selectedVehicle = (Vehicle)fleetDataGridView.CurrentRow.DataBoundItem;

                UpdateVehicleForm updateVehicleForm = new UpdateVehicleForm(selectedVehicle);
                updateVehicleForm.ShowDialog();
                if (updateVehicleForm.ButtonFlag == true)
                {
                    Vehicle newVehicle = updateVehicleForm.NewVehicle;
                    var index = vehicles.IndexOf(selectedVehicle);
                    if(index >= 0) vehicles[index] = newVehicle;
                    showData();
                }
            }
            catch (Exception) { MessageBox.Show("No item selected or selection problem", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
