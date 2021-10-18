using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = null;
            Cachorro c = new Cachorro();
            //a = c;
            Console.WriteLine(c.mostra());
            //Console.WriteLine(a.mostra());
            Console.ReadKey();
        }
    }
}
