using System;

namespace Senai.Tsushi.MVC.Utils {
    public class MenuUtil {
        public static void MenuDeslogado () {
            System.Console.WriteLine ("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("-------------- TSUSHI -------------");
            Console.ResetColor ();
            System.Console.WriteLine ("-----------------------------------");
            System.Console.WriteLine ("-- (1) - Cadastrar Usuário --------");
            System.Console.WriteLine ("-- (2) - Efetuar Login ------------");
            System.Console.WriteLine ("-- (3) - Listar -------------------");
            System.Console.WriteLine ("-- (0) - Sair ---------------------");
            System.Console.WriteLine ("-----------------------------------");
            System.Console.WriteLine ("-- Escolha uma opção---------------");
            System.Console.WriteLine ("-----------------------------------");

        }
        public static void MenuLogado () {
            System.Console.WriteLine ("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine ("-------------- TSUSHI -------------");
            Console.ResetColor ();
            System.Console.WriteLine ("-----------------------------------");
            System.Console.WriteLine ("-- (1) - Cadastrar Produto --------");
            System.Console.WriteLine ("-- (2) - Listar -------------------");
            System.Console.WriteLine ("-- (3) - Busca por ID -------------");
            System.Console.WriteLine ("-- (0) - Sair ---------------------");
            System.Console.WriteLine ("-----------------------------------");
            System.Console.WriteLine ("-- Escolha uma opção---------------");
            System.Console.WriteLine ("-----------------------------------");
        }
    }
}