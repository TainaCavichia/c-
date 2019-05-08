using System;
using System.Collections.Generic;
using reciclando.Interfaces;
using reciclando.Modelos;

namespace reciclando {
    enum LixosEnum : uint {
        ESPELHO,
        LATINHA,
        GARRAFA_PET,
        JORNAL,
        GUARDA_CHUVA,
        BANANA_PODRE
    }
    class Program {
        static void Main (string[] args) {
            bool querSair = false;

            do {
                Console.Clear();
                ExibirMenuLixos ();
                System.Console.Write ("Digite o código do lixo e veja sua classificação:");
                int codigo = int.Parse (Console.ReadLine ());
                var lixo = Dicionario.Lixos[codigo];

                switch (codigo) {
                    case 1:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IVidro)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IMetal)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    case 3:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IPlastico)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IPapel)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    case 5:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IIndefinido)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    case 6:
                        lixo = Dicionario.Lixos[codigo];
                        MostrarInterface((IOrganico)lixo);
                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                }

            } while (!querSair);

        }
        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void ExibirMenuLixos () {
            var lixos = Enum.GetNames (typeof (LixosEnum));
            int codigo = 1;
            string menuBorda = "===================================";
            System.Console.WriteLine (menuBorda);
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine ("=              Lixos              =");
            Console.ResetColor();
            foreach (var lixo in lixos) {
                System.Console.WriteLine ($"  {codigo++} {TratarTituloMenu(lixo)}");
            }
            System.Console.WriteLine (menuBorda);
        }
        public static void MostrarInterface(IVidro lixo){
            lixo.ReciclarComoVidro();
        }
        public static void MostrarInterface(IPlastico lixo){
            lixo.ReciclarComoPlastico();
        }
        public static void MostrarInterface(IIndefinido lixo){
            lixo.ReciclarComoIndefinido();
        }
        public static void MostrarInterface(IMetal lixo){
            lixo.ReciclarComoMetal();
        }
        public static void MostrarInterface(IOrganico lixo){
            lixo.ReciclarComoOrganico();
        }
        public static void MostrarInterface(IPapel lixo){
            lixo.ReciclarComoPapel();
        }
    }
}