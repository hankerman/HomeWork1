using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork1
{
    public partial class Form1 : Form
    {
        int width, height;
        public Form1()
        {
            InitializeComponent();
            width = Width;
            height = Height;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _BackColor(button1);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //button1.Width += Width - width;
            //button1.Height += Height - height;

            ////button2.Location = new Point((button2.Location.X), button1.Location.Y + button1.Height);
            //button2.Width += Width - width;
            //button2.Height += Height - height;


            tableLayoutPanel1.Width += Width - width;
            tableLayoutPanel1.Height += Height - height;


            width = Width;
            height = Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _BackColor(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _BackColor(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _BackColor(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _BackColor(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _BackColor(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _BackColor(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _BackColor(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _BackColor(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _BackColor(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _BackColor(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _BackColor(button12);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _BackColor(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _BackColor(button16);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _BackColor(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _BackColor(button14);
        }

        private void _BackColor(Button button)
        {
            BackColor = button.ForeColor;
        }
    }
}
