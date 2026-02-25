using System;

namespace teste_c
{
    class Program
    {
        static void Main(string[] args)
        {


            int idade = 18;
            double precoproduto = 1.99;
            char sexo = 'f';
            string nome = "elias";
            bool ligado = true;


            Console.WriteLine(idade);
            Console.WriteLine(precoproduto);
            Console.WriteLine(nome);
            Console.WriteLine(ligado);
            Console.WriteLine(sexo);


            Console.WriteLine("ola " + nome);
            int x = 3;
            int y = 2;
            Console.WriteLine(x + y);


            Console.WriteLine("digite o nome de usuario");
            string username = Console.ReadLine();
            Console.WriteLine("o nome do usuario é " + username);
        }
    }
}
