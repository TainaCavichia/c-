using System;

namespace numcasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [3];

            for (int i = 0; i < numeros.Length; i++)
            {
            Console.WriteLine("Digite o numero da sua casa:");
            numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (var numero in numeros)
            {
            Console.WriteLine($"O numero da casa é {numero}");   
            }
        }
    }
}