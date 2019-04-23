using System;

namespace pizzaria {
    class Program {
        static void Main (string[] args) {

            int escolha = 0;

            do {
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

                switch (escolha) {
                    case 1:
                        Usuario.Inserir ();
                        break;

                    case 2:
                        Usuario.EfetuarLogin ();

                        do {
                            System.Console.WriteLine ("=================================");
                            System.Console.WriteLine ("Agora que voce ja faz parte da nossa equipe, escolha uma opção abaixo:");
                            System.Console.WriteLine ("=================================");
                            System.Console.WriteLine ("|| 1- Cadastrar Produto        ||");
                            System.Console.WriteLine ("|| 2- Listar Produtos          ||");
                            System.Console.WriteLine ("|| 3- Busca por Id             ||");
                            System.Console.WriteLine ("|| 9- Sair                      ||");
                            System.Console.WriteLine ("=================================");

                            System.Console.Write ("Número:");
                            escolha = int.Parse (Console.ReadLine ());

                            switch (escolha) {
                                case 1:
                                Produto.Cadastrar();
                                    break;

                                case 2:
                                Produto.Listar();
                                    break;

                                case 3:
                                Produto.BuscaPorId();
                                    break;

                                case 9:
                                    break;

                                default:
                                    System.Console.WriteLine ("Valor inválido");
                                    break;
                            }

                        } while (escolha != 9);
                        
                        break;
                        
                    case 3:
                        Usuario.Listar ();
                        break;

                    case 9:

                        break;

                    default:
                        System.Console.WriteLine ("Valor inválido");
                        break;
                }

            } while (escolha != 9);

        }
    }
}