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

namespace Transport_Management_System.Forms
{
    public partial class AuthForm : Form
    {
        private class User
        {
            private readonly string username;
            private readonly string password;

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public string Username { get => username; }
            public string Password { get => password; }

            public override bool Equals(object obj)
            {
                return obj is User user &&
                       username == user.username &&
                       password == user.password;
            }
        }

        private List<User> users = new List<User>();

        public AuthForm()
        {
            InitializeComponent();
            loadData("users_data.csv");
        }

        private void loadData(string user_data_file)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + user_data_file))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var lineContent = line.Split(',');
                        users.Add(new User(lineContent[0].Trim(), lineContent[1].Trim()));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("User data file not found!", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
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
            ExitConfirmationForm form = new ExitConfirmationForm();
            form.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var typedUsername = userTextBox.Text;
            var typedPassword = passwordTextBox.Text;

            var typedUser = new User(typedUsername, typedPassword);


            if (users.Contains(typedUser))
            {
                invalidLoginLabel.Visible = false;
                this.Hide();
                Form form = new MainForm();
                form.ShowDialog();
            }
            else
            {
                invalidLoginLabel.Visible = true;
            }
        }
    }
}
