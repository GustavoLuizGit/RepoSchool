using System;

namespace Projeto1
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Qual será a quantidade de funcionarios: ");
            int x = int.Parse(Console.ReadLine());
            Funcionario[] vetor = new Funcionario[x];

            for (int i = 0; i < x; i++)
            {
                vetor[i] = new Funcionario();
                Console.Write("Qual o nome  : ");
                vetor[i].Nome = Console.ReadLine();
                Console.Write("Qual o salario :");
                vetor[i].Salario = double.Parse(Console.ReadLine());
            }
            foreach (var item in vetor)
            {
                Console.WriteLine(item.Mostra() + "\n");
            }

            Console.ReadKey();
        }
    }
}
