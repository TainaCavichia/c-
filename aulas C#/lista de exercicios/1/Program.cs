using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O maior número");

            int numero1;
            int numero2;

            Console.WriteLine("Digite o primeiro número");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("o primeiro número é maior");
            }else if(numero2 > numero1)
            {
                Console.WriteLine("o segundo número é maior");
            }
        }
    }
}
