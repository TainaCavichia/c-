namespace ex1
{
    public class contaCorrente
    {
        public string titular;

        public int agencia;

        public int numeroConta;
        
        public double saldo {get; private set;}

        public void Depositar(double valor){
            saldo += valor;
        }
        public bool Sacar(double valor){

            if(saldo < valor){
                return false;

            }else{
                saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, contaCorrente nomeDaConta){

            if (valor > saldo)
            {
                return false;
            }else
            {
                saldo -= valor;
                nomeDaConta.saldo += valor;
                return true;
            }
        }
    }
}
