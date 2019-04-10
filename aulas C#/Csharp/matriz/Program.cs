using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int soma = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    soma += matrix[i, j];
                }
            }
            Console.WriteLine("Soma:" + soma);
        }
    }
}