using System;

namespace jesus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à Tsukamoto airlines");

            // bool sair;
            int passageirosCadastrados = 0;
            Passageiro[] passageiros = new Passageiro[2];

            do
            {
                System.Console.WriteLine("Escolha uma opção");
                System.Console.WriteLine("1 - Registrar passageiro");
                System.Console.WriteLine("2 - Exibir passagens");
                System.Console.WriteLine("0 - Sair");

                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do passageiro");
                        Passageiro p = new Passageiro();
                        p.setNome(Console.ReadLine());

                        Console.WriteLine("Digite o numero da passagem");
                        p.setNumeroPassagem(int.Parse(Console.ReadLine())); 
                        
                        Console.WriteLine("Digite a data do voo");
                        p.setData(DateTime.Parse(Console.ReadLine()));
                        
                        passageiros[passageirosCadastrados] = p;

                        passageirosCadastrados++;

                        Console.WriteLine("Passageiro cadastrado com sucesso");
                        break;

                    case 2:
                        for (int i = 0; i < passageirosCadastrados; i++)
                        {
                            Console.WriteLine("Todos os passageiros cadastrados");
                            Console.WriteLine(passageiros[i].getNome());
                        }
                        break;

                    case 0:
                        break;
                }

            } while (true);
        }
    }
}
