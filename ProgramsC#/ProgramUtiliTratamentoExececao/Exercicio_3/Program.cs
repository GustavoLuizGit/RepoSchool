using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma x = new Soma();
            Console.Write("Entre com x : ");
            x.X = int.Parse(Console.ReadLine());
            Console.Write("Entre com y : ");
            x.Y = int.Parse(Console.ReadLine());
            Console.WriteLine(x.divisao());
        }
    }
}
