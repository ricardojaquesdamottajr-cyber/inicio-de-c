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
            
            
            if (trahoras >= 160)
            {
                int salarioM = hsalario * 160;  
                double calculo = trahoras - 160; 
                double salarioH = hsalario * 50 / 100;
                double calculoS = calculo * salarioH;
               

            
                double total = salarioM + calculoS ;
                Console.WriteLine("o seu salario total deste mes é" + total);
            }

            else if(trahoras < 160)
            {
                double salario2 = hsalario * trahoras;
                Console.WriteLine("o seu salario total deste mes é" + salario2);
            }

        }
    }
}
