using System;

namespace DesafioPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bem vindo a Pizzaria do Tsukamoto");
           int escolha = 0;
           do{
               
               Console.WriteLine("1 -- Cadastrar Usuário");
               Console.WriteLine("2 -- Login");
               Console.WriteLine("3 -- Listar Usuário");
               Console.WriteLine("9 - Sair");
               escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    //Cadastro do usuário
                         Usuario.Inserir();
                    // Usuario.Listar();
                    break;
                    case 2:
                    // Efetuar login
                    Usuario.EfetuarLogin();
                        //Colocar o segundo Menu
                        escolha = 0;
                        do
                        {
                            Console.WriteLine("Selecione uma opção:");
                            Console.WriteLine("1 - Cadastrar Produto");
                            Console.WriteLine("2 - Listar Produti");
                            Console.WriteLine("3 - Buscar por ID");
                            Console.WriteLine("9 - Sair");
                            escolha = int.Parse(Console.ReadLine());

                            switch (escolha)
                            {
                                case 1:
                                // Cadastrar produto
                                Produto.CadastrarProduto();
                                break;

                                case 2:
                                //Listar Produtos
                                Produto.ListarProduto();

                                break;
                                case 3:
                                //Listar por id
                                Produto.BuscaPorId();

                                break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                break;
                            }


                        } while (escolha != 9);
                        
                    break;
                    case 3:
                    // Listar Usuarios
                    Usuario.Listar();
                    break;
                    case 9:
                    // Sair do sistema
                    break;
                    
                    default:
                        Console.WriteLine("Valor inválido");
                    break;
                }

           }while(escolha != 9);

        
        }
    }
}
