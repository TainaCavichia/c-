using System;

namespace senaizinho {
    class Program {
        static void Main (string[] args) {
            int escolha = 0;
            bool repetir = true;
            int AlunosCadastrados = 0;
            int SalasCadastradas = 0;

            Aluno[] Alunos = new Aluno[4];
            Sala[] Salas = new Sala[2];

            do {
                Console.Clear();
                Console.WriteLine ("---------------------Escolha uma opção---------------------");
                Console.WriteLine ("1 - Cadastrar Aluno");
                Console.WriteLine ("2 - Cadastrar Sala");
                Console.WriteLine ("3 - Alocar Aluno");
                Console.WriteLine ("4 - Remover Aluno");
                Console.WriteLine ("5 - Verificar Salas");
                Console.WriteLine ("6 - Verificar Alunos");
                Console.WriteLine ("0 - Sair");
                Console.WriteLine ("-----------------------------------------------------------");
                escolha = int.Parse (Console.ReadLine ());

                switch (escolha) {
                    case 1:

                        Aluno p = new Aluno ();

                        Console.WriteLine ("Digite o nome do aluno:");
                        p.setNome (Console.ReadLine ());

                        Console.WriteLine ("Digite a data de nascimento do aluno:");
                        p.setDataNascimento (DateTime.Parse (System.Console.ReadLine ()));

                        Console.WriteLine ("Digite o seu curso:");
                        p.setCurso (Console.ReadLine ());

                        Alunos[AlunosCadastrados] = p;
                        AlunosCadastrados++;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine ("Aluno cadastrado com sucesso");
                        Console.ResetColor ();

                        Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;
                    case 2:

                        Sala a = new Sala ();

                        Console.WriteLine ("Digite o numero da sala:");
                        a.setNumeroSala (int.Parse (Console.ReadLine ()));

                        Console.WriteLine ("Digite a capacidade de alunos:");
                        a.setCapacidadeTotal (int.Parse (Console.ReadLine ()));

                        a.capacidadeAtual = a.capacidadeTotal;
                        a.alunos = new string[a.capacidadeTotal];

                        Salas[SalasCadastradas] = a;
                        SalasCadastradas++;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine ("Sala cadastrada com sucesso");
                        Console.ResetColor ();

                        Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case 3:
                        if (AlunosCadastrados == 0) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine ("Nenhum aluno cadastrado");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        } else if (SalasCadastradas == 0) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine ("Nenhuma sala cadastrada");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        Console.WriteLine ("Digite o nome do aluno:");
                        string nomeAluno = Console.ReadLine ();

                        Aluno alunoRecuperado = null;

                        foreach (var item in Alunos) {
                            if (item != null && nomeAluno.Equals (item.nome)) {
                                alunoRecuperado = item;
                                break;
                            }
                        }
                        if (alunoRecuperado == null) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine ($"Aluno {nomeAluno} não encontrado");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }
                        Console.WriteLine ("Digite o numero da sala:");
                        int numeroSala = int.Parse (Console.ReadLine ());

                        Sala salaRecuperada = null;
                        foreach (var item in Salas) {
                            if (item != null && numeroSala.Equals (item.numeroSala)) {
                                salaRecuperada = item;
                                break;
                            }
                        }
                        if (salaRecuperada == null) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine ($"Sala {numeroSala} não encontrado");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;

                        }
                        Console.WriteLine (salaRecuperada.AlocarAluno (alunoRecuperado.nome));

                        break;
                    case 5:
                        foreach (var item in Salas) {
                            if (item != null) {
                                Console.WriteLine ($"-----------------------------------------");
                                Console.WriteLine ($"Numero da sala: {item.numeroSala}");
                                Console.WriteLine ($"Vagas disponiveis: {item.capacidadeAtual}");
                                Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                Console.WriteLine ($"-----------------------------------------");
                            }
                        }
                        break;
                    case 6:

                        foreach (var item in Alunos) {
                            if (item != null) {
                                Console.WriteLine ($"-----------------------------------------");
                                Console.WriteLine ($"Nome do aluno {item.nome}");
                                Console.WriteLine ($"Curso: {item.curso}");
                                Console.WriteLine ($"-----------------------------------------");
                            }
                        }
                        break;
                }
            } while (repetir);
        }
    }
}