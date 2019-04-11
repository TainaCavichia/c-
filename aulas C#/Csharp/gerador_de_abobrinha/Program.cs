using System;

namespace gerador_de_abobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra ai, meu consagrado!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[] PalavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                PalavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma");
                }
                else
                {
                    Console.WriteLine("Valeu,jovem! Agora deixa comigo");
                }
            }
            string[,] matrizPalavras = {
                                   {"é","","jaca","dedo",""},
                                   {"","janela","lixo","carro","piramide"},
                                   {"coração","pedra","batata","","néctar"},
                                   {"feijao","argola","carandiru","eu","virgula"},
                                   {"rodizio","perola","sou","laranja",""}
            };

            for (int i = 0; i < matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPalavras.GetLength(0); j++)
                {
                    if ("".Equals(matrizPalavras[i,j]))
                    {
                        matrizPalavras[i,j] = PalavrasUsuario[i];
                    }
                }
            }

            string frase = "";

            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0)),
                                        r.Next(matrizPalavras.GetLength(0))] 
                                        + " ";
            }
            Console.WriteLine("Minha frase é: \n" + frase);
        }
    }
}