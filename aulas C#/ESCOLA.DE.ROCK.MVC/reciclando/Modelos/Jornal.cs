using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Jornal : LixoReciclavel, IPapel
    {
         public bool ReciclarComoPapel(){
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Jogue o lixo no cesto AZUL");
            Console.ResetColor();
            return true;
        }
    }
}