using System;
using System.Collections.Generic;

namespace Projeto2
{
    class Program
    {
        //static void Main()
        //{
        //    List<Funcionario> listFun = new List<Funcionario>();
        //    char ok = 's';
        //    Funcionario F;
        //    do
        //    {
        //        F = new Funcionario();
        //        listFun.Add(new Funcionario());
        //        Console.Write("Qual o nome  : ");
        //        F.Nome = Console.ReadLine();
        //        Console.Write("Qual o salario :");
        //        F.Salario = double.Parse(Console.ReadLine());
        //        listFun.Add(F);
        //        Console.Write("Continuar (s/n) : ");
        //        ok = char.Parse(Console.ReadLine());
        //    } while (ok == 's');
          
        //    foreach (var item in listFun)
        //    {
        //        Console.WriteLine(item.Mostra() + "\n");
        //    }

        //    Console.ReadKey();
        //}

        static void Main()
        {
            List<Funcionario> listFun = new List<Funcionario>();
            Funcionario F;
            int op; 
            do
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar Funcionario : ");
                Console.WriteLine("2. Mostrar Funcionarios : ");
                Console.WriteLine("3. Consultar um Funcionario : ");
                Console.WriteLine("4. Sair");
                Console.Write("Digte sua opção : ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        F = new Funcionario();
                        Console.Write("Qual o nome  : ");
                        F.Nome = Console.ReadLine();
                        Console.Write("Qual o salario :");
                        F.Salario = double.Parse(Console.ReadLine());
                        listFun.Add(F);
                        break;

                    case 2:
                        foreach (var item in listFun)
                        {
                            Console.WriteLine(item.Mostra() + "\n");
                        }
                        Console.ReadKey();
                        break;
                    
                    case 3:
                        Console.Write("Nome : ");
                        string NomeAux = Console.ReadLine();
                        foreach (var item in listFun)
                        {
                            if(item.Nome==NomeAux)
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
