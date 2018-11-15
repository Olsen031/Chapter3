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
            double hoursWorked;
            double stateWithholding;
            double federalWithholding;
            double grossPay;
            double netPay;

            name = Convert.ToString(txtNameInput.Text);
            socialSecurityNumber = Convert.ToString(txtSSNInput.Text);

            wage = Convert.ToDouble(txtHourlyWageInput.Text);
            hoursWorked = Convert.ToDouble(txtHoursWorkedInput.Text);

            grossPay = wage * hoursWorked;
            stateWithholding = 0.05 * grossPay;
            federalWithholding = 0.15 * grossPay;
            netPay = grossPay - stateWithholding - federalWithholding;

            lblNameAndSSNOutput.Visible = true;
            lblGrossPayOutput.Visible = true;
            lblStateWithholdingOutput.Visible = true;
            lblFederalWithholdingOutput.Visible = true;
            lblNetPayOutput.Visible = true;

            lblNameAndSSNOutput.Text = "Thank your for entering your information, " + name + ". Your SSN is " + socialSecurityNumber;
            lblGrossPayOutput.Text = "Your gross pay before any taxes is: " + grossPay.ToString("C");
            lblStateWithholdingOutput.Text = "Your State Withholding Tax will result in " + stateWithholding.ToString("C");
            lblFederalWithholdingOutput.Text = "Your Federal Withholding Tax will result in " + federalWithholding.ToString("C");
            lblNetPayOutput.Text = "Your total pay after taxes will be " + netPay.ToString("C");




                
        }
    }
}
