using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Será que voce pode votar?");

            Console.WriteLine("Escreva o ano que voce nasceu");
            int ano = int.Parse(Console.ReadLine());

            if (ano<=2003)
            {
                Console.WriteLine("Parabéns!Voce pode votar");
            }else
            {
                Console.WriteLine("Que pena,voce nao pode votar volte nas próximas eleições");
            }

        }
    }
}
