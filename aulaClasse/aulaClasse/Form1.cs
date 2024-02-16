using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciando a classe veiculo
            //criando um novo veiculo chamado ve
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //chamo a classe veiculo com o nome ve
            //new veiculo nova classe veiculo
            Veiculo ve = new Veiculo();
            ve.chassi = txtChassi.Text;//pega o conteudo do textbox
            MessageBox.Show("chassi = " + ve.chassi);
            //chamanda do metodo para alterar o conteudo da placa
            ve.setPlaca(txtPlaca.Text);
            //recebe o metodo de acesso a variavel placa
            MessageBox.Show("placa - " + ve.getPlaca());

        }
    }
}
