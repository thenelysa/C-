namespace project777
{
    public partial class username : Form
    {
        public username()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;

            /*if(data == "test")
            //{
              //  MessageBox.Show("Success");
            //}
            //else
            //{
              MessageBox.Show("Failed");*/
            for(int i=0; i<=3;i++)
                {
                    MessageBox.Show("Display"+ i);
                }
        }
    }
}