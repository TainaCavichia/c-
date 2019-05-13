using System;

namespace FinancaDeMesa.ViewModel
{
    public class TransacaoViewModel : UsuarioViewModel
    {
       public string Tipo {get;set;}
       public string Descricao {get;set;}
       public DateTime DataTransacao {get;set;}
       public double Valor {get;set;} 
    }
}