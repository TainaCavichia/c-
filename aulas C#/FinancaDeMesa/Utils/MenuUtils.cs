using System;
using FinancaDeMesa.Enums;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.Utils {
    public class MenuUtils {
        public static void MenuPrincipal () {
            var opcoes = Enum.GetNames (typeof (MenuEnum));
            int codigo = 1;
            string barra = "==============================";
            System.Console.WriteLine (barra);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("       FINANÇA DE MESA        ");
            System.Console.WriteLine ("       Seja bem vindo!        ");
            Console.ResetColor ();
            System.Console.WriteLine (barra);
            foreach (var item in opcoes) {
                System.Console.WriteLine ($" {codigo++} {TratarTituloMenu(item)}");
            }
            System.Console.WriteLine (barra);

        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void MenuLogado (UsuarioViewModel usuario) {
            var opcoes = Enum.GetNames (typeof (MenuLogadoEnum));
            int codigo = 1;
            string barra = "==============================";
            System.Console.WriteLine (barra);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("       FINANÇA DE MESA        ");
            System.Console.WriteLine ($"    Seja bem vindo,{usuario.Nome}!      ");
            Console.ResetColor();
            System.Console.WriteLine (barra);
            foreach (var item in opcoes) {
                System.Console.WriteLine ($" {codigo++} {TratarTituloMenu(item)}");
            }
            System.Console.WriteLine (barra);

        }
        public static void MenuTipoTransacao () {
            var opcoes = Enum.GetNames (typeof (TipoTransacaoEnum));
            int codigo = 1;
            string barra = "==============================";
            System.Console.WriteLine(barra);
            System.Console.WriteLine ($"   Qual o tipo da transação?     ");
            System.Console.WriteLine (barra);
            foreach (var item in opcoes) {
                System.Console.WriteLine ($" {codigo++} {TratarTituloMenu(item)}");
            }
            System.Console.WriteLine (barra);

        }
    }
}