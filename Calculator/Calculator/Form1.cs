namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data +"7";
        }

        private void username2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void username3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "=";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }
    }
}