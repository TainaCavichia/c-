using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] notas = {100, 50, 20, 10, 5, 2, 1};

            Console.WriteLine("Digite o quanto voce quer sacar:");
            int saque = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now;

            for (int i = 0; i < notas.Length; i++)
            {
               int numeroDeNotas = saque / notas[i];
               int restante = saque % notas[i];
               saque = restante;

               if (numeroDeNotas != 0)
               {
                   Console.WriteLine($"Voce recebeu {numeroDeNotas} nota(s) de {notas[i]} em {data}");
               }
            }
        }
    }
}