using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            button1.Location = new Point(rand.Next(0,this.Size.Width - 100), rand.Next(0, this.Size.Height - 100));
            
        }

    }
}
