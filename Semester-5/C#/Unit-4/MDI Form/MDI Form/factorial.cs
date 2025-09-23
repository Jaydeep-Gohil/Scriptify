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
    public partial class factorial : Form
    {
        public factorial()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNumber.Text);
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            lblResult.Text = "Factorial = " + fact;
        }
    }
}
