using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                int y;
                Console.WriteLine("Digite o valor de x :");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de y :");
                y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Resultado : " + z);
                Console.ReadKey();
            }
            catch(DivideByZeroException aux)
            {
                Console.WriteLine("Erro de Divisão por 0");
                Console.WriteLine(aux.Message);
            }
        }
    }
}
