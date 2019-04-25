using System;
namespace Senaizinho_2_Manha
{
    public class Aluno
    {
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int NumeroSala {get; set;}

        public Aluno(string nome)
        {
            this.Nome = nome;
        }
    }
}