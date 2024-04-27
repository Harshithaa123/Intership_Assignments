namespace UserForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("Username is :" + text);
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
