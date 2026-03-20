using System;

namespace pessoa1
{
    class Principal
    {

    
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            pessoa1.provarExistencia();

            Console.WriteLine("insira seu nome");
            string nomepessoa1 = Console.ReadLine();
            Console.WriteLine("insira uma senha");
            int senhapessoa1 =  Convert.ToInt32( Console.ReadLine());


            Console.WriteLine("insira seu nome");
            string nomepessoa2 = Console.ReadLine();
            Console.WriteLine("insira uma senha");
            int senhapessoa2 = Convert.ToInt32(Console.ReadLine());

            pessoa1.nome = nomepessoa1;
            pessoa1.email = "e@e";
            pessoa1.login = "elias";
            pessoa1.senha = senhapessoa1;

            pessoa2.nome = nomepessoa2;
            pessoa2.email = "e@e";
            pessoa2.login = "elias";
            pessoa2.senha = senhapessoa2;

            Console.WriteLine(pessoa1.nome);
            Console.WriteLine(pessoa1.email);
            Console.WriteLine(pessoa1.login);
            Console.WriteLine(pessoa1.senha);

            Console.WriteLine(pessoa2.nome);
            Console.WriteLine(pessoa2.email);
            Console.WriteLine(pessoa2.login);
            Console.WriteLine(pessoa2.senha);

        }
    }
}
