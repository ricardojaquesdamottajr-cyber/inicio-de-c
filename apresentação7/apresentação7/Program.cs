using System;

namespace apresentação7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "naruto", "Goku", "luffy", "asta", "rimuru" };
          int  numero = 0;

            while (numero < 5)
            {
                Console.WriteLine("o nome é " + nomes[numero]);
                numero++;
            }
            Console.WriteLine("o primeiro nome da lista é "+ nomes[0]);
            Console.WriteLine("o ultimo nome da lista é"+ nomes[4]);
        }
    }
}
