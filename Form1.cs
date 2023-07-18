using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula07Funcoes
{
    public partial class Form1 : Form
    {


        //variáveis globais
       
        public Form1()
        {
            InitializeComponent();
        }

        //Minhas funções
        void mostraMensagem()
        {
            MessageBox.Show("Olá, seja bem-vindo");
            MessageBox.Show("Faça login para continuar...");


        }

        void Funcao()
        {

            string funcao = textBox1.Text;
            MessageBox.Show("Olá," +funcao);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostraMensagem();
            Funcao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostraMensagem();


        }
    }
}
