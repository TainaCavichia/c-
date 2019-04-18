using System;

namespace senaizinho
{
    class Aluno
    {
        public string nome;

        public DateTime dataNascimento;

        public string curso;

        public int numeroSala;

        public string alocarAlunos;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public DateTime getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public string getCurso()
        {
            return this.curso;
        }

    }
}
