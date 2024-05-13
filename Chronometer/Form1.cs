using System;
using System.Windows.Forms;

namespace Chronometer
{
    public partial class Form1 : Form
    {
        int sec = 0;
        bool run = false;

        public Form1()
        {
            InitializeComponent();
        }

        public bool running()
        {
            if (!run)
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
                run = true;
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = false;
                run = false;
            }
            return run;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label1.Text = sec.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            running();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sec = 0;
            label1.Text = sec.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
