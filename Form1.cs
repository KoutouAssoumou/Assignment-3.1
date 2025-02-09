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
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str, out result))
            {
                MessageBox.Show("this is a valid integer");

}
            else
            {
                MessageBox.Show("Not a valid integer");
            }
            try
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("Catch not a valid int");
            }
        }
    }
}
