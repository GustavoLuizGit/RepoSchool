using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class ProjetoHardware:Projeto
    {
        private double placa;
        private double componentes;

        
        public double Componentes {  set => componentes = value; }
        public double Placa {  set => placa = value; }

        override public double Calculo_Custo()
        {
            return base.Calculo_Custo() + placa + componentes;
        }
    }
}
