using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double miles;
            double milesInKilometers = 1.6;
            double total;
            miles = Convert.ToDouble(txtMiles.Text);
            total = milesInKilometers * miles;
            lblConversionValue.Text = "Total kilometers is equal to: " + total + "km";
         }
    }
}
