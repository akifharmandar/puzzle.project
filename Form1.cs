using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int sn, dk;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;

            timer1.Enabled = false;
            timer1.Interval = 1000;
            sn = 00;
            dk = 00;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;

            sn++;
            label2.Text = sn.ToString();
            if (sn == 60)
            {
                dk = dk + 1;
                label3.Text = dk.ToString();
                sn = 00;
                label2.Text = sn.ToString();
            }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox1.Image = pictureBox25.Image;
            }


            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Image = pictureBox25.Image;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pictureBox25.Image)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }


            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }

            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox25.Image;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }


            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }

            if (pictureBox4.Image == pictureBox25.Image)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox25.Image;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox4.Image;
                pictureBox4.Image = pictureBox25.Image;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pictureBox25.Image)
            {
                pictureBox1.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }


            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }

            if (pictureBox9.Image == pictureBox25.Image)
            {
                pictureBox9.Image = pictureBox5.Image;
                pictureBox5.Image = pictureBox25.Image;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox2.Image == pictureBox25.Image)
            {
                pictureBox2.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }

            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox6.Image;
                pictureBox6.Image = pictureBox25.Image;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }

            if (pictureBox3.Image == pictureBox25.Image)
            {
                pictureBox3.Image = pictureBox7.Image;
                pictureBox7.Image = pictureBox25.Image;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }

            if (pictureBox4.Image == pictureBox25.Image)
            {
                pictureBox4.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }


            if (pictureBox12.Image == pictureBox25.Image)
            {
                pictureBox12.Image = pictureBox8.Image;
                pictureBox8.Image = pictureBox25.Image;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == pictureBox25.Image)
            {
                pictureBox5.Image = pictureBox9.Image;
                pictureBox9.Image = pictureBox25.Image;
            }

            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = pictureBox25.Image;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == pictureBox25.Image)
            {
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }

            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }

            if (pictureBox6.Image == pictureBox25.Image)
            {
                pictureBox6.Image = pictureBox10.Image;
                pictureBox10.Image = pictureBox25.Image;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == pictureBox25.Image)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }

            if (pictureBox12.Image == pictureBox25.Image)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }

            if (pictureBox7.Image == pictureBox25.Image)
            {
                pictureBox7.Image = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image == pictureBox25.Image)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox12.Image = pictureBox25.Image;
            }

            if (pictureBox8.Image == pictureBox25.Image)
            {
                pictureBox8.Image = pictureBox12.Image;
                pictureBox12.Image = pictureBox25.Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
        }


    }
}
