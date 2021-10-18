using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class ProjetoRede:ProjetoHardware
    {
        private double configuracao;

        public double Configuracao { set => configuracao = value; }

        override public double Calculo_Custo()
        {
            return base.Calculo_Custo() + configuracao;
        }
    }
}
