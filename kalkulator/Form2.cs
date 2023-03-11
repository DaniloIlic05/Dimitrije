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
    public partial class Form2 : Form
    {
        FormRimski formRimski = new FormRimski();
        FormKompleksniBrojevi formKompleksni = new FormKompleksniBrojevi();
        FormDugacki formDugacki = new FormDugacki();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRimski.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formKompleksni.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formDugacki.ShowDialog();
        }
    }
}
