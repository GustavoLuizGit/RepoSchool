using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejto
{
    class Gestor:Funcionario
    {
        private string cargo;
        public Gestor()
        {

        }

        public string Cargo { get => cargo; set => cargo = value; }

        override public string mostra()
        {
            return base.mostra()+ Nome + " - Cargo : " + cargo;
        }

        override public double CalculoSalario()
        {
            return base.CalculoSalario() + 2000;
        }
    }
}
