using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carousel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible =false;
            timer1.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            timer1.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            timer1.Start();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            timer1.Start();
        }

        private void Btnprevious_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void Btnnext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void Btnnext_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btnprevious_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
