using System;

namespace apresentaçao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero para saber se é par ou impar");
            int numero = Convert.ToInt32(Console.ReadLine());

                string parimpar = (numero % 2 == 0) ? "par" : "impar";

                Console.WriteLine(parimpar);
            }
        }
    }

