using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打磚塊
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int dx=30, dy=30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_ball.Left += dx;
            pictureBox_ball.Top += dy;

            if (pictureBox_ball.Top >= this.Height - pictureBox_ball.Height)
            {
                //pictureBox_ball.Left += 50;
                //pictureBox_ball.Top -= 50;
                dy *= -1;
            }
            else if (pictureBox_ball.Left >= this.Width - pictureBox_ball.Width)
            {
                //pictureBox_ball.Left -= 50;
                //pictureBox_ball.Top -= 50;
                dx *= -1;
            }
            else if (pictureBox_ball.Top <= 0)
            {
                //pictureBox_ball.Left -= 50;
                //pictureBox_ball.Top += 50;
                dy *= -1;
            }
            else if (pictureBox_ball.Left <= 0)
            {
                //pictureBox_ball.Left += 50;
                //pictureBox_ball.Top += 50;
                dx *= -1;
            }
            else
            {
                //pictureBox_ball.Left += 50;
                //pictureBox_ball.Top += 50;
            }
            
        }
    }
}
