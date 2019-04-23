using System;

namespace DesafioPizzaria {
    public class Usuario {
        static Usuario[] arrayDeUsuario = new Usuario[1000];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataCriacao { get; set; }

        public static void Inserir () {
            string nome;
            string email;
            string senha;

            Console.WriteLine ("Digite o nome do Usuário:");
            nome = Console.ReadLine ();

            do {
                Console.WriteLine ("Digite o Email do Usuário");
                email = Console.ReadLine ();
                if (!email.Contains ("@") || !email.Contains (".")) {
                    Console.WriteLine ("Email inválido");
                }
            } while (!email.Contains ("@") || !email.Contains ("."));

            do {
                Console.WriteLine ("Digite a senha:");
                senha = Console.ReadLine ();

                if (senha.Length < 6) {
                    Console.WriteLine ("Senha Inválida, digite ao menos 6 caracteres");
                }
            } while (senha.Length < 6);

            // Usuario usuario = new Usuario();
            // usuario.Id = contador + 1;
            // usuario.Nome =  nome;
            // usuario.Email = email;
            // usuario.Senha = senha;
            // usuario.DataCriacao = DateTime.Now;
            // arrayDeUsuario[contador] = usuario;

            arrayDeUsuario[contador] = new Usuario ();
            arrayDeUsuario[contador].Id = contador + 1;
            arrayDeUsuario[contador].Nome = nome;
            arrayDeUsuario[contador].Email = email;
            arrayDeUsuario[contador].Senha = senha;
            arrayDeUsuario[contador].DataCriacao = DateTime.Now;
            contador++;

        } //fim metodo inserir
        public static void EfetuarLogin () {
            string email;
            string senha;

            
            Console.WriteLine ("Digite o email do usuário:");
            email = Console.ReadLine ();

            Console.WriteLine ("Digite a senha:");
            senha = Console.ReadLine ();

            foreach (var item in arrayDeUsuario) {
                if (item != null) {

                    if (email.Equals (item.Email) && senha.Equals (item.Senha)) {
                        Console.WriteLine ($"Seja Bem Vindo - {item.Nome}");
                        return;
                    } else {
                        Console.WriteLine ("Email ou Senha icorretos");
                    }
                }
            }

        }
        public static void Listar () {
            foreach (var item in arrayDeUsuario) {
                if (item == null) {
                    break;
                }
                Console.WriteLine ($"Id: {item.Id} Usuário: {item.Nome}");

            }
        }
    }
}