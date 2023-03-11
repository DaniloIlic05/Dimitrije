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
    public partial class FormKompleksniBrojevi : Form
    {
        public FormKompleksniBrojevi()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "")
            {
                x.Re = 0;
            }
            else
            {
                x.Re = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "")
            {
                x.Im = 0;
            }
            else
            {
                x.Im = Convert.ToDouble(textBox2.Text);
            }
            if (textBox3.Text == "")
            {
                y.Re = 0;
            }
            else
            {
                y.Re = Convert.ToDouble(textBox3.Text);
            }
            if (textBox4.Text == "")
            {
                y.Im = 0;
            }
            else
            {
                y.Im = Convert.ToDouble(textBox4.Text);
            }
            kompleksni z = kompleksni.zbir(x, y);
            if (z.Im > 0)
            {
                textBox5.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else if (z.Im == 0)
            {
                textBox5.Text = Convert.ToString(z.Re);
            }
            else if (z.Re == 0)
            {
                textBox5.Text = Convert.ToString(z.Im);
            }
            else
            {
                textBox5.Text = Convert.ToString(z.Re) + Convert.ToString(z.Im) + " i";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "")
            {
                x.Re = 0;
            }
            else
            {
                x.Re = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "")
            {
                x.Im = 0;
            }
            else
            {
                x.Im = Convert.ToDouble(textBox2.Text);
            }
            if (textBox3.Text == "")
            {
                y.Re = 0;
            }
            else
            {
                y.Re = Convert.ToDouble(textBox3.Text);
            }
            if (textBox4.Text == "")
            {
                y.Im = 0;
            }
            else
            {
                y.Im = Convert.ToDouble(textBox4.Text);
            }
            kompleksni z = kompleksni.razlika(x, y);
            if (z.Im > 0)
            {
                textBox5.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else if (z.Im == 0)
            {
                textBox5.Text = Convert.ToString(z.Re);
            }
            else if (z.Re == 0)
            {
                textBox5.Text = Convert.ToString(z.Im);
            }
            else
            {
                textBox5.Text = Convert.ToString(z.Re) + Convert.ToString(z.Im) + " i";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "")
            {
                x.Re = 0;
            }
            else
            {
                x.Re = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "")
            {
                x.Im = 0;
            }
            else
            {
                x.Im = Convert.ToDouble(textBox2.Text);
            }
            if (textBox3.Text == "")
            {
                y.Re = 0;
            }
            else
            {
                y.Re = Convert.ToDouble(textBox3.Text);
            }
            if (textBox4.Text == "")
            {
                y.Im = 0;
            }
            else
            {
                y.Im = Convert.ToDouble(textBox4.Text);
            }
            kompleksni z = kompleksni.proizvod(x, y);
            if (z.Im > 0)
            {
                textBox5.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else if (z.Im == 0)
            {
                textBox5.Text = Convert.ToString(z.Re);
            }
            else if (z.Re == 0)
            {
                textBox5.Text = Convert.ToString(z.Im);
            }
            else
            {
                textBox5.Text = Convert.ToString(z.Re) + Convert.ToString(z.Im) + " i";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "")
            {
                x.Re = 0;
            }
            else
            {
                x.Re = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "")
            {
                x.Im = 0;
            }
            else
            {
                x.Im = Convert.ToDouble(textBox2.Text);
            }
            if (textBox3.Text == "")
            {
                y.Re = 0;
            }
            else
            {
                y.Re = Convert.ToDouble(textBox3.Text);
            }
            if (textBox4.Text == "")
            {
                y.Im = 0;
            }
            else
            {
                y.Im = Convert.ToDouble(textBox4.Text);
            }
            kompleksni z = kompleksni.kolicnik(x, y);
            if (z.Im > 0)
            {
                textBox5.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else if (z.Im == 0)
            {
                textBox5.Text = Convert.ToString(z.Re);
            }
            else if (z.Re == 0)
            {
                textBox5.Text = Convert.ToString(z.Im);
            }
            else
            {
                textBox5.Text = Convert.ToString(z.Re) + Convert.ToString(z.Im) + " i";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
