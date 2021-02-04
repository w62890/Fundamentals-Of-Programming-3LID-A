using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("ENTER THE NUMBERS");
                return;
            }


            textBox3.Text = $"{Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("ENTER THE NUMBERS");
                return;
            }

            textBox3.Text = $"{Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("ENTER THE NUMBERS");
                return;
            }

            textBox3.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("ENTER THE NUMBERS");
                return;
            }

            textBox3.Text = $"{Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)}";
        }
    }
}
