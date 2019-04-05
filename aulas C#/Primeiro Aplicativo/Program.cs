using System;

namespace Primeiro_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        { 
            string nome;
            string sobrenome;

            Console.WriteLine("Bem vindo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Bem Vindo - "+nome+" "+sobrenome);
        }
    }
}
