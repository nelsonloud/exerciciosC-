using System.Globalization;

namespace ex_resolvido_classes {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmStock() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity) {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }

        public override string ToString() {
            return Nome
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " unidades, total: $ " 
                + ValorTotalEmStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
