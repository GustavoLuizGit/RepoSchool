using System;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            CalculadoraPadrao c = new CalculadoraPadrao(1, 4);
            Console.WriteLine(c.soma());
            CalculadoraCientifica cc = new CalculadoraCientifica(2, 5);
            Console.WriteLine(cc.cubo());
            CalculadoProgramador cp = new CalculadoProgramador(2, 3);
            Console.WriteLine(cp.binario());
            Console.ReadKey();
        }
    }
}
