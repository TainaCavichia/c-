using System;

namespace Quarto_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos para a balada");

            Console.WriteLine("Voce está disponível na sexta?");
            string resposta = Console.ReadLine();
        if (resposta.Equals("não"))
        {
            Console.WriteLine("Sinto muito, tente outro role");
        }else if (resposta.Equals("sim"))
        {
            Console.WriteLine("Voce tem quantos anos?");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Sinto muito, mas voce nao pode entrar na balada");
            }else
            {
                Console.WriteLine("Voce é VIP ou pagou sua entrada?");
                string respostas = Console.ReadLine();
                if (respostas.Equals("sim"))
                {
                    Console.WriteLine("SEXTOOOUUUU");
                }else if (respostas.Equals("não"))
                {
                    Console.WriteLine("Compre o ingresso e vá jovem!");
                }
            }
            
        }
    }
}
}