using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numeros impares");
            int impar = 0;
            int [] idades = {18,11,9,2,73,40,1,59,7,43,0,8,13,87,61};

            for (int i = 0; i < idades.Length; i++)
            {
               if (idades[i] % 2 == 1)//colocamos o i nas chaves para o array acessar 1 numero de cada vez
               {
                   impar++;
               }
            }
            Console.WriteLine(impar);
        }
    }
}
