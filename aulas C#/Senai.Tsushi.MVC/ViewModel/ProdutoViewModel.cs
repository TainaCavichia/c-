using System;

namespace Senai.Tsushi.MVC.ViewModel
{
    public class ProdutoViewModel : BaseViewModel
    {
        public string Descricao {get; set;}
        public float Preco {get; set;}
        public string Categoria {get; set;}
    }
}