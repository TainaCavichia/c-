using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double maca = 0;
            double preco;
            bool repetir = true;

            Console.WriteLine("Comprando maçãs");
            while (repetir)
            {

            Console.WriteLine("Digite o numero de maçãs que voce quer comprar:");
            int numDeMacas = int.Parse(Console.ReadLine());

            if (numDeMacas < 12)
            {
                maca = 0.30;

            }else
            {
                maca = 0.25;
            }

            preco = numDeMacas * maca;
            Console.WriteLine($"O preço é: {preco}");
            }
        }
    }
}
