using System;

namespace operadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;
            bool temcarteira = true;

            if(idade >= 25 && temcarteira)
            {
                Console.WriteLine("Pode Dirigir");
            }

            bool ehfinaldesemana = false;
            bool ehferiado = true;

           if (ehfinaldesemana || ehferiado)
            {
               Console.WriteLine("Pode descansar");
           }

           bool usuariologado = false;

            if (!usuariologado)
            {
                Console.WriteLine("Por Favor, Fazer Login");
            }
        }
    }
}
