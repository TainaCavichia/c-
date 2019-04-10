using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 1234;


            Console.WriteLine("------Login------");

            Console.WriteLine("Digite a sua senha");
            senha = int.Parse(Console.ReadLine());

            if (senha != 1234)
            {
                Console.WriteLine("Acesso negado!");

            }else
            {
                Console.WriteLine("Acesso permitido!");
            }

            


        }
    }
}
