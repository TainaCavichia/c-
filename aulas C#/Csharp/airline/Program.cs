using System;

namespace airline
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {

            Console.WriteLine("----------Escolha uma opção----------");   
            Console.WriteLine("1 - Registrar Passagem");
            Console.WriteLine("2 - Visualizar Passagens");
            Console.WriteLine("0 - Sair");
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:

                for (int i = 0; i < 5; i++)
                {     
                Console.WriteLine("Digite o seu nome completo");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o número de passagens");
                int numPassagem = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data do voo");
                DateTime data = DateTime.Parse(Console.ReadLine());
                }

                break;
                
                case 2:
                break;

                case 0:
                repetir = false;
                break;
            }//fim do switch
            }//fim do while

        }
    }
}
