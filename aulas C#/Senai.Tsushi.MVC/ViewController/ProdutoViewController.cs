using System;
using System.Collections.Generic;
using Senai.Tsushi.MVC.Enums;
using Senai.Tsushi.MVC.Repositorio;
using Senai.Tsushi.MVC.Utils;
using Senai.Tsushi.MVC.ViewModel;

namespace Senai.Tsushi.MVC.ViewController {
    public class ProdutoViewController {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio ();
        public static void CadastrarProduto () {
            string nome, descrição, categoria;
            float preco;
            do {
                System.Console.WriteLine ("Digite o nome do produto");
                nome = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty (nome)) {
                    MostrarMensagem ("Nome inválido", TipoMensagemEnum.ALERTA);
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Digite o descrição do produto");
                descrição = Console.ReadLine ();
                if (string.IsNullOrEmpty (descrição)) {
                    MostrarMensagem ("Descrição inválida", TipoMensagemEnum.ALERTA);
                }
            } while (string.IsNullOrEmpty (descrição));

            System.Console.WriteLine ("Digite o preço do produto");
            preco = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Qual a categoria do produto?");
            categoria = Console.ReadLine ();

            //Cria um objeto do tipo produto
            ProdutoViewModel produtoViewModel = new ProdutoViewModel ();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descrição;
            produtoViewModel.Preco = preco;
            produtoViewModel.Categoria = categoria;

            //Ter um metodo para inserir o bnco de dados
            produtoRepositorio.Inserir (produtoViewModel);
            MostrarMensagem ("Cadastro efetuado com sucesso", TipoMensagemEnum.SUCESSO);

            MostrarMensagem ("Clique ENTER para continuar", TipoMensagemEnum.DESTAQUE);
            Console.ReadLine ();

        } //fim cadastrarproduto

        public static void ListarProdutos () {
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar ();
            foreach (var item in listaDeProdutos) {
                System.Console.WriteLine ($"-----------------------------------\nId: {item.Id}\nNome: {item.Nome}\nDescrição: {item.Descricao}\nPreço: {item.Preco}\nCategoria: {item.Categoria}\n-----------------------------------");
            }
            MostrarMensagem ("Clique ENTER para continuar", TipoMensagemEnum.DESTAQUE);
            Console.ReadLine ();
        }
        public static ProdutoViewModel BuscarporId () {
            int id;

            System.Console.WriteLine ("Digite seu id");
            id = int.Parse (Console.ReadLine ());

            ProdutoViewModel produtoRecuperado = produtoRepositorio.BuscarProduto (id);
            if (produtoRecuperado != null) {
                return produtoRecuperado;
            } else {
                MostrarMensagem ("Id inválido", TipoMensagemEnum.ALERTA);
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