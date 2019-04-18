using System;

namespace pizzaria {
    class Program {
        static void Main (string[] args) {

            bool repetir = true;

            do {
                Console.Clear ();
                System.Console.WriteLine ("===============================");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("        Bem vindo a Tsukaria Pizzamoto          ");
                Console.ResetColor ();
                System.Console.WriteLine ("  Escolha uma das opções abaixo  ");
                System.Console.WriteLine ("=================================");
                System.Console.WriteLine ("|| 1- Cadastrar usuário        ||");
                System.Console.WriteLine ("|| 2- Efetuar login            ||");
                System.Console.WriteLine ("|| 3- Listar usuários          ||");
                System.Console.WriteLine ("|| 9- Sair                     ||");
                System.Console.WriteLine ("=================================");

                System.Console.Write ("Opção: ");
                int opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        Usuario usuario = new Usuario ();

                        break;
                }

            } while (repetir);

        }
    }
}