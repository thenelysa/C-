using System.Data;
using System.Data.SqlClient;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;

        SqlConnection con = new SqlConnection(@"Data Source= .\SQLEXPRESS;Initial Catalog=database7;user id=sa;password=kist@123;");
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Insert into student values ('Nelysa','Samakhusi','9860777527','KIST')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con.Close();
}
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Insert into student values ('Nelysa','Samakhusi','9860777527','KIST')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con.Close();
}
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Student set name='Nelysa', address='Kathmandu' ,contact ='9860777527',college='KIST'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

    
                MessageBox.Show("Saved Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
        //------------------For extractibg data directly from dataBASE(SOURCE DATA)-----------//
        private void Display_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.InnerException);
            }
            dataGridView1.Rows.Add("1", "Nelysa", "ktm","KIST");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string data = sn.Text;
            string data1 = name.Text;
            string data2 = address.Text;
            string data3= college.Text;
            dataGridView1.Rows.Add(data, data1, data2, data3);
        }


        private void save_Click(object sender, EventArgs e)
        {
            string data1 = textBox1.Text;
            con.Open();
            string query = "Insert into Student" +
            "(name, address, contact, college)" +
         "   values(@student_name,@address" + ",@contact,@college)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@student_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@contact", textBox3.Text);
            cmd.Parameters.AddWithValue("@college", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully");
        }
    }
   
}
