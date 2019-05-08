using System;
using reciclando.Interfaces;

namespace reciclando.Modelos
{
    public class Garrafa_Pet : LixoReciclavel, IPlastico
    {
         public bool ReciclarComoPlastico(){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Jogue o lixo no cesto VERMELHO");
            Console.ResetColor();
            return true;
        }
    }
}