using System;

namespace apresentação5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um numero de 1 a 7");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
            Console.WriteLine("segunda");
            break;

                case 2:
                    Console.WriteLine("terça");
                    break;

                case 3:
                    Console.WriteLine("quarta");
                    break;

                case 4:
                    Console.WriteLine("quinta");
                    break;

                case 5:
                    Console.WriteLine("sexta");
                    break;

                case 6:
                    Console.WriteLine("sabado");
                    break;

                case 7:
                    Console.WriteLine("domingo");
                    break;

                default:
                    Console.WriteLine("esse dia não é valido");
                    break;
            }
        }
    }
}
