using System;

namespace questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe quantso carros voce vendeu ");
            double vendascarros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o valor total das suas vendas ");
            double valorvendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe quanto é o seu salario fixo ");
            double salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quanto voce ganha por carro vendido? ");
            double carrovendido = Convert.ToDouble(Console.ReadLine());

            double calculovenda = valorvendas * 0.05;

            double calculo = calculovenda + salario + carrovendido;

            Console.WriteLine("o seu salario mfinal sera de: " + calculo);
        }
    }
}
