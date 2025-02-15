namespace Assignment_3._1_Basic_GUI_and_Exception_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1, result2;
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            if (int.TryParse(str1, out result1) && int.TryParse(str2, out result2))
            {
                int sum = result1 + result2;
                MessageBox.Show("This is a valid integer. Sum = " + sum);
            }
            else
            {
                MessageBox.Show("Not a valid integer in one of the text boxes.");
            }

            try
            {
                result1 = int.Parse(str1);
                result2 = int.Parse(str2);
                int sum = result1 + result2;
                MessageBox.Show("Sum using try-catch: " + sum);
            }
            catch
            {
                MessageBox.Show("Catch: Not a valid int in one of the text boxes.");
            }
        }
    }
}
