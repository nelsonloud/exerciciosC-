using System;
using System.Collections.Concurrent;
using System.Globalization;


namespace Course {
    internal class Program {
        static void Main(string[] args) {


            //ex 1
            Console.Write("Insira o número de casos de teste: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }




            //ex 2
            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());

            //int valIn = 0;
            //int valOut = 0;


            //for (int i = 1; i <= N; i++) {
            //    Console.Write("valor " + i + ": ");
            //    int input = int.Parse(Console.ReadLine());

            //    if (input >= 10 && input <= 20) {
            //        valIn++;
            //    }
            //    else {
            //        valOut++;
            //    }

            //}

            //Console.WriteLine(valIn + " in");
            //Console.WriteLine(valOut + " out");

            //ex 3
            //Console.Write("Insira o número de casos de teste: ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++) {
            //    Console.Write("insira os tres numeros: ");
            //    string[] vet = Console.ReadLine().Split(' ');

            //    double val1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //    double val2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //    double val3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //    double media = ((val1 * 2) + (val2 * 3) + (val3 * 5)) / (2 + 3 + 5);
            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            //ex 4
            //Console.Write("Insira o número de casos de teste: ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++) {
            //    Console.Write("insira os dois numeros: ");
            //    string[] vet = Console.ReadLine().Split(' ');

            //    double val1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //    double val2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //    double divisao = 0;

            //    if (val2 != 0) {
            //        divisao = val1 / val2;
            //        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //    else {
            //        Console.WriteLine("divisao impossivel");
            //    }
            //}

            //ex 5
            //int n = int.Parse(Console.ReadLine());

            //int fat = 1;
            //for (int i = 1; i <= n; i++) {
            //    fat = fat * i;
            //}

            //Console.WriteLine(fat);

            //ex 6
            //Console.Write("Insira o número de casos de teste: ");

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {
            //    if (n % i == 0) {
            //        Console.WriteLine(i);
            //    }
            //}


            //ex 7
            //Console.Write("Insira o número de casos de teste: ");

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {
            //    Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
            //}
        }

    }
}
