using System;

namespace senaizinho
{
    class Sala
    {

        public int numeroSala;

        public int capacidadeTotal;

        public int capacidadeAtual;

        public string[] alunos;

        public void setNumeroSala(int numeroSala)
        {
            this.numeroSala = numeroSala;
        }
        public int getNumeroSala()
        {
            return this.numeroSala;
        }
        public void setCapacidadeTotal(int capacidadeTotal)
        {
            this.capacidadeTotal = capacidadeTotal;
        }
        public int getCapacidadeTotal()
        {
            return this.capacidadeTotal;
        }
    }
}
