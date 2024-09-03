using System.Globalization;

namespace ex_fixacao_oo_04 {
    internal class ContaBancaria {

        public int Numero { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositioInicial) : this(numero, titular) {
            Numero = numero;
            Titular = titular;
            Deposito(depositioInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            quantia += 5.0;
            Saldo -= quantia;
        }

        public override string ToString() {
            return "Conta " + Numero
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
