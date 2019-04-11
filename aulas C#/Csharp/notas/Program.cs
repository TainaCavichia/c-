using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando as médias");

            string[] nome = new string[10];
            string[] sobrenome = new string[10];
            double[] notas1 = new double[10];
            double[] notas2 = new double[10];
            double[] soma = new double[10];
            double[] media = new double[10];

            for (int i = 0; i < 10; i++)
            {

            Console.WriteLine($"Digite o seu {i + 1}° nome:");
            nome[i] = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome[i] = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            notas1[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            notas2[i] = double.Parse(Console.ReadLine());

            soma[i] = notas1[i] + notas2[i]; 
            media[i] = soma[i] / 2;

            if (media[i] > 50)
            {
                Console.WriteLine($" Nome : {nome[i]} {sobrenome[i]} \n A média foi : {media[i]} \n O Aluno foi Aprovado");
            }else
            {
                Console.WriteLine($" Nome : {nome[i]} {sobrenome[i]} \n A média foi : {media[i]} \n O Aluno foi Reprovado");
            }

            }

        }
    }
}