using System;
using System.Collections.Generic;
using FinancaDeMesa.Enums;
using FinancaDeMesa.Repositorios;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();
        public static void CadastrarUsuario()
        {
            string nome, email, senha, confirmacaoSenha;
            DateTime dataDeNascimento;

            do
            {
                System.Console.WriteLine("Digite o nome do usuário:");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    MensagemUtils.MostrarMensagem("Nome inválido",Cores.ERRO);
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Digite o Email do usuário:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    MensagemUtils.MostrarMensagem("Email inválido", Cores.ERRO);
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Digite a senha do usuário:");
                senha = Console.ReadLine();
                System.Console.WriteLine("Confirme a senha:");
                confirmacaoSenha = Console.ReadLine();
                
                if (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmacaoSenha))
                {
                    MensagemUtils.MostrarMensagem("Senha inválida", Cores.ERRO);
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmacaoSenha));

            do
            {
                System.Console.WriteLine("Digite a data de nascimento do usuário:");
                dataDeNascimento = DateTime.Parse(Console.ReadLine());
                if (dataDeNascimento > DateTime.Now)
                {
                    MensagemUtils.MostrarMensagem("Data de nascimento inválida", Cores.ERRO);
                }
            } while (dataDeNascimento > DateTime.Now);


            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.Saldo = 0;
            usuario.DataDenascimento = dataDeNascimento;
            usuarioRepositorio.Inserir(usuario);
            
            MensagemUtils.MostrarMensagem("Usuário cadastrado com sucesso", Cores.SUCESSO);
        }
    
        public static UsuarioViewModel Login()
        {
            string email,senha;

            do
            {
                System.Console.WriteLine("Email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    MensagemUtils.MostrarMensagem("Email inválido", Cores.ERRO);
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.WriteLine("Senha:");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.ProcurarUsuario(email, senha);
            if(usuarioRecuperado != null)
            {
                return usuarioRecuperado;    
            } else
            {
                MensagemUtils.MostrarMensagem("Email ou senha inválidos",Cores.ERRO);
                return null;
            }        
        }

        public static void Relatorio(UsuarioViewModel usuario)
        {
            List<UsuarioViewModel> listaDeUsuarios = UsuarioRepositorio.Listar();
            List<TransacaoViewModel> listaDeTransacoes = transacaoRepositorio.ListarTransacoes();
            TransacaoRepositorio.FazerRelatorioUsuarios(listaDeUsuarios);
            TransacaoRepositorio.FazerRelatorioTransacoes(listaDeTransacoes, usuario);
        }
    }
}