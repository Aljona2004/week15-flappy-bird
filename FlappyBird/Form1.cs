using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    int gravity = 10;
    int pipespeed = 6;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeTop.Left += pipeSpeed;
            pipeBottom.Left += pipeSpeed;

            if(pipeTop.Left < -60)
            {
                pipeTop.Left = 500;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formal_Keydown(object sender, KeyEventArgs e)
        {

        }

        private void formal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void gravity(object sender, MouseEventArgs e)
        {

        }

        private void bird(object sender, EventArgs e)
        {

        }
    }
}
