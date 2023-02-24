using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int n = rimski.ConvertToInt(s);
            textBox2.Text = Convert.ToString(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = rimski.ConvertToInt(textBox3.Text);
            int m = rimski.ConvertToInt(textBox1.Text);
            textBox2.Text = Convert.ToString(n + m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = rimski.ConvertToInt(textBox3.Text);
            int m = rimski.ConvertToInt(textBox1.Text);
            textBox2.Text = Convert.ToString(n - m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = rimski.ConvertToInt(textBox3.Text);
            int m = rimski.ConvertToInt(textBox1.Text);
            textBox2.Text = Convert.ToString(n / m);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = rimski.ConvertToInt(textBox3.Text);
            int m = rimski.ConvertToInt(textBox1.Text);
            textBox2.Text = Convert.ToString(n * m);
        }
    }
}
