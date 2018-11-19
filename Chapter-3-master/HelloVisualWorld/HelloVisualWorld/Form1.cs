using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click_1(object sender, EventArgs e)
        {
            lblHello.Visible = true;
            lblHello.Text = "Hello, Visual World!";
        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Goodbye";
        }

        private void btnClickLast_Click(object sender, EventArgs e)
        {
            lblHello.Visible = false;
        }
    }
}
