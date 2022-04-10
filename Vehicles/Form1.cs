using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Vehicle newVehicle = new Vehicle();
            newVehicle.Wheels = int.Parse(txtWheels.Text);
            newVehicle.Color = txtColor.Text;

            lblMessageOutput.Text = newVehicle.ToString();

            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWheels.Clear();
            txtColor.Clear();
            txtMake.Clear();
            txtModel.Clear();

            lblMessageOutput.ResetText();

           //vehicles.Clear();

            txtWheels.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
