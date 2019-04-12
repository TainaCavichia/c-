using System;

namespace jesus
{
    class Passageiro
    {
       string nome;

       int NumeroPassagem;

       DateTime Data;

       public void setNome(string nome){
           this.nome = nome;
       }

       public string getNome(){
           return this.nome;
       }
       public void setNumeroPassagem(int numeroPassagem){
           this.NumeroPassagem = numeroPassagem;
       }
       public int getNumeroPassagem(){
           return this.NumeroPassagem;
       }
       public void setData(DateTime data){
           this.Data = data;
       }
       public DateTime getData(){
           return this.Data;
       }
    }
}
