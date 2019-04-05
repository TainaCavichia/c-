using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            do
            {
            Console.WriteLine(cont);
            cont += 50;
                
            } while (cont < 500);
            cont = 50;

            Console.WriteLine("--------------------------------------------------------------");
            
            bool jaAcordei = false;

            do
            {
                Console.WriteLine("Pai já acordou?");
                string resposta = Console.ReadLine();

                jaAcordei = resposta.Contains("que") ? true : false;
            } while (!jaAcordei);

        }
    }
}
