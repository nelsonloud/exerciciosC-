using System.Globalization;

namespace ex_fixacao_oo_02 {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double percentagem) {
            return SalarioBruto += SalarioBruto * (percentagem * 0.01);
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
