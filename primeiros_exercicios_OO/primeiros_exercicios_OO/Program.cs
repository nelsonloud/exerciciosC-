using System;
using System.Globalization;
namespace primeiros_exercicios_OO {
    class Program {
        static void Main(string[] args) {

            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa:");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            B.Idade = int.Parse(Console.ReadLine());


            if (A.Idade > B.Idade) {
                Console.WriteLine("Pessoa mais velha: " + A.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + B.Nome);
            }

            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
