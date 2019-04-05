using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            bool replay = true;
            string resposta;

            while (replay == true)
            {
                Console.WriteLine("Insira o mumero da tabuada");
                int num = int.Parse(Console.ReadLine());

                int cont = 0;
                while (cont <= 10)
                {
                    Console.WriteLine(num + " X " + cont + " = " + num * cont);
                    cont++;
                }
                Console.WriteLine("Voce deseja calcular outra tabuada?");
                resposta = Console.ReadLine();

                replay = resposta.Equals("sim") ? true : false;
            }
        }
    }
}
