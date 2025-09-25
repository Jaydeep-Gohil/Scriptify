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
    public partial class listboxcs : Form
    {
        public listboxcs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Husand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (rdoWife.Checked)
            {
                lstWife.Items.Add(txtName.Text);
            }
            if (rdoHus.Checked)
            {
                cmbHusband.Items.Add(txtName.Text);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            lstWife.Items.Remove(txtName.Text);
        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            string wives = "";
            foreach (var item in lstWife.SelectedItems)
            {
                wives += item.ToString() + "  ";
            }

            // Show only the selected husband (ComboBox is single-select)
            string husbands = "";
            if (cmbHusband.SelectedItem != null)
            {
                husbands = "  |  " + cmbHusband.SelectedItem.ToString();
            }

            // Show result in label
            l2.Text = wives + husbands;
        }
    }
}
