using System;

namespace Eercicio
{
    class Program
    {
        static void Main()
        {
            FormasGeometricas x = new FormasGeometricas("Triangulo");
            x.Largura = -2;
            x.Altura = -3;
            Console.WriteLine(x.Mostrar());
            Console.ReadKey();

            Console.WriteLine("\nUsando o metodo gravar ...");
            x.Gravar(4,3);
            Console.WriteLine(x.Mostrar());
            Console.ReadKey();
        }
    }
}
