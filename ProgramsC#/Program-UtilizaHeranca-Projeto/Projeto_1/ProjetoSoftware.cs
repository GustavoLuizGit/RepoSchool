using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class ProjetoSoftware:Projeto
    {
        private double consultoria;

        public double Consultoria { get => consultoria; set => consultoria = value; }

        public ProjetoSoftware(string nomeprojeto) : base(nomeprojeto)
        {

        }
        override public double Calculo_Custo()
        {
            return base.Calculo_Custo() + consultoria;
        }
    }
}
