using System;

namespace multiplos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numLinha = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 0; i < numLinha; i++)
            {
                num += 1;
                if ((num % 4) == 0)
                {
                    Console.WriteLine("pi");
                }else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
