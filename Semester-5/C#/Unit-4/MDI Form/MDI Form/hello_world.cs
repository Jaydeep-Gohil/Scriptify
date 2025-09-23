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
    public partial class hello_world : Form
    {
        public hello_world()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            l1.Text = "Hello World";
        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            l1.Text = tb1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            l1.Text = "";
        }
    }
}
