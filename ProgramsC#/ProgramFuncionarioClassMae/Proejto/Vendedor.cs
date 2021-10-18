using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejto
{
    class Vendedor:Funcionario
    {
        private double vendas;

        public Vendedor()
        {

        }

        public double Vendas { get => vendas; set => vendas = value; }

        override public string mostra()
        {
            return base.mostra() + Nome + " - Vendedor ";
        }

        override public double CalculoSalario()
        {
            return base.CalculoSalario() + (0.4 * vendas);
        }
        
    }
}
