using System;

namespace atividadec
{
    class Program
    {
        private const double V = 5.1;

        static void Main(string[] args)
        {
            //exercicio 1
            //Console.WriteLine("qual é o seu nome? ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("qual ano que vc nasceu");
            //int ano = Convert.ToInt32(Console.ReadLine());
            //int calculo = 2026 - ano;
            //Console.WriteLine("o seu nome é " + nome + "a sua idade é " + calculo);

            //exercicio 2

            //Console.WriteLine("digite o valor em dolar");
             //int dolar = Convert.ToInt32(Console.ReadLine());
            //decimal cotação = 5.1m * dolar;
           // Console.WriteLine("o valor em Reais sera: R$" + cotação);

            //exercicio3

            //Console.WriteLine("informe o valor da altura do retangulo");
            //int B = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("informe o valor da base do retangulo");
            //int H = Convert.ToInt32(Console.ReadLine());
           // int calculo = B * H;
           // Console.WriteLine("a area do retangulo sera: " + calculo);

            //exercicio 4

            Console.WriteLine("digite o valor em dolar");
             decimal dolar = Convert.ToDecimal(Console.ReadLine());
             decimal cotação = 5.10m * dolar;
            Console.WriteLine("o valor em Reais sera: R$" + cotação);
        }
    }
}
