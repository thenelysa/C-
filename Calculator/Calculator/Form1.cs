namespace Calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "7";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "7";
            }
        }

        private void username2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*")
            {
                textBox1.Text = "8";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "9";
        }

        private void username3_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string data = textBox1.Text;
            textBox1.Text = data + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string data = textBox1.Text;
            textBox1.Text = data + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            textBox1.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            string data = textBox1.Text;
            textBox1.Text = data + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            string data = textBox1.Text;
            textBox1.Text = data + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string data = textBox1.Text;
            textBox1.Text = data + "3";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            textBox1.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            textBox1.Text = "-";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            textBox1.Text = "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(textBox1.Text);
            switch (operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "-":
                    calculation = (firstNum - secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "%":
                    calculation = (firstNum % secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "9";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            calculator2 cal2 = new calculator2();
            cal2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = String.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data.Remove(data.Length - 1);
        }
        public void GetResultValue()
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "/" && textBox1.Text != "x" && textBox1.Text != "-" && textBox1.Text != "%" && textBox1.Text != ".")
            {
                calculation = Convert.ToDecimal(textBox1.Text);


            }
        }

       
    }
   
}
