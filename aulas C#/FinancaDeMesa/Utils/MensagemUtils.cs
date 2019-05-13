using System;
using FinancaDeMesa.Enums;

namespace FinancaDeMesa.Utils
{
    public class MensagemUtils
    {
        public static void MostrarMensagem(string mensagem, Cores tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case Cores.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                break;
                case Cores.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                break;
                case Cores.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                break;
                case Cores.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                break;
                default:
                    break;
                
            }
            System.Console.WriteLine(mensagem);
            Console.ResetColor();

            // System.Console.WriteLine("\nAperte ENTER para prosseguir");
            // Console.ReadLine();
        }
    
        public static void Continuar()
        {
            Console.WriteLine("\nAperte ENTER para continuar");
            Console.ReadLine();
        }
    }
}