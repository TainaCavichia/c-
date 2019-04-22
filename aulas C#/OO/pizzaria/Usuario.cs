using System;

namespace pizzaria
{
    class Usuario
    {
        static Usuario[] arrayDeUsuarios = new Usuario[1000];
        static public int contador = 0;
        public int Id {get; set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataCriação {get;set;}

        public static void Inserir(){
            string nome;
            string email;
            string senha;

            System.Console.WriteLine("Digite o nome de usuário:");
            nome = Console.ReadLine();
        do{
            System.Console.WriteLine("Digite o email do usuário:");
            email = Console.ReadLine();
            if(!email.Contains("@") || !email.Contains(".")){
                System.Console.WriteLine("Email inválido");
            }
            } while (!email.Contains ("@") || !email.Contains ("."));

            do{
                System.Console.WriteLine("Digite a Senha:");
                senha = Console.ReadLine();
                
                if(senha.Length < 6){
                    System.Console.WriteLine("Senha inválida, digite no minimo 6 caracteres");
                }
            }while(senha.Length < 6);

            arrayDeUsuarios[contador] = new Usuario();
            arrayDeUsuarios[contador].Id = contador + 1;
            arrayDeUsuarios[contador].Nome = nome;
            arrayDeUsuarios[contador].Email = email;
            arrayDeUsuarios[contador].Senha = senha;
            arrayDeUsuarios[contador].DataCriação = DateTime.Now;
        }

        public static void Listar(){
            foreach (var item in arrayDeUsuarios)
            {
                if (item == null)
                {
                    break;
                }
                System.Console.WriteLine($"Usuário: {item.Nome}");
                
            }
        }
           
    }
}
