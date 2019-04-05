using System;

namespace Terceiro_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga-me a previsão do tempo");

            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio")) 
            {
                Console.WriteLine("Vamos à montanha");
            }
            else if (clima.Equals("calor")) 
            {
                Console.WriteLine("Vamos à praia");
                
            }
            else if (clima.Equals("chuva")) 
            {
                Console.WriteLine("Vamos para Steam?");
                string resposta = Console.ReadLine();
                if (resposta.Equals("não"))
                {
                    Console.WriteLine("Vamos para Netflix!");
                }
            }else{
                Console.WriteLine("Valor invalido \n Digite: chuva, frio ou calor");
            }
        }
    }
}
