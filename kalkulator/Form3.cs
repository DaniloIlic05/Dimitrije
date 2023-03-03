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
            string[] rezultat1 = textBox1.Text.Split(' ');
            if (rezultat1[1] is null)
            {
                x.Re = Convert.ToDouble(rezultat1[0]);
                x.Im = 0;
            }
            else if ((rezultat1[1] != "+") || (rezultat1[1] != "-"))
            {
                x.Im = Convert.ToDouble(rezultat1[0]);
                x.Re = 0;
            }
            if (rezultat1[1] == "+")
            {
                x.Im = Convert.ToDouble(rezultat1[2]);
            }
            else
            {
                x.Im = - Convert.ToDouble(rezultat1[2]);
            }
            string[] rezultat2 = textBox2.Text.Split(' ');
            if (rezultat2[1] is null)
            {
                y.Re = Convert.ToDouble(rezultat2[0]);
                y.Im = 0;
            }
            else if ((rezultat2[1] != "+") || (rezultat2[1] != "-"))
            {
                y.Im = Convert.ToDouble(rezultat2[0]);
                y.Re = 0;
            }
            if (rezultat2[1] == "+")
            {
                y.Im = Convert.ToDouble(rezultat2[2]);
            }
            else
            {
                y.Im = -Convert.ToDouble(rezultat2[2]);
            }
            kompleksni z = kompleksni.zbir(x, y);
            if (z.Im > 0)
            {
                textBox3.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else
            {
                textBox3.Text = Convert.ToString(z.Re) + " -" + Convert.ToString(z.Im) + " i";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            string[] rezultat1 = textBox1.Text.Split(' ');
            x.Re = Convert.ToDouble(rezultat1[0]);
            if (rezultat1[1] == "+")
            {
                x.Im = Convert.ToDouble(rezultat1[2]);
            }
            else
            {
                x.Im = -Convert.ToDouble(rezultat1[2]);
            }
            string[] rezultat2 = textBox2.Text.Split(' ');
            y.Re = Convert.ToDouble(rezultat2[0]);
            if (rezultat2[1] == "+")
            {
                y.Im = Convert.ToDouble(rezultat2[2]);
            }
            else
            {
                y.Im = -Convert.ToDouble(rezultat2[2]);
            }
            kompleksni z = kompleksni.razlika(x, y);
            if (z.Im > 0)
            {
                textBox3.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else
            {
                textBox3.Text = Convert.ToString(z.Re) + " -" + Convert.ToString(z.Im) + " i";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            string[] rezultat1 = textBox1.Text.Split(' ');
            x.Re = Convert.ToDouble(rezultat1[0]);
            if (rezultat1[1] == "+")
            {
                x.Im = Convert.ToDouble(rezultat1[2]);
            }
            else
            {
                x.Im = -Convert.ToDouble(rezultat1[2]);
            }
            string[] rezultat2 = textBox2.Text.Split(' ');
            y.Re = Convert.ToDouble(rezultat2[0]);
            if (rezultat2[1] == "+")
            {
                y.Im = Convert.ToDouble(rezultat2[2]);
            }
            else
            {
                y.Im = -Convert.ToDouble(rezultat2[2]);
            }
            kompleksni z = kompleksni.prozivod(x, y);
            if (z.Im > 0)
            {
                textBox3.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else
            {
                textBox3.Text = Convert.ToString(z.Re) + " -" + Convert.ToString(z.Im) + " i";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            string[] rezultat1 = textBox1.Text.Split(' ');
            x.Re = Convert.ToDouble(rezultat1[0]);
            if (rezultat1[1] == "+")
            {
                x.Im = Convert.ToDouble(rezultat1[2]);
            }
            else
            {
                x.Im = -Convert.ToDouble(rezultat1[2]);
            }
            string[] rezultat2 = textBox2.Text.Split(' ');
            y.Re = Convert.ToDouble(rezultat2[0]);
            if (rezultat2[1] == "+")
            {
                y.Im = Convert.ToDouble(rezultat2[2]);
            }
            else
            {
                y.Im = -Convert.ToDouble(rezultat2[2]);
            }
            kompleksni z = kompleksni.kolicnik(x, y);
            if (z.Im > 0)
            {
                textBox3.Text = Convert.ToString(z.Re) + " +" + Convert.ToString(z.Im) + " i";
            }
            else
            {
                textBox3.Text = Convert.ToString(z.Re) + " -" + Convert.ToString(z.Im) + " i";
            }
        }
    }
}
