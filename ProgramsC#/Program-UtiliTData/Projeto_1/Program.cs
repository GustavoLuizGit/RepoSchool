using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente C1 = new Cliente();
            TEndereco E1 = new TEndereco();
            TData D1 = new TData();
            Console.Write("Nome do cliente: ");
            C1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a data de nascimento");
            Console.Write("Dia: ");
            C1.Data.Dia= int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            C1.Data.Mes= int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            C1.Data.Ano= int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu endereço");
            Console.Write("Rua: ");
            E1.Rua = Console.ReadLine();
            Console.Write("Numero da Casa: ");
            E1.Numero = int.Parse(Console.ReadLine());
            Console.Write("Cidade: ");
            E1.Cidade = Console.ReadLine();
            Console.Write("Bairro: ");
            E1.Bairro = Console.ReadLine();
            Console.Write("CPF: ");
            string auxcpf = Console.ReadLine();
            if (C1.Objeto_cpf.ValidaCpf(auxcpf) == false)
                Console.WriteLine("CPF_INVÁLIDO");
            else
            {
                Console.Clear();
                Console.WriteLine("\nMostrando Cliente");
                Console.WriteLine(C1.Nome);
                Console.WriteLine(C1.Objeto_cpf.MostraCPF());
                Console.WriteLine(E1.MostrarEnd());
                Console.WriteLine(C1.Data.dataF1());
                Console.WriteLine(C1.Data.dataF2());
                Console.ReadKey();
            }
        }
    }
}
