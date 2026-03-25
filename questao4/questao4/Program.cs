using System;

namespace questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantas maçãs voce comprou? ");
            int maças = Convert.ToInt32(Console.ReadLine());

            if (maças < 12)
            {
                double calculo = maças * 1.30;
                Console.WriteLine("voce comprou " + maças + " maças o valor delas sera de " + calculo + "R$");
            }
            else
            {
                double calculo = maças * 1.00;
                Console.WriteLine("voce comprou " + maças + " maças o valor delas sera de " + calculo + "R$");
            }
                 
        }
    }
}
