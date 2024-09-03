using System;
using System.Globalization;

namespace ex_fixacao_oo_01 {
    internal class Program {
        static void Main(string[] args) {
            
            Retangulo rec = new Retangulo();

            Console.WriteLine("Entre a altura e a altura do rectangulo: ");
            rec.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rec.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = rec.Area();
            double perimetro = rec.Perimetro();
            double diagona = rec.Diagonal();
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagona.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
