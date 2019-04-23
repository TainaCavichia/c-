using System;

namespace pizzaria {
    public class Produto {
        static Produto[] arrayDeProdutos = new Produto[1000];
        static public int cont = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        public static void Cadastrar () {
            string nome;
            string descricao;
            float preco;
            string categoria;

            System.Console.WriteLine ("Digite o nome do produto:");
            nome = Console.ReadLine ();

            System.Console.WriteLine ("Faça uma breve descrição do produto:");
            descricao = Console.ReadLine ();

            System.Console.WriteLine ("Digite o preço do produto");
            preco = float.Parse (Console.ReadLine ());

            do {
                System.Console.WriteLine ("Digite a categoria do produto (Pizza ou Bebida)");
                categoria = Console.ReadLine ();

            } while (!categoria.Equals ("Bebida") && !categoria.Equals ("Pizza"));

            arrayDeProdutos[cont] = new Produto ();
            arrayDeProdutos[cont].Id = cont + 1;
            arrayDeProdutos[cont].Nome = nome;
            arrayDeProdutos[cont].Descricao = descricao;
            arrayDeProdutos[cont].Preco = preco;
            arrayDeProdutos[cont].Categoria = categoria;
            cont++;
        }
        public static void Listar () {
            foreach (var item in arrayDeProdutos) {
                if (item == null) {
                    break;
                }
                System.Console.WriteLine ("===========================");
                System.Console.WriteLine ($"Id: {item.Id}");
                System.Console.WriteLine ($"Nome: {item.Nome}");
                System.Console.WriteLine ($"Preço: {item.Preco}");
                System.Console.WriteLine ("===========================");
            }
        }
        public static void BuscaPorId () {
            int id;
            System.Console.WriteLine ("Insira o Id do produto para mais informações:");
            id = int.Parse (Console.ReadLine ());

            foreach (var item in arrayDeProdutos) {
                if (item != null) {
                    if (id.Equals (item.Id)) {
                        System.Console.WriteLine ("===========================");
                        System.Console.WriteLine ($"Id: {item.Id}");
                        System.Console.WriteLine ($"Nome: {item.Nome}");
                        System.Console.WriteLine ($"Descrição: {item.Descricao}");
                        System.Console.WriteLine ($"Preço: {item.Preco}");
                        System.Console.WriteLine ($"Categoria: {item.Categoria}");
                        System.Console.WriteLine ($"Data de criação: {item.DataCriacao}");
                        System.Console.WriteLine ("===========================");

                    } else {
                        System.Console.WriteLine ("Id é inválido");
                    }
                }
            }
        }
    }
}