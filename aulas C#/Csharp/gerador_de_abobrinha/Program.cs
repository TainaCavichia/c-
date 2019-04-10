using System;

namespace gerador_de_abobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra ai, meu consagrado!");

            int maxPalavrasUsuario = 5;
            // int maxPalavrasFrase = 8;

            string[] PalavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                PalavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma");
                }else
                {
                    Console.WriteLine("Valeu,jovem! Agora deixa comigo");
                }
            }

        }
    }
}