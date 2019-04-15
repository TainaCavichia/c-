using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Tsuka's Bank");

            contaCorrente conta1 = new contaCorrente();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite seu nome:");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Digite sua agencia:");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da sua conta:");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            Console.WriteLine("----------------------------------");
            // Console.WriteLine("Deseja sacar quanto?");
            // double valor = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);

            contaCorrente conta2 = new contaCorrente();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Digite seu nome:");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Digite sua agencia:");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da sua conta:");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            Console.WriteLine("----------------------------------");
            // Console.WriteLine("Deseja sacar quanto?");
            // double valor2 = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Titular {conta1.titular}");
            Console.WriteLine($"Agência {conta1.agencia}");
            Console.WriteLine($"Numero conta {conta1.numeroConta}");
            Console.WriteLine($"Saldo {conta1.saldo}");
            // Console.WriteLine($"Resultado do saque {resultado}");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Titular {conta2.titular}");
            Console.WriteLine($"Agência {conta2.agencia}");
            Console.WriteLine($"Numero conta {conta2.numeroConta}");
            Console.WriteLine($"Saldo {conta2.saldo}");
            // Console.WriteLine($"Resultado do saque {resultado}");
            Console.WriteLine("----------------------------------");

            bool resultadoTransferencia = true;

            do
            {
            Console.WriteLine("Quanto deseja transferir da conta1 para a conta2?");
            double valorTranferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(valorTranferencia, conta2);
                
            } while (resultadoTransferencia != true);

            Console.WriteLine("---------------Resultado após transferencia-------------------");
            Console.WriteLine($"Saldo conta 1: {conta1.saldo}");
            Console.WriteLine($"Saldo conta 2: {conta2.saldo}");

         }

    }
}
