using System;

namespace questao5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantas horas voce trabalhou neste mes");
            int trahoras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quanto voce ganha por hora?");
            int hsalario = Convert.ToInt32(Console.ReadLine());
            double salarioM = hsalario * 40 * 4;
            if (trahoras >= 160)
            {
                double aumento = salarioM * 0.50;
                double total = salarioM + aumento;
                Console.WriteLine("o seu salario total deste mes é" + total);
            }

            else if(trahoras < 160)
            {
                Console.WriteLine("o seu salario total deste mes é" + salarioM);
            }

        }
    }
}
