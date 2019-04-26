using System;
namespace senai_sushi.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------------TSUSHI-----------------");
            Console.WriteLine("--------(1) CADASTRAR USUÁRIO -------");
            Console.WriteLine("--------(2) EFETUAR LOGIN -----------");
            Console.WriteLine("--------(3) LISTAR ------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------Escolha uma opção -----------");
            Console.WriteLine("-------------------------------------");
        }
    }
}