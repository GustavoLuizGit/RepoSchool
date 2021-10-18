using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto2
{
    class Funcionario
    {
        private string nome;
        private double salario;

        public string Nome { get => nome; set => nome = value.ToUpper(); }
        public double Salario { get => salario; set => salario = value; }

        public string Mostra()
        {
            string aux = " ";
            aux += "Nome do funcionario : " + Nome + "\n Salario : " + salario.ToString("R$0.00");
            return aux;
        }   
    }
}
