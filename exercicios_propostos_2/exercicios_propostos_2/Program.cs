using System;
using System.Globalization;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            //ex 1
            int i;

            Console.WriteLine("insira um número inteiro");

            i = int.Parse(Console.ReadLine());

            if (i >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }


            //ex 2
            int i;
            int resto;
            Console.WriteLine("insira um número inteiro, para saber se é par ou ímpar");

            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }

            //ex 3
            int valA, valB, divResul;
            Console.WriteLine("insira dois valores para saber de são multipos");

            string[] vet = Console.ReadLine().Split(' ');

            valA = int.Parse(vet[0]);
            valB = int.Parse(vet[1]);

            if (valA >= valB) {
                divResul = valA % valB;
            }
            else {
                divResul = valB % valA;
            }

            if (divResul == 0) {
                Console.WriteLine("São Múltiplos");
            }
            else {
                Console.WriteLine("Não são Múltiplos");
            }

            //ex 4
            int val1, val2, result = 0;
            Console.WriteLine("introduza a hora de início e hora de fim do jogo");
            string[] vet = Console.ReadLine().Split(' ');
            val1 = int.Parse(vet[0]);
            val2 = int.Parse(vet[1]);

            if (val1 > val2) {
                result = 24 - val1 + val2;
            }
            else if (val1 < val2) {
                result = val2 - val1;
            }
            else if (val1 == val2) {
                result = 24;
            }

            Console.WriteLine("O JOGO DUROU " + result + "HORA(S)");

            //ex 5
            int codigo, quantidade;
            double total = 0.0;

            Console.WriteLine("introduza codigo do item e respetiva quantidade");
            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1) {
                total = quantidade * 4.00;
            }
            else if (codigo == 2) {
                total = quantidade * 4.50;
            }
            else if (codigo == 3) {
                total = quantidade * 5.00;
            }
            else if (codigo == 4) {
                total = quantidade * 2.00;
            }

            else if (codigo == 5) {
                total = quantidade * 1.50;
            }

            Console.WriteLine("TOTAL: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            //ex 6
            double intervalo;
            Console.WriteLine("insira um intervalo, exemplo: 25.01");
            intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalo >= 0 && intervalo <= 25) {
                Console.WriteLine("INTERVALO [0,25]");
            }
            else if (intervalo >= 25 && intervalo <= 50) {
                Console.WriteLine("INTERVALO [25,50]");
            }
            else if (intervalo >= 50 && intervalo <= 75) {
                Console.WriteLine("INTERVALO [50,75]");
            }
            else if (intervalo >= 75 && intervalo <= 100) {
                Console.WriteLine("INTERVALO [75,100]");
            }
            else {
                Console.WriteLine("Fora do intervalo");
            }

            //ex 7
            double valorX, valorY;
            Console.WriteLine("Introduza o valor de X e o valor de Y");
            string[] vet = Console.ReadLine().Split(' ');

            valorX = double.Parse(vet[0], CultureInfo.InvariantCulture);
            valorY = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (valorX == 0.0 && valorY == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (valorX == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (valorY == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (valorX > 0.0 && valorY > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (valorX < 0.0 && valorY > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (valorX < 0.0 && valorY < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }

            //ex 8
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}

