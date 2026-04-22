using System;

namespace apresentaçao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Menor de Idade");
            }
            else if (idade >= 18 && idade<= 59)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("idoso");
            }

        }
    }
}
