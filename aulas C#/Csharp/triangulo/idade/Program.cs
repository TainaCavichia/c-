using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Será que voces são maiores de idade?");

            for (int i = 1; i <= 10; i++)
            {
            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                cont += 1;
            }    
            }
                Console.WriteLine("O numero de pessoas maiores de idade é {0}", cont);
        }
    }
}
