using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DirAlram
{
    public partial class Form1 : Form
    {
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
                label1.Text = timeLeft + "초 남았당";
            }
            else
            {
                Timer.Stop();
                label1.Text = "약 먹었니?";
                MessageBox.Show("약을 먹으렴");
                button1.Enabled = true;

                if(button1.Enabled == true)
                {
                    label1.Text = "밥 먹었니?";
                    Timer.Start();
                }

            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Timer.Start();
            Timer.Interval = 1800000;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
