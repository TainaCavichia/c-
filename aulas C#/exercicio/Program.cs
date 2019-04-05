using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            Console.WriteLine("Aplicação - Criando menus");

            while (repetir)
            {
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1 - Efetuar Login");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Listar Comentários");
                Console.WriteLine("9 - Sair");
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:

                    Console.WriteLine("Digite seu usuario");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite sua senha");
                    string senha = Console.ReadLine();
                    if (senha == "1234")
                    {
                        Console.WriteLine("Bem vindo (a) - {0}",usuario);
                    }else
                    {
                        Console.WriteLine("senha invalida");
                    }
                    break;

                    case 2:

                    Console.WriteLine("Carlos - 73362828");
                    Console.WriteLine("Cesar - 9866788");
                    break;

                    case 3:

                    Console.WriteLine("Adorei o programa");
                    Console.WriteLine("Incrivel");
                    break;

                    case 9:
                    repetir = false;
                    break;

                    default: 
                    Console.WriteLine("Valor invalido");
                    break;
                }

            }//fim while
        }
    }
}
