using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Espelho : LixoReciclavel, IVidro
    {
        public bool ReciclarComoVidro(){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogue o lixo no cesto VERDE");
            Console.ResetColor();
            return true;
        }
    }
}