using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string passeio;
            
            Console.WriteLine("Qual a boa?");
            passeio = Console.ReadLine();

            switch(passeio){
                case "montanha":
                    Console.WriteLine("Bora escalar!");
                    break;
                case "deserto":
                    Console.WriteLine("Bora fritar!");
                    break;
                case "floresta":
                    Console.WriteLine("Vai lá, Tarzan");
                    break;
                default:
                    Console.WriteLine("Ah, então vamos pro Netflix!");
                    break;
            }
        }
    }
}
