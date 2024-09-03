using ex_fixacao_oo_04;
using System.Globalization;

namespace ExFixacao
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoIni = Console.ReadLine();

            ContaBancaria conta;


            if (depositoIni == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositioInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositioInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(qnt);

            Console.WriteLine("dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(qnt);

            Console.WriteLine("dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();



        }
    }
}
