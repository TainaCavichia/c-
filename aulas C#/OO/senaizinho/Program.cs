using System;

namespace senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;
            bool repetir = true;
            int cont = 0;

            Aluno[] Alunos = new Aluno[4];
            Salas[] salas = new Salas[1];

            do
            {
                Console.WriteLine("---------------------Escolha uma opção---------------------");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Sala");
                Console.WriteLine("3 - Alocar Aluno");
                Console.WriteLine("4 - Remover Aluno");
                Console.WriteLine("5 - Verificar Salas");
                Console.WriteLine("6 - Verificar Alunos");
                Console.WriteLine("0 - Sair");


                switch (escolha)
                {
                    case 1:

                        Console.WriteLine("Digite o nome do aluno:");
                        Alunos[cont].nome = Console.ReadLine();

                        Console.WriteLine("Digite a data de nascimento do aluno:");
                        Alunos[cont].dataNascimento = DateTime.Parse(System.Console.ReadLine());

                        Console.WriteLine("Digite o seu curso:");
                        Alunos[cont].curso = Console.ReadLine();

                        Console.WriteLine("Digite o numero da sala:");
                        Alunos[cont].numeroSala = int.Parse(Console.ReadLine());

                        cont++;

                        break;

                    case 2:

                        Console.WriteLine("Digite o numero da sala:");
                        salas[0].numeroSala = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a capacidade de alunos:");
                        salas[0].capacidadeAtual = int.Parse(Console.ReadLine());

                        Console.WriteLine("");
                        salas[0].alunos = Console.ReadLine();

                        break;

                }

            }while (repetir) ;
    }
    }
}

