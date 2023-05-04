namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            if(tal1 < tal2)
            {
                string hej = tal1.ToString();
                textBox3.Text = hej;
            }
            else
            {
                string hej1 = tal2.ToString();
                textBox3.Text = hej1;
            }
        }
    }
}