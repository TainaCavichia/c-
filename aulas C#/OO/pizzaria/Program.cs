using System;

namespace pizzaria {
    class Program {
        static void Main (string[] args) {

            int escolha = 0;
            string emailUsuario;
            string senhaUsuario;

            do {
                Console.Clear ();
                System.Console.WriteLine ("=================================");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("***Bem vindo a Tsukaria Pizzamoto***");
                Console.ResetColor ();
                System.Console.WriteLine ("  Escolha uma das opções abaixo  ");
                System.Console.WriteLine ("=================================");
                System.Console.WriteLine ("|| 1- Cadastrar usuário        ||");
                System.Console.WriteLine ("|| 2- Efetuar login            ||");
                System.Console.WriteLine ("|| 3- Listar usuários          ||");
                System.Console.WriteLine ("|| 0- Sair                     ||");
                System.Console.WriteLine ("=================================");

                System.Console.Write ("Número: ");
                escolha = int.Parse (Console.ReadLine ());

                switch (escolha){
                    case 1:
                       Usuario.Inserir();
                        break;

                    case 2:
                        System.Console.WriteLine("Digite seu e-mail");
                        emailUsuario = Console.ReadLine();

                        System.Console.WriteLine("Digite sua senha");
                        senhaUsuario = Console.ReadLine();
                    
                        break;
                    
                    case 3:

                    break;

                    case 9:

                    break;
                    
                    default:
                        System.Console.WriteLine("Valor inválido");
                        break;
                }

            } while (escolha != 0);

        }
    }
}