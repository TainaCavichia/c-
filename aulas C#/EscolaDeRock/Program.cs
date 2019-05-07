using System;
using System.Collections.Generic;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : uint {
        TRIO,
        QUARTETO
    }
    enum InstrumentosEnum : uint {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        PIANO,
        VIOLAO,
        TAMBORES
    }
    class Program {
        static void Main (string[] args) {
            var opcaoFormacao = new List<string> () {
                "   - 0                          ",
                "   - 1                      "
            };

            bool querSair = false;
            string barraMenu = "===================================";
            string[] itensMenuFormacao = Enum.GetNames (typeof (FormacaoEnum));
            int opcaoFormacaoSelecionada = 0;

            do {
                bool formacaoEscolhida = false;
                do {
                    Console.Clear ();
                    System.Console.WriteLine (barraMenu);
                    System.Console.WriteLine ("           ESCOLA DE ROCK          ");
                    System.Console.WriteLine ("       Escolha sua formação:       ");
                    System.Console.WriteLine (barraMenu);

                    for (int i = 0; i < opcaoFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuFormacao[i]);

                        if (opcaoFormacaoSelecionada == i) {
                            DestacarOpcao (opcaoFormacao[opcaoFormacaoSelecionada].Replace ("-", ">").Replace (i.ToString (), titulo));
                        } else {
                            System.Console.WriteLine (opcaoFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }

                    var tecla = Console.ReadKey (true).Key;

                    switch (tecla) {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcaoFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }

                } while (!formacaoEscolhida);

                bool bandaEstaCompleta = false;
                int vagas = 0;

                switch (opcaoFormacaoSelecionada) {
                    case 0:
                    vagas = 2;
                        do {
                            ExibirMenuDeInstrumentos ();
                            System.Console.WriteLine ("Digite o código do intrumento para a categoria Harmonia");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Candidatos.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");
                            
                            if (interfaceEncontrada != null)
                            {
                                ColocarNaBanda((IHarmonia)instrumento);
                            } else
                            {
                                continue;
                            }

                             System.Console.WriteLine ("Digite o código do intrumento para a categoria Percussão");
                            codigo = int.Parse (Console.ReadLine ());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");
                            
                            if (interfaceEncontrada != null)
                            {
                            vagas--;
                                ColocarNaBanda((IPercussao)instrumento);
                            } else
                            {
                                continue;
                            }
                            if (vagas == 0)
                            {
                                bandaEstaCompleta = true;
                            }
                            
                        } while (!bandaEstaCompleta);
                        
                        break;
                    case 1:

                        break;
                }
            } while (!querSair);

        }
        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }
        public static void ExibirMenuDeInstrumentos () {
            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#         Instrumentos        #");

            foreach (var instrumento in instrumentos) {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }
        public static void ColocarNaBanda (IHarmonia instrumento) {
            instrumento.TocarAcordes();
        }
        public static void ColocarNaBanda (IPercussao instrumento) {
            instrumento.ManterRitmo();
        }
        public static void ColocarNaBanda (IMelodia instrumento) {
            instrumento.TocarSolo();
        }
    }
}