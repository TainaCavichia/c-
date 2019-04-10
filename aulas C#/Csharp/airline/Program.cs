using System;

namespace airline {
    class Program {
        static void Main (string[] args) {
            bool repetir = true;
            string resposta;
            string[] nome = new string[5];
            int[] numPassagem = new int[5];
            DateTime[] data = new DateTime[5];
            int i = 0;
            int j = 0;

            while (repetir) {

                Console.WriteLine ("----------Escolha uma opção----------");
                Console.WriteLine ("1 - Registrar Passagem");
                Console.WriteLine ("2 - Visualizar Passagens");
                Console.WriteLine ("0 - Sair");
                resposta = Console.ReadLine ();

                switch (resposta) {
                    case "1":

                        if (i < 5) {

                            Console.WriteLine ("Digite o seu nome completo");
                            nome[i] = Console.ReadLine ();

                            Console.WriteLine ("Digite o número de passagens");
                            numPassagem[i] = int.Parse (Console.ReadLine ());

                            Console.WriteLine ("Digite a data do voo");
                            data[i] = DateTime.Parse (Console.ReadLine ());

                            i++;

                        } else {
                            Console.WriteLine ("As passagens acabaram... Volte depois!");
                        }

                        break;

                    case "2":

                        j = 0;

                        for (j = 0; j < i; j++) {
                            Console.WriteLine ($" -----------------------\n Nome: {nome[j]} \n N° de passagens: {numPassagem[j]} \n Data do voo: {data[j]:dd:MM:yyyy}\n-----------------------");
                        }
                        break;

                    case "0":
                        repetir = false;
                        Console.WriteLine("A nossa agencia agradece");
                        break;

                    default:
                        Console.WriteLine ("Digite um valor válido");
                        break;

                } //fim do switch
            } //fim do while

        }
    }
}