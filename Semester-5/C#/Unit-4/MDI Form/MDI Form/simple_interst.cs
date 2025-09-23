using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Form
{
    public partial class simple_interst : Form
    {
        public simple_interst()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            // take values from textboxes
            double p = Convert.ToDouble(txtPrincipal.Text);
            double r = Convert.ToDouble(txtRate.Text);
            double t = Convert.ToDouble(txtTime.Text);

            // simple interest formula
            double si = (p * r * t) / 100;

            // show result
            lblResult.Text = "Simple Interest = " + si;

        }
    }
}
