using System;
using Senaizinho_2_Manha.enuns;

namespace Senaizinho_2_Manha {
    class Program {
        static void Main (string[] args) {

            int limiteAlunos = 5;
            int limiteSalas = 2;
            // int limiteProfessores = 2;
            Aluno[] alunos = new Aluno[limiteAlunos];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[limiteSalas];
            int salasCadastradas = 0;

            bool querSair = false;
            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                MostrarMensagem ("        *** SENAIzinho ***         ", TipoMensagemEnum.DESTAQUE);
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write ("Código: ");
                int codigo = int.Parse (Console.ReadLine ());

                string mensagem = "";

                switch (codigo) {
                    case 1:
                        #region CADASTRO_ALUNOS
                        if (limiteAlunos != alunosCadastrados) {
                            System.Console.WriteLine ("Digite o nome do aluno");
                            Aluno aluno = new Aluno (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite o nome do curso");
                            aluno.Curso = Console.ReadLine ();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            MostrarMensagem ($"Cadastro de {aluno.GetType().Name} concluido", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de {alunos.GetType().Name} atingido!", TipoMensagemEnum.ERRO);
                        }
                        break;
                        #endregion 
                    case 2:
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

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                        #endregion
                    case 3:
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

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                        #endregion
                    case 4:
                        #region REMOVER_ALUNO
                        ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas);

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = null;

                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoRemover.Equals (item.Nome)) {
                                alunoRemover = item;
                                break;
                            }
                        }

                        if (alunoRemover == null) {
                            MostrarMensagem ($"Aluno {nomeAlunoRemover} não encontrado!", TipoMensagemEnum.ALERTA);

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRemover.Equals (item.NumeroSala)) {
                                salaRemover = item;
                                break;
                            }
                        }

                        if (salaRemover == null) {
                            MostrarMensagem ($"Sala {numeroSalaRemover} não encontrada!", TipoMensagemEnum.ALERTA);

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }

                        break;
                        #endregion
                    case 5:
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

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                        #endregion
                    case 6:
                        #region  VERIFICAR_ALUNOS
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                System.Console.WriteLine ($"Curso: {item.Curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;
                        #endregion
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

            System.Console.WriteLine ("\nAperte ENTER para voltar ao menu principal");
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
    }
}