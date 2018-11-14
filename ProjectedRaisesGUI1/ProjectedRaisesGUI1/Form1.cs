using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI1
{
    public partial class ProjectedRaisesGUI : Form
    {
        public ProjectedRaisesGUI()
        {
            InitializeComponent();
        }

        double rate = 1.04;
        private void button1_Click(object sender, EventArgs e)
        {
           
        
            double employee1;
            double employee1NewSalary;
          
            employee1 = Convert.ToDouble(txtbox1.Text);
            employee1NewSalary = employee1 * rate;

     

            lblResult1.Text = "Employee 1's salary for next year will be: " + employee1NewSalary.ToString("C");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double employee2;
            double employee2NewSalary;

            employee2 = Convert.ToDouble(txtbox2.Text);
            employee2NewSalary = employee2 * rate;

      

            lblResult2.Text = "Employee 2's salary for next year will be: " + employee2NewSalary.ToString("C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
      

            double employee3;
            double employee3NewSalary;

            employee3 = Convert.ToDouble(txtbox3.Text);
            employee3NewSalary = employee3 * rate;

       

            lblResult3.Text = "Employee 1's salary for next year will be: " + employee3NewSalary.ToString("C");
        }
    }
}
