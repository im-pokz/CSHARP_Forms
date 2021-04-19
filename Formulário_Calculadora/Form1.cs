using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, soma;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            soma = n1 + n2;

            label4.Text = Convert.ToString(soma);
        }
    }
}
