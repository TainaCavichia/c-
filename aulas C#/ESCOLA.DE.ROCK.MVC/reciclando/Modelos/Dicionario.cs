using System.Collections.Generic;

namespace reciclando.Modelos
{
    public class Dicionario
    {
        public static Dictionary<int, LixoReciclavel> Lixos = new Dictionary<int, LixoReciclavel>(){
            {1, new Espelho()},
            {2, new Latinha()},
            {3, new Garrafa_Pet()},
            {4, new Jornal()},
            {5, new Guarda_Chuva()},
            {6, new Banana_Podre()}
        };
    }
}