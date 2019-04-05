using System;

namespace imapr_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao melhor jogo de par ou impar! Vamos jogar?");
            
            string resposta = Console.ReadLine();

            if (resposta.Equals("sim"))
            {
                Console.WriteLine("Ok... então voce quer par ou impar?");
                string parOuImpar = Console.ReadLine();
                if (parOuImpar.Equals("par"))
                {
                    Console.WriteLine("Então eu sou impar");
                }
                else
                    Console.WriteLine("Então eu sou par");

                Console.WriteLine("insira um número de 0 a 10");
                int escolha = int.Parse(Console.ReadLine());

                Random r = new Random();
                int numeroPc = r.Next(0, 10);

                Console.WriteLine("O meu número é: " + numeroPc);

                if ((escolha + numeroPc) % 2 == 0 && (parOuImpar.Equals("par")))
                {
                    Console.WriteLine("Parabens voce venceu!");
                } else if ((escolha + numeroPc) % 2 != 0 && (parOuImpar.Equals("impar")))
                {
                    Console.WriteLine("Putz voce venceu");
                }else
                {
                    Console.WriteLine("Uhuuull eu venci!!!");
                }
            }
            else
                Console.WriteLine("então, só lamento 2bjos");
        }


    }
}

