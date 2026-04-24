using System;

namespace apresentação4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 11; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                else if(i == 9)
                {
                    break;
                }
                Console.WriteLine("os numeros só vao até " + i);
            }
        }
    }
}
