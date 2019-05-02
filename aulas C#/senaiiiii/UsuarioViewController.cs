using System;
using senaiiiii.Repositorio;
using senaiiiii.Utils;

namespace senaiiiii {
    public class UsuarioViewController {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadastrarUsuario () {
            string nome, email, tipo, senha;

            do {
                System.Console.WriteLine ("Digite o seu nome:");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Digite o seu email (@ e .):");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidacaoEmail (email)) {
                    System.Console.WriteLine ("Email inválido, verifique se o seu email contem @ e .");
                }
            } while (!ValidacaoUtil.ValidacaoEmail (email));

            do {
                System.Console.WriteLine ("Digite se você é um usuário ou admininstrador");
                tipo = Console.ReadLine ();
                if (!ValidacaoUtil.ValidacaoTipo (tipo)) {
                    System.Console.WriteLine ("Digie um valor válido");
                }
            } while (!ValidacaoUtil.ValidacaoTipo (tipo));

            do {
                System.Console.WriteLine ("Digite uma senha com mais de 6 caractéres:");
                senha = Console.ReadLine ();
                if (!ValidacaoUtil.VaidacaoSenha (senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.VaidacaoSenha (senha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            usuarioRepositorio.Inserir (usuarioViewModel);

            System.Console.WriteLine ("Usuário cadastrado com sucesso!");
        }

        public static UsuarioViewModel LoginUsuario () {
            string email, senha;
            do
            {
                System.Console.WriteLine("Insira o email: ");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidacaoEmail (email)) {
                    System.Console.WriteLine ("Email inválido, verifique se o seu email contem @ e .");
                }
                
            } while (!ValidacaoUtil.ValidacaoEmail (email));

            do
            {
                System.Console.WriteLine("Insira a senha:");
                senha = Console.ReadLine();
                if (!ValidacaoUtil.VaidacaoSenha(senha))
                {
                    System.Console.WriteLine("Senha inválida");   
                }
            } while (!ValidacaoUtil.VaidacaoSenha(senha));

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario (email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                Console.WriteLine ("Email ou senha inválida");
                return null;
            }
        }
    }
}