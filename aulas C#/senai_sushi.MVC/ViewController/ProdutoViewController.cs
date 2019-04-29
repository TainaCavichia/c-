using System;
using senai_sushi.MVC.Repositorio;
using senai_sushi.MVC.Utils;
using senai_sushi.MVC.ViewModel;

namespace senai_sushi.MVC.ViewController {
    public class ProdutoViewController {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto () {
            string descricao, categoria;
            float preco;

            do {
                System.Console.WriteLine ("Digite uma breve descrição do produto:");
                descricao = Console.ReadLine ();

                if (string.IsNullOrEmpty (descricao)) {
                    Console.WriteLine ("Insira a descrição!");
                }

            } while (string.IsNullOrEmpty (descricao));

            do {
                System.Console.WriteLine ("Digite a categoria do produto (Bebida ou Pizza):");
                categoria = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarCategoria (categoria)) {
                    System.Console.WriteLine ("Categoria inválida");
                }
            } while (!ValidacaoUtil.ValidarCategoria (categoria));

            System.Console.WriteLine ("Insira o preço do produto:");
            preco = float.Parse (Console.ReadLine ());

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Categoria = categoria;
            produtoViewModel.Preco = preco;

            //aramzenar no repositorio

            System.Console.WriteLine("Cadastro realizado com sucesso!");
        }
    }
}