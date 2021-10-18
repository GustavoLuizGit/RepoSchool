using System;
using System.Collections.Generic;

namespace Projeto_1
{
    class Program
    {
        static void Main()
        {
            List<Projeto> lista = new List<Projeto> ();
            ProjetoHardware H = null;
            ProjetoSoftware S = null;
            ProjetoRede R = null;
            int op = 0;
            
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("============================================");
                    Console.WriteLine("1.Cadastrar projeto de Software");
                    Console.WriteLine("2.Cadastrar projeto de Hardware");
                    Console.WriteLine("3.Cadastrar projeto de Rede");
                    Console.WriteLine("4.Consultar projeto por responsavel");
                    Console.WriteLine("5.Consultar projeto de maior custo ");
                    Console.WriteLine("6.Consultar quantidade de horas por responsavel");
                    Console.WriteLine("7.Sair");
                    Console.WriteLine("============================================");
                    Console.Write("Digite sua opção :");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Nome do projeto : ");
                            string nomeProjeto = Console.ReadLine();
                            S = new ProjetoSoftware(nomeProjeto);
                            Cadastra(S);
                            Console.Write("Custo de consultoria : ");
                            S.Consultoria = double.Parse(Console.ReadLine());
                            lista.Add(S);
                            break;

                        case 2:
                            Console.Clear();
                            H = new ProjetoHardware();
                            Cadastra(H);
                            Console.Write("Custo de componentes : ");
                            H.Componentes = double.Parse(Console.ReadLine());
                            Console.Write("Custo de placa : ");
                            H.Placa = double.Parse(Console.ReadLine());
                            lista.Add(H);
                            break;

                        case 3:
                            Console.Clear();
                            R = new ProjetoRede();
                            Cadastra(R);
                            CadastraH(R);
                            Console.Write("Custo de configuração : ");
                            R.Configuracao = double.Parse(Console.ReadLine());
                            lista.Add(R);
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Digite o nome do responsável : ");
                            string resp = Console.ReadLine();
                            int cs = 0;
                            int ch = 0;
                            int cr = 0;
                            foreach (Projeto item in lista)
                            {
                                if (item.Responsavel == resp)
                                {
                                    Console.WriteLine(item.Nome_projeto);
                                    if (item is ProjetoSoftware) cs++;
                                    if (item is ProjetoRede) cr++;
                                    else if (item is ProjetoHardware) ch++;
                                }
                            }
                            Console.WriteLine("Resumo : " + cs + "Projetos de software --- " + cr + " Projeto de Rede --- " + ch + " Projeto de Hardware");
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            double valorReferencia = lista[0].Calculo_Custo();
                            Projeto aux = null;
                            foreach (Projeto item in lista)
                            {
                                if (item.Calculo_Custo() > valorReferencia)
                                {
                                    valorReferencia = item.Calculo_Custo();
                                    aux = item;
                                }
                            }
                            Console.WriteLine("Projeto : " + aux.Nome_projeto + " Custo do Projeto : " + aux.Calculo_Custo().ToString("0.00"));
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.Clear();
                            Console.Write("Nome do responsvel : ");
                            string responsavel = Console.ReadLine();
                            int somahora = 0;
                            foreach (Projeto item in lista)
                            {
                                if (item.Responsavel == responsavel)
                                {
                                    Console.WriteLine(item.Nome_projeto);
                                    somahora += item.Hora;
                                }
                            }
                            Console.WriteLine("Horas Trabalhadas : " + somahora.ToString());
                            Console.ReadKey();
                            break;

                        default:
                            if (op != 7)
                            {
                                Console.Clear();
                                Console.WriteLine("Opção invalida...Digite novamente");
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                catch(FormatException auxex)
                {
                    Console.Clear();
                    Console.WriteLine("Erro de conversão");
                    Console.WriteLine("Comece novamente...");
                    Console.ReadKey();
                }

            } while (op!=7);

        }

        static void Cadastra(Projeto aux)
        {
            if(aux is ProjetoHardware)
            {
                Console.Write("Nome do projeto : ");
                aux.Nome_projeto = Console.ReadLine();
            }
            Console.Write("Nome do Responsavel : ");
            aux.Responsavel = Console.ReadLine();
            Console.Write("Valor por hora : ");
            aux.Valor_hora = double.Parse(Console.ReadLine());
            Console.Write("Quantidae de hora :");
            aux.Hora = int.Parse(Console.ReadLine());
        }

        static void CadastraH(ProjetoHardware aux)
        {
            Console.Write("Custo de componentes : ");
            aux.Componentes = double.Parse(Console.ReadLine());
            Console.Write("Custo de placa : ");
            aux.Placa = double.Parse(Console.ReadLine());
        }
    }
}
