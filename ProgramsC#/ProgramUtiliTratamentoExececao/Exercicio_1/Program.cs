using System;
using System.IO;


namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream entrada = null;
            StreamReader leitor = null;
            try
            {
                entrada = File.Open("entrada.txt", FileMode.Open);
                leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
                Console.ReadKey();
            }
            catch (System.IO.FileNotFoundException aux)
            {
                Console.Write(aux.Message);
            }
            finally
            {
                if (leitor!=null) leitor.Close();
                if (entrada!=null) entrada.Close();
                Console.ReadKey();
            }
        }
    }
}
