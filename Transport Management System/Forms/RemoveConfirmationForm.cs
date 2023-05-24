using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Management_System.Forms
{
    public partial class RemoveConfirmationForm : Form
    {
        public bool RemoveStatus { get; set; } = false;
        public RemoveConfirmationForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            RemoveStatus = false;
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveStatus = true;
            this.Close();
        }
    }
}
