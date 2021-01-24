using System;
using System.Collections.Generic;

namespace Genero
{
    class Program
    {
        static void Main(string[] args)
        {
            int contagemMulher = 0;
            int contagemHomem = 0;
            List<string> listaNomes = new List<string> { "Tadeu", "Alexandre", "Thaise", "Thamirys", "Matheus", "Mariana", "Valeska" };
            foreach (string  nome in listaNomes)
            {
                bool opcaoValida = false;
                while (!opcaoValida)
                {
                    Console.Write($"{nome} é homem ou mulher? H - Homem, M - Mulher: ");
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "H":
                            contagemHomem++;
                            opcaoValida = true;
                            break;
                        case "M":
                            contagemMulher++;
                            opcaoValida = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            opcaoValida = false;
                            break;
                    } 
                }
            }
            Console.WriteLine($"{contagemMulher} são mulheres e {contagemHomem} são homens.");
        }
    }
}
