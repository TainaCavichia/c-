using System;
using Senaizinho_2_Manha.enuns;

namespace Senaizinho_2_Manha {
    class Program {
        static void Main (string[] args) {

            int limiteAlunos = 5;
            int limiteSalas = 2;
            int limiteProfessore = 2;
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

                switch (codigo) {
                    #region CADASTRO_ALUNOS
                    case 1:
                        if (limiteAlunos != alunosCadastrados) {
                            Aluno aluno = new Aluno ();

                            System.Console.WriteLine ("Digite o nome do aluno");
                            aluno.nome = Console.ReadLine ();

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.dataNascimento = DateTime.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite o nome do curso");
                            aluno.curso = Console.ReadLine ();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            MostrarMensagem ($"Cadastro de {aluno.GetType().Name} concluido", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de {alunos.GetType().Name} atingido!", TipoMensagemEnum.ERRO);
                        }
                        break;
                        #endregion 
                    case 2:
                        Sala sala = new Sala ();

                        System.Console.WriteLine ("Digite o número da sala");
                        sala.numeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite a capacidade total");
                        sala.capacidadeTotal = int.Parse (Console.ReadLine ());

                        sala.capacidadeAtual = sala.capacidadeTotal;

                        sala.alunos = new string[sala.capacidadeTotal];

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        MostrarMensagem ("Cadastro de Sala concluído!", TipoMensagemEnum.SUCESSO);

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case 3:

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
                        MostrarMensagem (salaRecuperada.AlocarAluno (alunoRecuperado.nome), TipoMensagemEnum.DESTAQUE);

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case 4:

                        ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas);

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = null;

                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoRemover.Equals (item.nome)) {
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
                            if (item != null && numeroSalaRemover.Equals (item.numeroSala)) {
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

                        MostrarMensagem (salaRemover.RemoverAluno (alunoRemover.nome), TipoMensagemEnum.DESTAQUE);

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;
                    case 5:
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

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
                if (item != null && nome.Equals (item.nome)) {
                    return item;
                }
            }
            return null;
        }
        static Sala ProcurarSalaPorNumero (Sala[] salas, string numero) {
            foreach (Sala item in salas) {
                if (item != null && numero.Equals (item.numeroSala)) {
                       return item;
                }
            }
            return null;
        }
    }
}