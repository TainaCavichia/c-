using System;
using System.Collections.Generic;
using Senai.Tsushi.MVC.Enums;
using Senai.Tsushi.MVC.Repositorio;
using Senai.Tsushi.MVC.Utils;
using Senai.Tsushi.MVC.ViewModel;

namespace Senai.Tsushi.MVC.ViewController {
    public class UsuarioViewController {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;
            do {
                System.Console.WriteLine ("Digite o nome do usuário");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    MostrarMensagem ("Nome inválido", TipoMensagemEnum.ALERTA);

                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Digite o E-mail do usuário");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    MostrarMensagem ("Email inválido, o email deve conter @ e .", TipoMensagemEnum.ALERTA);
                }

            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Digite a senha do usuário (Pelo menos 7 dígitos)");
                senha = Console.ReadLine ();

                System.Console.WriteLine ("Confirme a senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha)) {
                    MostrarMensagem ("\n As senhas não são iguais ou não contém pelo menos 7 dígitos", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha));

            //Cria um objeto do tipo usuário
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Ter um metodo para inserir o bnco de dados
            usuarioRepositorio.Inserir (usuarioViewModel);
            MostrarMensagem ("\nCadastro efetuado com sucesso", TipoMensagemEnum.SUCESSO);
        } //fim cadastrarusuario

        public static void ListarUsuario () {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar ();
            foreach (var item in listaDeUsuarios) {
                System.Console.WriteLine ($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data: {item.Data}");
            }
            MostrarMensagem ("Clique ENTER para continuar", TipoMensagemEnum.DESTAQUE);
            Console.ReadLine ();

        }
        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                System.Console.WriteLine ("Digite seu email");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    MostrarMensagem ("Digite um e-mail válido", TipoMensagemEnum.ALERTA);
                }
            } while (!ValidacaoUtil.ValidarEmail (email));
            System.Console.WriteLine ("Digite a senha");
            senha = Console.ReadLine ();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario (email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                    MostrarMensagem ("E-mail ou senha inválidos", TipoMensagemEnum.ALERTA);
                return null;
            }
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
        }
    }
}