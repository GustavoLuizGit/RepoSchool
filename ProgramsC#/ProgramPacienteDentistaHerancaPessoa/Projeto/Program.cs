using System;
using System.Collections.Generic;
//Grupo 4

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Dentista x = null;
            Paciente pa = null;
            List<Dentista> D = new List<Dentista>();
            List<Paciente> P = new List<Paciente>();

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================================================================");
                Console.WriteLine("1– Criar Dentista e adicionar na Lista_Dentista");
                Console.WriteLine("2 – Mostrar todos os objetos da Lista_Dentista");
                Console.WriteLine("3 – Consultar um determinado objeto da Lista_Dentista por um de seus atributos");
                Console.WriteLine("4 – Criar Paciente e adicionar na Lista_Paciente");
                Console.WriteLine("5 – Mostrar todos os objetos da Lista_Paciente");
                Console.WriteLine("6 – Consultar um determinado objeto da Lista2 por um de seus atributos.");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("========================================================================================");
                Console.Write("Digite sua opção : ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            
                            Console.Clear();
                            string nome, procedimento;
                            Console.Write("Qual o nome do dentista : ");
                            nome = Console.ReadLine();
                            Console.Write("Qual o procedimento do dentista : ");
                            procedimento = Console.ReadLine();
                            x = new Dentista(nome, procedimento);
                            cadastropessoal(x);
                            Console.Write("Qual a especialização : ");
                            x.Especializacao = Console.ReadLine();
                            Console.Write("Numero de telefone :");
                            x.Numero = Console.ReadLine();
                            D.Add(x);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            foreach (var item in D)
                            {
                                Console.WriteLine(item.MostraDentita());
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o cpf do dentista procurado : ");
                            string aux_cpf = Console.ReadLine();
                            foreach (var item in D)
                            {
                                if (aux_cpf == item.Cpf)
                                {
                                    Console.WriteLine(item.MostraDentita());
                                    Console.WriteLine();
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            string nome, fn;
                            Console.Write("Qual o nome do paciente : ");
                            nome = Console.ReadLine();
                            Console.Write("Qual o número da ficha do paciente : ");
                            fn = Console.ReadLine();
                            pa= new Paciente(nome, fn);
                            cadastropessoal(pa);
                            Console.Write("Qual a fomra de pagamento : ");
                            pa.Forma_pagamento = Console.ReadLine();
                            Console.Write("Numero de telefone :");
                            pa.Numero = Console.ReadLine();
                            P.Add(pa);

                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            foreach (var item in P)
                            {
                                Console.WriteLine(item.MostraPaciente());
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o cpf do dentista procurado : ");
                            string aux_cpf = Console.ReadLine();
                            foreach (var item in P)
                            {
                                if (aux_cpf == item.Cpf)
                                {
                                    Console.WriteLine(item.MostraPaciente());
                                    Console.WriteLine();
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("OPÇÃO INVALIDA");
                            Console.ReadKey();
                        }
                        break;

                }
            } while (op!=7);


            static void cadastropessoal(Pessoa obj)
            {
                Console.Write("Idade :");
                obj.Idade = int.Parse(Console.ReadLine());
                Console.Write("Cpf : ");
                obj.Cpf = Console.ReadLine();
            }
        }
    }
}
