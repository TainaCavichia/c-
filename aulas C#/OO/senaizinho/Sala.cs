using System;

namespace senaizinho {
    class Sala {

        public int numeroSala;

        public int capacidadeTotal;

        public int capacidadeAtual;

        public string[] alunos;

        public string AlocarAluno (string nomeAlunos) {
            capacidadeAtual--;
            if (capacidadeAtual >= 0) {

                alunos[capacidadeAtual] = nomeAlunos;
                return $"Aluno {nomeAlunos} alocado com sucesso";
            } else {
                capacidadeAtual = 0;
                return $"Capacidade da sala {numeroSala} exercida";
            }
        }
        public string ExibirAlunos()
        {
            string nomesAlunos = "";
            foreach (var item in alunos)
            {
                if (item != null)
                {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

        public void setNumeroSala (int numeroSala) {
            this.numeroSala = numeroSala;
        }
        public int getNumeroSala () {
            return this.numeroSala;
        }
        public void setCapacidadeTotal (int capacidadeTotal) {
            this.capacidadeTotal = capacidadeTotal;
        }
        public int getCapacidadeTotal () {
            return this.capacidadeTotal;
        }
    }
}