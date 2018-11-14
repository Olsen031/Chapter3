using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int chicken1, chicken2, chicken3, chicken4, chicken5;
            int dozen = 12;
            int remainder;
            int total;
            int dozenTotal;
            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);
            chicken5 = Convert.ToInt32(txtChicken5.Text);
            total = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            remainder = total % dozen;
            dozenTotal = total / dozen;
            lblResult.Visible = true;
            lblResult.Text = total + " eggs is " + dozenTotal + " with " + remainder + " left over";
            

        }
    }
}
