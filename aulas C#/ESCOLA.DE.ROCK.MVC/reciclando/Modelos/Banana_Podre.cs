using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Banana_Podre : LixoReciclavel, IOrganico
    {
        public bool ReciclarComoOrganico(){
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogue o lixo nA COMPOSTEIRA, ajude o meio ambiente :)");
            Console.ResetColor();
            return true;
        }
    }
}