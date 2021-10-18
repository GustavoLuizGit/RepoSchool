using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa p = new Pessoa();
                Aluno a = null;
                a = (Aluno)p;
            }
            catch(System.InvalidCastException aux)
            {
                Console.WriteLine(aux.Message);
            }
            
        }
    }
}
