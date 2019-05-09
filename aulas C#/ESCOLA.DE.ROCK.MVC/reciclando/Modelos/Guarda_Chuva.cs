using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Guarda_Chuva : LixoReciclavel, IIndefinido
    {
         public bool ReciclarComoIndefinido(){
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogue o lixo no cesto CINZA");
            Console.ResetColor();
            return true;
        }
    }
}