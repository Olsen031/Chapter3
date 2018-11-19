using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int result;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            result = num1 + num2;
            lblResult.Text = "The sum is " + result;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int result;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            result = num1 - num2;
            lblResult.Text = "The subtraction is " + result;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double result;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            result = num1 / num2;
            lblResult.Text = "The division is " + result;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double result;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            result = num1 * num2;
            lblResult.Text = "The multiplication is " + result;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int result;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            result = num1 % num2;
            lblResult.Text = "The remainder is " + result;
        }
    }
}
