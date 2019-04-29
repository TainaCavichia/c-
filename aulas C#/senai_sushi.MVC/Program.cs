using System;
using senai_sushi.MVC.Utils;
using senai_sushi.MVC.ViewController;
using senai_sushi.MVC.ViewModel;

namespace senai_sushi.MVC {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastrar usuario
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        //Efetuar login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            System.Console.WriteLine ($"Seja Bem vindo - {usuarioRecuperado.Nome}");
                            do {
                                MenuUtil.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());

                                switch (opcaoLogado) {
                                    case 1:
                                        //Cadastrar produto
                                        break;
                                    case 2:
                                        //Listar
                                        break;

                                    case 3:
                                        //Buscar por ID
                                        break;
                                    case 0:
                                        //Sair
                                        break;
                                    default:
                                        System.Console.WriteLine ("Opção inválida");
                                        break;
                                }

                            } while (opcaoLogado != 0);
                        }
                        break;
                    case 3:
                        //Listar
                        UsuarioViewController.ListarUsuario ();
                        break;
                    case 0:
                        //Sair
                        break;
                    default:
                        System.Console.WriteLine ("Opção inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);

        }
    }
}