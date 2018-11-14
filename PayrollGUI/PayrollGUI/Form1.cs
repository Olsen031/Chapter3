using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name, socialSecurityNumber;
            double wage;
            int hoursWorked;
            double stateWithholding = 0.05;
            double federalWithholding = 0.15;
            double grossPay;
            double netPay;

            name = Convert.ToString(txtNameInput);

                
        }
    }
}
