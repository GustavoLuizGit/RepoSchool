using System;

namespace Exercicio1
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] vetor;
        public Aluno()
        {
            vetor = new double[4];
        }
        public void GravaAluno()
        {
            Console.Write("Qual o nome do aluno : ");
            nome = Console.ReadLine();
            Console.Write("Qual  matricula do aluno : ");
            matricula = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Entre com a " + (i + 1) + "° nota do aluno : ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
        }
        public void MostraAluno()
        {
            Console.WriteLine("Nome do aluno : " + nome);
            Console.WriteLine("Matricula do aluno : " + matricula);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + "° nota = " + vetor[i].ToString("R$0.00"));
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            x.GravaAluno();
            Console.Clear();
            x.MostraAluno();
        }
    }
}
