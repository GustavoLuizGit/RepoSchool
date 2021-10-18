using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejto
{
    class Funcionario
    {
        private string nome;
        private double salario;
        public Funcionario()
        {
        
        }

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }

        virtual public string mostra()
        {
            return "";
        }

        virtual public double CalculoSalario()
        {
            return salario;
        }
    }
}
