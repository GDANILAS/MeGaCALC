using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private void Trim()
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.TrimStart('0');
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
            Trim();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
            Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if(textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
        }
    }
}
