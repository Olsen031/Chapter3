using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class lblResult : Form
    {
        public lblResult()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            double test1, test2, test3, test4, test5;
            double average;
            test1 = Convert.ToDouble(txtScore1.Text);
            test2 = Convert.ToDouble(txtScore2.Text);
            test3 = Convert.ToDouble(txtScore3.Text);
            test4 = Convert.ToDouble(txtScore4.Text);
            test5 = Convert.ToDouble(txtScore5.Text);
            average = (test1 + test2 + test3 + test4 + test5) / 5;
            lblResult1.Visible = true;
            lblResult1.Text = "Your average test score is: " + average + "%";


        }
    }
}
