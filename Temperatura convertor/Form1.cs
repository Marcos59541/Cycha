using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura_convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ctext.Text = string.Empty;
            Ftext.Text = string.Empty;
        }

        private void bFC_Click(object sender, EventArgs e)
        {
            float celcius = float.Parse(Ftext.Text);
            float farenheit = ((celcius * 9 / 5) + 32);
            Ctext.Text = farenheit.ToString();          

        }

        private void bCF_Click(object sender, EventArgs e)
        {
            float farenheit = (float.Parse(Ctext.Text));
            float celcius = ((farenheit - 32) * 5 / 9);
            Ftext.Text = celcius.ToString();
        }

        private void Fbutton_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ctext_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
