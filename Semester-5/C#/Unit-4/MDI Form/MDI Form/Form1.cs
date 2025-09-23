namespace MDI_Form
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleHelloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hello_world hw = new hello_world();
            hw.MdiParent = this;
            hw.Show();
        }

        private void simpleInterstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simple_interst sp = new simple_interst();
            sp.MdiParent = this;
            sp.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator cl = new calculator();
            cl.MdiParent = this;
            cl.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factorial f1 = new factorial();
            f1.MdiParent = this;
            f1.Show();
        }

        private void unit5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listboxcs lb = new listboxcs();
            lb.MdiParent = this;
            lb.Show();
        }
    }
}
