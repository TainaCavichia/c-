using System;
using System.Collections.Generic;
using Senai.Tsushi.MVC.ViewModel;

namespace Senai.Tsushi.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();

        /// <summary>Método responsável por armazenar um usuário</summary>
        public ProdutoViewModel Inserir(ProdutoViewModel produto)
        {
            produto.Id = listaDeProdutos.Count + 1;
            produto.Data = DateTime.Now;
            //insere o objeto usuario dentro da lista
            listaDeProdutos.Add(produto);
            return produto;
        }
        /// <summary>Retorna lista de usuários</summary>
        public List<ProdutoViewModel> Listar ()
        {
            return listaDeProdutos;
        }

        /// <summary>Verifica se o usuário é válido</summary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna o usuário caso seja encontrado e null caso não exista</returns>
        public ProdutoViewModel BuscarProduto(int id)
        {
            foreach (var item in listaDeProdutos)
            {
                if (item.Id.Equals(id))
                {
                    return item;
                }
            }
                return null;
        }
    }
}