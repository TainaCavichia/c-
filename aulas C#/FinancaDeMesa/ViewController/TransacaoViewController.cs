using System;
using System.Collections.Generic;
using FinancaDeMesa.Enums;
using FinancaDeMesa.Repositorios;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.ViewController {
    public class TransacaoViewController {
        public static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio ();
        public static void CadastrarTransacao (ref UsuarioViewModel usuario) {
            string descricao;
            string tipo = "";
            int escolha;
            DateTime dataTransacao;
            double valor;
            // double saldoNovo;
            // double despesas = 0;
            // double receitas = 0;

            do {
                MenuUtils.MenuTipoTransacao ();
                escolha = int.Parse (Console.ReadLine ());

            } while (escolha != 1 && escolha != 2);

            do {
                System.Console.WriteLine ("Descreva essa transação:");
                descricao = Console.ReadLine ();
                if (string.IsNullOrEmpty (descricao)) {
                    MensagemUtils.MostrarMensagem ("A transação deve conter uma descrição", Cores.ALERTA);
                }
            } while (string.IsNullOrEmpty (descricao));

            do {
                System.Console.WriteLine ("Digite a data dessa transação:");
                dataTransacao = DateTime.Parse (Console.ReadLine ());
            } while (dataTransacao == null);

            do {
                System.Console.WriteLine ("Digite o valor dessa transação:");
                System.Console.Write ("R$");
                valor = double.Parse (Console.ReadLine ());

            } while (valor <= 0);

            switch (escolha) {
                case 1:
                    tipo = "DESPESA";
                    // despesas += valor;
                    break;
                case 2:
                    tipo = "RECEITA";
                    // receitas += valor;
                    break;
            }
            // saldoNovo = receitas - despesas;

            TransacaoViewModel transacao = new TransacaoViewModel ();
            transacao.Tipo = tipo;
            transacao.Descricao = descricao;
            transacao.DataTransacao = dataTransacao;
            transacao.Valor = valor;
            // usuario.Saldo = saldoNovo;
            transacao.Nome = usuario.Nome;

            transacaoRepositorio.InserirTransacao (transacao);
            transacaoRepositorio.MudarSaldo (usuario, transacao);

            MensagemUtils.MostrarMensagem ("Transação cadastrada com sucesso!", Cores.SUCESSO);

        }
        public static void ListarTransacoes (UsuarioViewModel usuario) {
            List<TransacaoViewModel> listaDeTransacoes = transacaoRepositorio.ListarTransacoes ();
            if (listaDeTransacoes.Count == 0) {
                MensagemUtils.MostrarMensagem ("Ainda não há transações cadastradas no sistema", Cores.ALERTA);
            }

            foreach (var item in listaDeTransacoes) {
                if (item != null && item.Nome.Equals (usuario.Nome)) {
                    System.Console.WriteLine ("\n============================");
                    System.Console.WriteLine ($"{item.Tipo} de R${item.Valor}");
                    System.Console.WriteLine ($"No dia {item.DataTransacao:dd/MM/yyyy}");
                    System.Console.WriteLine ($"Descrição: {item.Descricao}");
                    System.Console.WriteLine ("============================");

                }
            }
            System.Console.WriteLine ($"Saldo: R${usuario.Saldo}");
            System.Console.WriteLine ("============================");
        }
    

    }
}