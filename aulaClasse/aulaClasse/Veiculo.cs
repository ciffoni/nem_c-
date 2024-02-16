using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace aulaClasse
{
    internal class Veiculo
    {
        //variavel
        public string chassi;
        private string modelo;
        protected string Placa;
            //construtor da classe
    public Veiculo()
        {
            modelo = "";
           
        }
        //metodo publico  retorno do texto placa
       public string getPlaca()
        {
           // Placa = "Axd4232";
            return Placa;
        }
        //metodo para alterar o conteudo da placa
        public void setPlaca(string Placa)
        {
            this.Placa = Placa;
        }
    }
}
