using System;
using senai_sushi.MVC.Utils;
using senai_sushi.MVC.ViewModel;

namespace senai_sushi.MVC {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                    //Cadastrar usuario
                        break;
                    case 2:
                    //Efetuar login
                        break;
                    case 3:
                    //Listar
                        break;
                    case 0:
                    //Sair
                        break;
                    default:
                    System.Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}