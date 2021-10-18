using System;

namespace Exercicio2
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] vetor;

        public string Aux
        {
            get { return nome; }
            set { this.nome = value.ToUpper(); }
        }
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
            Aluno a = new Aluno();
            Console.Write("Digite o nome do aluno : ");
            a.Aux = Console.ReadLine();
            Console.WriteLine(a.Aux);
            Console.ReadKey();
        }
    }
}
