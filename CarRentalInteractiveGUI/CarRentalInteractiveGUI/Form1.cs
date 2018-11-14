using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       double pricePerMile = .25;
       double pricePerDay = 20;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double days;
            double miles;
            double total;
            days = Convert.ToDouble(txtDays.Text);
            miles = Convert.ToDouble(txtMiles.Text);
            total = miles * pricePerMile + pricePerDay * days;


            lblResult.Visible = true;
            lblResult.Text = "Your total cost will be " + total.ToString("C"); 

        }
    }
}
