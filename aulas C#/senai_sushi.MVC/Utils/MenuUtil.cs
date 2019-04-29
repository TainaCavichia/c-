using System;
namespace senai_sushi.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------------TSUSHI-----------------");
            Console.WriteLine("--------(1) Cadastrar usuário -------");
            Console.WriteLine("--------(2) Efetuar login -----------");
            Console.WriteLine("--------(3) Listar ------------------");
            Console.WriteLine("--------(0) Sair --------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------Escolha uma opção -----------");
            Console.WriteLine("-------------------------------------");
        }

        public static void MenuLogado(){
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----------Restaurate Tsushi----------");
            Console.WriteLine("-------------Cardápio----------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------(1) Cadastrar Produto -------");
            Console.WriteLine("--------(2) Listar ------------------");
            Console.WriteLine("--------(3) Buscar por ID -----------");
            Console.WriteLine("--------(0) Sair --------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------Escolha uma opção -----------");
            Console.WriteLine("-------------------------------------");

        }
    }
}