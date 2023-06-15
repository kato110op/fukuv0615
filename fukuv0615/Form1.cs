namespace fukuv0615
{
    public partial class Form1 : Form
    {
        int ans = rand.Next(101);
        int count = 0;
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int guess;
            int guess = int.Parse(textBox1.Text);
            count = (count) + 1;
            MessageBox.Show($"{count}âΩâÒñ⁄ÇÃíßêÌ");
            if (ans == guess)
            {
                MessageBox.Show("Bingo");
                count = 0;
                ans = rand.Next(0, 101);
            }
            else if (ans < guess)
            {
                MessageBox.Show("Less");
            }
            if (ans > guess)
            {
                MessageBox.Show("Greater");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}