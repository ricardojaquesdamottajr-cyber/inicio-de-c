using System;

namespace incrementoedecremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine(++i);

            //pos decremento

            Console.WriteLine(i++);
            Console.WriteLine(i);

            // decremento

            i--;
            Console.WriteLine(i);
        }
    }
}
