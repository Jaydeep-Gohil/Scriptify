namespace calculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            l1.Text = "+";
            l3.Text = Convert.ToString(a + b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            l1.Text = "-";
            l3.Text = Convert.ToString(a - b);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            l1.Text = "*";
            l3.Text = Convert.ToString(a * b);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            l1.Text = "/";
            l3.Text = Convert.ToString(a / b);
        }
    }
}
