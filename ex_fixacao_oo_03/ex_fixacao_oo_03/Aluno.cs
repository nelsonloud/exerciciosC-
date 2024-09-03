using System.Globalization;


namespace ex_fixacao_oo_03 {
    internal class Aluno {

        public String Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalNotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (CalNotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
           
            if(Aprovado()) {
                return 0.0;
            }
            else {
                return 60 - CalNotaFinal();
            }
        }
    }
}
