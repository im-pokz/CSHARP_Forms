using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario;
            DateTime dataNascimento;
            bool generoM;
            bool generoF;
            string aula;
            int matriculaUsuario;


            nomeUsuario = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            generoM = radioButton1.Checked;
            generoF = radioButton2.Checked;
            aula = comboBox1.Text;
            matriculaUsuario = Convert.ToInt32(textBox2.Text);


            MessageBox.Show("Usuário cadastrado com sucesso!\n" + 
                            "Nome: " + nomeUsuario + "\n" +
                            "Data de nascimento: " + dataNascimento + "\n" +
                            "Sexo masculino: " + generoM + "\n" + 
                            "Sexo feminino: " + generoF + "\n" +
                            "Aula frequentada: " + aula + "\n" +
                            "Matricula: " + matriculaUsuario + "\n");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
