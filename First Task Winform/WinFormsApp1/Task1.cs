
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Task1 : Form
    {
        int a = 0;
        public Task1()
        {
            InitializeComponent();
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += Tm_Tick;
            tm.Start();
        }

        private void Tm_Tick(object? sender, EventArgs e)
        {
            if (a == 0)
                textBox1.Text = DateTime.Now.ToLongTimeString();
            else if(a == 1)
                textBox1.Text = DateTime.UtcNow.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._5014;
            textBox1.Text = DateTime.Now.ToLongTimeString();
            a = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._5015;
            textBox1.Text = DateTime.UtcNow.ToLongTimeString();
            a = 1;
        }
    }
}