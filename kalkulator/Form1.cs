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
    public partial class FormRimski : Form
    {
        public FormRimski()
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
            if ((rimski.ProveriRimski(textBox3.Text) == true) && (rimski.ProveriRimski(textBox1.Text)))
            {
                int n = rimski.ConvertToInt(textBox3.Text);
                int m = rimski.ConvertToInt(textBox1.Text);
                int s = m + n;
                if (s <= 3999)
                {
                    textBox2.Text = rimski.ConvertToString(n + m);
                }
                else
                {
                    MessageBox.Show("Rezultat je veci od 4000.");
                }
            }
            else
            {
                MessageBox.Show("Greska! Jedan od brojeva nije validan.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((rimski.ProveriRimski(textBox3.Text) == true) && (rimski.ProveriRimski(textBox1.Text)))
            {
                int n = rimski.ConvertToInt(textBox3.Text);
                int m = rimski.ConvertToInt(textBox1.Text);
                int s = n - m;
                if (s <= 3999)
                {
                    textBox2.Text = rimski.ConvertToString(n - m);
                }
                else
                {
                    MessageBox.Show("Rezultat je veci od 4000.");
                }
            }
            else
            {
                MessageBox.Show("Greska! Jedan od brojeva nije validan.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((rimski.ProveriRimski(textBox3.Text) == true) && (rimski.ProveriRimski(textBox1.Text)))
            {
                int n = rimski.ConvertToInt(textBox3.Text);
                int m = rimski.ConvertToInt(textBox1.Text);
                int s = n / m;
                if (s <= 3999)
                {
                    textBox2.Text = rimski.ConvertToString(n / m);
                }
                else
                {
                    MessageBox.Show("Rezultat je veci od 4000.");
                }
            }
            else
            {
                MessageBox.Show("Greska! Jedan od brojeva nije validan.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((rimski.ProveriRimski(textBox3.Text) == true) && (rimski.ProveriRimski(textBox1.Text)))
            {
                int n = rimski.ConvertToInt(textBox3.Text);
                int m = rimski.ConvertToInt(textBox1.Text);
                int s = m + n;
                if (s <= 3999)
                {
                    textBox2.Text = rimski.ConvertToString(n * m);
                }
                else
                {
                    MessageBox.Show("Rezultat je veci od 4000.");
                }
            }
            else
            {
                MessageBox.Show("Greska! Jedan od brojeva nije validan.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
