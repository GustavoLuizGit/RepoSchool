using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Soma
    {
        private int x;
        private int y;
        public Soma()
        {

        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public string divisao()
        {
            try
            {
                int z = X / Y;
                string aux = "Resultado : " + z;
                return aux;
            }
            catch (DivideByZeroException x)
            {
                return x.Message;
            }
        }
    }
}
