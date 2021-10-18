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
                Console.Write("Digite o valor de x :");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y :");
                y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Resultado : " + z);
                Console.ReadKey();
            }
            catch (DivideByZeroException aux)
            {
                Console.WriteLine("Erro de Divisão por 0");
                Console.WriteLine(aux.Message);
            }
            catch (FormatException aux)
            {
                Console.WriteLine("Voce digitou letra no lugar do numero");
                Console.Write(aux.Message);
            }
            catch
            {
                Console.WriteLine("Erro Inesperado");
            }
            finally
            {
                Console.WriteLine("Obrigado por utilizar nosso serviço");
            }
        }
    }
}
