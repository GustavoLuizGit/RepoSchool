using System;
using System.Collections.Generic;

namespace Exercicio_Trab
{
    class Program
    {
        static void Main()
        {
            List<Estoque> listFun = new List<Estoque>();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar Produto : ");
                Console.WriteLine("2. Mostrar Produto : ");
                Console.WriteLine("3. Consultar um Produto : ");
                Console.WriteLine("4. Sair");
                Console.Write("Digte sua opção : ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Estoque x = new Estoque("Estoque do Geraldinho");
                        Console.Write("Qual o nome do produto  : ");
                        x.Nome_prod = Console.ReadLine();
                        Console.Write("Qual a quantidade :");
                        x.Quantidade = int.Parse(Console.ReadLine());
                        listFun.Add(x);
                        break;

                    case 2:
                        foreach (var item in listFun)
                        {
                            Console.WriteLine(item.Mostra() + "\n");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Nome do produto : ");
                        string NomeAux = Console.ReadLine();
                        foreach (var item in listFun)
                        {
                            if (item.Nome_prod == NomeAux)
                            {
                                Console.WriteLine(item.Mostra() + "\n");
                            }
                        }
                        Console.ReadKey();
                        break;
                }
            } while (op != 4);
        }
    }
}
