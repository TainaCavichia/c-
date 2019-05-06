using System;
using To_Do.Enums;
using To_Do.Modelos;
using To_Do.Repositorio;

namespace To_Do.Controle {
    public class ControleUsuario {
    static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        public static void CadastrarUsuario () {
            string email, nome, tipo, senha, confirmacao;

            System.Console.WriteLine ("Digite seu nome:");
            nome = Console.ReadLine ();
            System.Console.WriteLine ("Digite seu e-mail:");
            email = Console.ReadLine ();
            System.Console.WriteLine ("Tipo de Usuário: (simples/administrador)");
            tipo = Console.ReadLine ();
            System.Console.WriteLine ("Digite sua senha: (6 ou mais dígitos)");
            senha = Console.ReadLine ();
            System.Console.WriteLine ("Confirme sua senha:");
            confirmacao = Console.ReadLine ();

            ModeloUsuario modelousuario = new ModeloUsuario ();
            modelousuario.Nome = nome;
            modelousuario.Email = email;
            modelousuario.Senha = senha;
            modelousuario.Tipo = tipo;


            usuarioRepositorio.Inserir (modelousuario);

            MostrarMensagem ("Cadastro realizado com sucesso", TipoMensagemEnum.SUCESSO);
        }
        public static ModeloUsuario EfetuarLogin () {
            string email, senha;

            System.Console.WriteLine ("Digite seu email");
            email = Console.ReadLine ();
            System.Console.WriteLine ("Digite a senha");
            senha = Console.ReadLine ();

            ModeloUsuario usuarioRecuperado = usuarioRepositorio.BuscarUsuario (email, senha);
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
            Console.ResetColor ();
        }
    }
}