using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Latinha : LixoReciclavel, IMetal
    {
         public bool ReciclarComoMetal(){
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogue o lixo no cesto AMARELO");
            Console.ResetColor();
            return true;
        }
    }
}