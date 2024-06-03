namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sivas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coach");
            listBox1.Items.Add("Author");
            listBox1.Items.Add("Chef");
            listBox1.Items.Add("Artist");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text + " " + textBox5.Text + " " + textBox4.Text + " " + textBox3.Text);
        }
    }
}
