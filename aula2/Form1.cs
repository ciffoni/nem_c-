using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class Form1 : Form
    {
        int resultado, v1, v2;//declaração das variaveis

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //tratamento de erro na caixa de texto
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                //alerta de campo vazio
                MessageBox.Show("Campo valor 1 vazio");
                txtValor.Focus();//recebe o focus do cursor
                return;//retorna a mensagem para o campo especifico
            }
            //conversão do conteúdo do textbox para inteiro
            v1 = Convert.ToInt32(txtValor.Text);
            v2 = Convert.ToInt32(txtValor2.Text);
            resultado = v1 - v2;
            label3.Text = "A subtração é " + resultado.ToString();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conversão do conteúdo do textbox para inteiro
            v1=Convert.ToInt32(txtValor.Text);
            v2=Convert.ToInt32(txtValor2.Text);
            resultado = v1 + v2;
            label3.Text="A soma é "+ resultado.ToString();


        }
    }
}
