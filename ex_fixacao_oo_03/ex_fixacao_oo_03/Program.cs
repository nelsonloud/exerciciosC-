using System.Globalization;
using System.Xml;

namespace ex_fixacao_oo_03 {
    internal class Program {

        static void Main(string[] args) {
            Aluno al = new Aluno();
            
            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaF = al.CalNotaFinal();
            Console.WriteLine("NOTA FINAL = " + notaF.ToString("F2", CultureInfo.InvariantCulture));

            if(al.Aprovado()) {
                Console.WriteLine("APROVADO");
            } 
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }


            
            
        }
    }
}
