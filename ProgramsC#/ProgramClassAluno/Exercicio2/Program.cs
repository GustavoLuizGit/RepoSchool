using System;

namespace Exercicio2
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
        public void GravaAluno(string matricula, string nome, double[] vetor)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.vetor = vetor;
        }
        public string MostraAluno()
        {
            string aux;
            aux = ("Nome : " + nome + "\n Matricula : " + matricula + "\nNotas : ");
            foreach (var item in vetor)
            {
                aux += "\n" + item;
            }
            return aux;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string matricula, nome;
            double[] vetor = new double[4];
            Aluno aux = new Aluno();
            Aluno a = new Aluno();
            Console.Write("Digite o nome do aluno : ");
            nome = Console.ReadLine();
            Console.Write("Digite a matricula do aluno : ");
            matricula = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Qual a " + (i + 1) + " a nota do aluno : ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            a.GravaAluno( matricula, nome, vetor);
            Console.WriteLine(a.MostraAluno());
            Console.ReadKey();
        }
    }
}
