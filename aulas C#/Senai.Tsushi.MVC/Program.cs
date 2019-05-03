using System;
using Senai.Tsushi.MVC.Utils;
using Senai.Tsushi.MVC.ViewController;
using Senai.Tsushi.MVC.ViewModel;

namespace Senai.Tsushi.MVC {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());
                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastra Usuario
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        //Efetua Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            do {
                                System.Console.WriteLine ($"\n-----------------------------------");
                                System.Console.WriteLine ($"     Seja bem-vindo {usuarioRecuperado.Nome}");
                                MenuUtil.MenuLogado ();
                                opcaoDeslogado = int.Parse (Console.ReadLine ());
                                
                                switch (opcaoDeslogado) {
                                case 1:
                                    //Cadastra Produto
                                    ProdutoViewController.CadastrarProduto ();
                                    break;
                                case 2:
                                 //Listar
                                    ProdutoViewController.ListarProdutos ();
                                    break;
                                case 3:
                                    ProdutoViewModel produtoRecuperado = ProdutoViewController.BuscarporId();
                                    System.Console.WriteLine ($"Id: {produtoRecuperado.Id}\nNome: {produtoRecuperado.Nome}\nDescrição: {produtoRecuperado.Descricao}\nPreço: {produtoRecuperado.Preco}\nCategoria: {produtoRecuperado.Categoria}");
                                    break;
                                case 0:
                                    //Sair
                                    break;
                                default:
                                    System.Console.WriteLine ("Opção Inválida");
                                    break;
                                }
                            } while (opcaoDeslogado != 0);}

                        break;
                    case 3:
                        //Listar
                        UsuarioViewController.ListarUsuario ();
                        break;
                    case 0:
                        //Sair
                        break;
                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}