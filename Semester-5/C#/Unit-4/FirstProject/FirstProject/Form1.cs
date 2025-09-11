using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            l1.Text = "Hello";

        }

        private void b2_Click(object sender, EventArgs e)
        {
            l1.Text = "";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            l1.Text ="Welcom ";
        }
    }
}
