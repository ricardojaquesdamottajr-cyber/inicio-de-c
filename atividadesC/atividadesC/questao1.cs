using System;

namespace atividadesC
{
    class questao1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("quantas pessoas irão votar?");
            int pessoas = Convert.ToInt32(Console.ReadLine());
           
            int nulos = 0;
            int invalidos = 0;
            int branco = 0;
            int validos = 0;

            for (int i = 0; i< pessoas;) {
                Console.WriteLine("voce vai votar? se sim digite 1 se não digite 2 ");
                int eleitores = Convert.ToInt32(Console.ReadLine());
                if (eleitores == 1)
                {
                    i++;
                    Console.WriteLine("se seu voto for nulo digite 1 se seu voto for em branco digite 2");
                    int votos = Convert.ToInt32(Console.ReadLine());
                    if (votos == 1)
                    { 
                        nulos++;
                        validos++;
                    }

                    if(votos == 2)
                    {
                        branco++;
                        validos++;
                        
                    }

                    

                }
                if (eleitores == 2)
                {
                    invalidos++;
                    pessoas--;
                }
            }
            double calculoporcentagembranco = branco / 100.0;
            double calculonulosporcentagem = nulos / 100.0;
            double calculovalidosporcentagem = validos / 100.0;

            double calculoeleitoresnulos = pessoas * calculonulosporcentagem;
            double calculoeleitoresembranco = pessoas * calculoporcentagembranco;
            double calculovalidoeleitoes = pessoas * calculoporcentagembranco;

            Console.WriteLine("o total de eleitores é " + pessoas + " o numero de votos validos foi " + validos + " a porcentagem de de pessoas que votaram em votos nulos foi " + calculonulosporcentagem + " a porcentagem de votos em branco foi " + calculoporcentagembranco );
        }
    }
}
