using System;

namespace ex2 {
    class Program {
        static void Main (string[] args) {
            int machos = 0;
            int divas = 0;
            int idade;
            float peso;
            string sexo;
            float pesoDivas = 0;
            float pesoMachos = 0;
            int IdadeDivas = 0;
            int IdadeMachos = 0;
            float mediapemu = 0;
            float mediaidmu = 0;
            float mediapeho = 0;
            float mediaidho = 0;

            Console.WriteLine ("Divas e machos");

            for (int i = 1; i <= 3; i++) {

                Console.WriteLine ("Insira a sua idade:");
                idade = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Insira o seu peso:");
                peso = float.Parse (Console.ReadLine ());

                Console.WriteLine ("Insira o seu sexo:");
                sexo = Console.ReadLine ();

                if (sexo.Equals ("feminino")) {
                    divas++;
                    pesoDivas += peso;
                    IdadeDivas += idade;
                } else {
                    machos++;
                    pesoMachos += peso;
                    IdadeMachos += idade;
                }
            }
            mediapemu = pesoDivas / divas;
            mediaidmu = IdadeDivas / divas;

            mediapeho = pesoMachos / machos;
            mediaidho = IdadeMachos / machos;

            Console.WriteLine ("A quantidade de mulheres é {0} e a de homens é {1}", divas, machos);
            Console.WriteLine ("A media do peso das mulheres é {0} e a dos homens é {1}", mediapemu, mediapeho);
            Console.WriteLine ("A media da idade das mulheres é {0} e a dos homens é {1}", mediaidmu, mediaidho);
        }
    }
}