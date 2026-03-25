using System;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o seu salario");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantos % vai ser o reajuste de salario?");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            double calculo = salario * porcentagem / 100.0;
            double novovalor = salario - calculo;
            Console.WriteLine("o novo salario sera de: " + novovalor );
        }
    }
}
