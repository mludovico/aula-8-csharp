using System;

namespace Paridade
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                string paridade = i % 2 == 0 ? "par" : "ímpar";
                Console.WriteLine($"O número {i} é {paridade}");
            }
        }
    }
}
