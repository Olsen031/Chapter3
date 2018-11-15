using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            int lastYearContestants;
            int thisYearContestants;
            int fee = 25;
            int moreContestants;
            int revenueThisYear;

            lastYearContestants = Convert.ToInt32(txtLastYearInput.Text);
            thisYearContestants = Convert.ToInt32(txtThisYearInput.Text);
            revenueThisYear = thisYearContestants * fee;

            lblThisYearRevenueOutput.Visible = true;
            lblMoreThanLastYear.Visible = true;

            lblThisYearRevenueOutput.Text = "The revenue for this year would be " + revenueThisYear.ToString("C");
            if (lastYearContestants > thisYearContestants)
            {
                moreContestants = lastYearContestants - thisYearContestants;
                lblMoreThanLastYear.Text = "This year had less contestants than last year, " + moreContestants + " less contestants to be exact.";
            }
            else if (lastYearContestants < thisYearContestants)
            {
                moreContestants = thisYearContestants - lastYearContestants;
                lblMoreThanLastYear.Text = "This year had more contestants than last year, " + moreContestants + " more contestants to be exact.";
            }
            else
            {
                lblMoreThanLastYear.Text = "This year had the exact same amount of contestants as last year.";
            }
            


        }
    }
}
