using System;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de triangulos");
            int qnttriangulos = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o tamanho do triangulo");
            int qntlinhas = int.Parse(Console.ReadLine());

            for (int i = 0; i < qnttriangulos; i++)
            {
                string estrela = "";

                for (int j = 0; j < qntlinhas; j++)
                {
                estrela += "*";
                Console.WriteLine(estrela);
                    
                }
            }
        }
    }
}