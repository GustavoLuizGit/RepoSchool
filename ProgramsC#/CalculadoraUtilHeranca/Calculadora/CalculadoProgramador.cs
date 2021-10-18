using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class CalculadoProgramador:CalculadoraPadrao
    {
        public CalculadoProgramador(double regx, double regy) : base (regx, regy)
        {

        }
        public string binario()
        {
            int y = Convert.ToInt32(soma());
            return Convert.ToString(y, 2);
        }
    }
}
