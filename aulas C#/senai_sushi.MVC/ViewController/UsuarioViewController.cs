using System;
using System.Collections.Generic;
using senai_sushi.MVC.Repositorio;
using senai_sushi.MVC.Utils;
using senai_sushi.MVC.ViewModel;

namespace senai_sushi.MVC.ViewController {
    public class UsuarioViewController {
        //instanciar o repositorio
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public static void CadastrarUsuario () {

            string nome, email, senha, confirmaSenha;

            do {
                System.Console.WriteLine ("Digite o nome do usuário:");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    Console.WriteLine ("Nome inválido");
                }

            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Digite o e-mail do usuário:");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("E-mail inválido, o e-mail deve conter @ e .");
                }

            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Digite a senha do usuário");
                senha = Console.ReadLine ();

                System.Console.WriteLine ("Confirme a senha:");
                confirmaSenha = Console.ReadLine ();
                if (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha)) {
                    System.Console.WriteLine ("As senhas não são iguais");
                }

            } while (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha));

            //Cria um objeto do tipo usuario

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Ter um metodo para inserir no banco de dados
            usuarioRepositorio.Inserir (usuarioViewModel);

            System.Console.WriteLine ("Cadastro efetuado com sucesso!");

        } //fim cadastrar usuario

        public static void ListarUsuario () {

            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar ();
            foreach (var item in listaDeUsuarios) {
                System.Console.WriteLine ($"Id: {item.Id}\n Nome: {item.Nome}\n Email: {item.Email}\n Data de Criação: {item.DataCriacao}");
            }
        } // fim da listagem

        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;

            do {
                System.Console.WriteLine ("Insira o email:");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("Email imválido, o emil deve conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            System.Console.WriteLine ("Insira a senha:");
            senha = Console.ReadLine ();

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