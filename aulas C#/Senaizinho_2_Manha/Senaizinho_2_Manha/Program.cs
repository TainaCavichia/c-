using System;
using Senaizinho_2_Manha.enuns;

namespace Senaizinho_2_Manha {
    class Program {
        enum MenuEnum: uint{
            CADASTRAR_ALUNO = 1,
            CADASTRAR_SALA,
            ALOCAR_AUNO,
            REMOVER_ALUNO,
            LISTAR_SALAS,
            LISTAR_ALUNOS
        };
        static void Main (string[] args) {

            int limiteAlunos = 5;
            int limiteSalas = 2;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];
            
            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            string[] itensMenu = Enum.GetNames(typeof(MenuEnum));

            bool querSair = false;
            do {
                Console.Clear ();
                string barraMenu = "===================================";
                System.Console.WriteLine (barraMenu);
                MostrarMensagem ("        *** SENAIzinho ***         ", TipoMensagemEnum.DESTAQUE);
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine (barraMenu);
                System.Console.WriteLine ("|| Digite uma opção:             ||");
                //body
                for (int i = 0; i < itensMenu.Length; i++) {
                    string espacosFim = "";
                    string bordaLinha = "||";
                    string paragrafoInicio = "   ";
                    string separadorOpcao = " - ";

                    string nomeTratado = itensMenu[i].Replace ("_", " ").ToLower ();
                    nomeTratado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (nomeTratado);
                    int espacoDezena = i / 10;
                    
                    string numeroOpcao = (i + 1).ToString();

                    if (espacoDezena < 1) {
                        paragrafoInicio = paragrafoInicio + " ";
                    }

                    int qntdeEspacos = barraMenu.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - nomeTratado.Length;

                    for (int j = 0; j < qntdeEspacos; j++) {
                        espacosFim += " ";
                    }
                    
                    System.Console.WriteLine ($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{nomeTratado}{espacosFim}{bordaLinha}");
                }
                //footer
                System.Console.WriteLine ("||    0 - Sair                   ||");
                System.Console.WriteLine (barraMenu);

                System.Console.Write ("Código: ");
                MenuEnum codigo = (MenuEnum) Enum.Parse (typeof(MenuEnum), (Console.ReadLine()));

                string mensagem = "";

                switch (codigo) {
                    case MenuEnum.CADASTRAR_ALUNO:
                        #region CADASTRO_ALUNOS
                        if (limiteAlunos != alunosCadastrados) {
                            System.Console.WriteLine ("Digite o nome do aluno");
                            Aluno aluno = new Aluno (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            aluno.Curso = ExibirMenuCursos ();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            MostrarMensagem ($"Cadastro de {aluno.GetType().Name} concluido", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de {alunos.GetType().Name} atingido!", TipoMensagemEnum.ERRO);
                        }
                        break;
                        #endregion 
                    case MenuEnum.CADASTRAR_SALA:
                        #region CADASTRO_SALAS

                        System.Console.WriteLine ("Digite o número da sala");
                        int NumeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite a capacidade total");
                        int CapacidadeTotal = int.Parse (Console.ReadLine ());

                        Sala sala = new Sala (NumeroSala, CapacidadeTotal);

                        sala.CapacidadeAtual = sala.CapacidadeTotal;

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        MostrarMensagem ("Cadastro de Sala concluído!", TipoMensagemEnum.SUCESSO);

                        break;
                        #endregion
                    case MenuEnum.ALOCAR_AUNO:
                        #region ALOCAR_ALUNO
                        if (!ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();
                        Aluno alunoRecuperado = ProcurarAlunoPorNome (alunos, nomeAluno);

                        if (alunoRecuperado == null) {
                            MostrarMensagem ($"Aluno {nomeAluno} não encontrado!", TipoMensagemEnum.ALERTA);

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSala = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRecuperada = ProcurarSalaPorNumero (salas, numeroSala);

                        if (salaRecuperada == null) {
                            MostrarMensagem ($"Sala {numeroSala} não encontrada!", TipoMensagemEnum.ALERTA);

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }
                        if (salaRecuperada.AlocarAluno (alunoRecuperado, out mensagem)) {
                            MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem (mensagem, TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    case MenuEnum.REMOVER_ALUNO:
                        #region REMOVER_ALUNO
                        if(ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas))
                        {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = ProcurarAlunoPorNome(alunos, nomeAlunoRemover);

                        if (alunoRemover == null) {
                            MostrarMensagem ($"Aluno {nomeAlunoRemover} não encontrado!", TipoMensagemEnum.ALERTA);
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = ProcurarSalaPorNumero(salas, numeroSalaRemover);

                        if (salaRemover == null) {
                            MostrarMensagem ($"Sala {numeroSalaRemover} não encontrada!", TipoMensagemEnum.ALERTA);

                        }
                        if (salaRemover.RemoverAluno(alunoRemover.Nome, out mensagem))
                        {
                            MostrarMensagem(mensagem, TipoMensagemEnum.SUCESSO);
                        }else
                        {
                            MostrarMensagem(mensagem, TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    case MenuEnum.LISTAR_SALAS:
                        #region VERIFICAR_SALAS
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.CapacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("\nAperte ENTER para exibir o menu principal");
                        Console.ReadLine ();
                        break;
                        #endregion
                    case MenuEnum.LISTAR_ALUNOS:
                        #region  VERIFICAR_ALUNOS
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                System.Console.WriteLine ($"Curso: {item.Curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("\nAperte ENTER para exibir o menu principal");
                        Console.ReadLine ();
                        break;
                        #endregion
                        
                        case 0 :
                        querSair = true;
                        MostrarMensagem("Até logo", TipoMensagemEnum.SUCESSO);
                        break;
                        
                        default:
                        MostrarMensagem("codifo invalido", TipoMensagemEnum.ERRO);
                        break;
                }

            } while (!querSair);
        }
        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                default:
                    break;
            }
            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("\nAperte ENTER para exibir o menu principal");
            Console.ReadLine ();
        }
        static bool ValidarAlocarOuRemover (int alunosCadastrados, int salasCadastradas) {
            if (alunosCadastrados == 0) {
                MostrarMensagem ("Não há alunos cadastrados!", TipoMensagemEnum.ALERTA);
                return false;
            }
            if (salasCadastradas == 0) {
                MostrarMensagem ("Não há salas cadastradas!", TipoMensagemEnum.ALERTA);
                return false;
            }
            return true;
        }
        static Aluno ProcurarAlunoPorNome (Aluno[] alunos, string nome) {
            foreach (Aluno item in alunos) {
                if (item != null && nome.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }
        static Sala ProcurarSalaPorNumero (Sala[] salas, int numero) {
            foreach (Sala item in salas) {
                if (item != null && numero.Equals (item.NumeroSala)) {
                    return item;
                }
            }
            return null;
        }
        static string ExibirMenuCursos () {

            bool cursoEscolhido = false;
            string curso = "";

            do {

                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Escolha uma opção de curso:   ||");
                System.Console.WriteLine ("||  1 - DESENVOLVIMENTO          ||");
                System.Console.WriteLine ("||  2 - REDES                    ||");
                System.Console.WriteLine ("===================================");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        curso = "DESENVOLVIMENTO";
                        cursoEscolhido = true;
                        break;
                    case 2:
                        curso = "REDES";
                        cursoEscolhido = true;
                        break;
                    default:
                        MostrarMensagem ("Esse codigo de curso nao existe", TipoMensagemEnum.ALERTA);
                        break;
                }

            } while (!cursoEscolhido);
            return curso;
        }
    }
}