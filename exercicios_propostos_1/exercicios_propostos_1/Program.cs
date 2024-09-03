using System;
using System.Globalization;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            //ex 1
            int valor1, valor2, soma;

            Console.WriteLine("Adicione o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adicione o primeiro valor");
            valor2 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("soma = {0}", soma);
            Console.WriteLine($"soma = {soma}");

            
            //ex 2 -----------------------------------------
            double area;
            double pi = 3.14159;

            Console.WriteLine("Introduza o valo do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            
            //ex 3 -----------------------------------------
            int A, B, C, D, result;

            Console.WriteLine("Valor A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor C");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor D");
            D = int.Parse(Console.ReadLine());

            result = A * B - D * C;

            Console.WriteLine("DIFERENCA = " + result);

            
            //ex 4 --------------------------------------------
            int workerNumber, workedHours;
            double valuePerH, salary;

            Console.WriteLine("Introduza o número de funcionário:");
            workerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o número de horas trabalhadas:");
            workedHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza valor recebido por hora:");
            valuePerH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = workedHours * valuePerH;

            Console.WriteLine("NUMBER = " + workerNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));


            //ex 5 -----------------------------------------
            int codigoPeca1, codigoPeca2, numbPecas1, numbPecas2;
            double valorPeca1, valorPeca2, resultado;

            Console.WriteLine("Introduza valores da peça 1: codigo, numero de peças e valor unitário de cada peça");
            string[] vet = Console.ReadLine().Split(' ');


            numbPecas1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Introduza valores da peça 2: codigo, numero de peças e valor unitário de cada peça");
            vet = Console.ReadLine().Split(' ');

            numbPecas2 = int.Parse(vet[1]);
            valorPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            resultado = (numbPecas1 * valorPeca1) + (numbPecas2 * valorPeca2);
            Console.WriteLine("VALOR A PARGAR: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));


            //ex 6 ---------------------------------------------------------------------
            double a, b, c;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            double pi = 3.14159;


            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            areaCirculo = pi * Math.Pow(c, 2);
            areaTrapezio = ((a + b) * c) / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}

