using System;
using senaiiiii.Utils;

namespace senaiiiii {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;

            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado)
                {
                    case 1:
                    //cadastrar usuario
                    UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                    //fazer login
                    UsuarioViewController.LoginUsuario();
                    break;

                    default:
                    System.Console.WriteLine("Valor inválido");
                    break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}