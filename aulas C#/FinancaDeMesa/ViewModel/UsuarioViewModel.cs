using System;

namespace FinancaDeMesa.ViewModel
{
    public class UsuarioViewModel
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataDenascimento {get;set;}
        public double Saldo {get;set;}
    }
}