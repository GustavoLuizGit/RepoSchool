﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class CalculadoraCientifica:CalculadoraPadrao
    {
        public CalculadoraCientifica(double regx, double regy):base(regx,regy)
        {

        }
        public double cubo()
        {
            return regx * regx * regx;
        }

    }
}
