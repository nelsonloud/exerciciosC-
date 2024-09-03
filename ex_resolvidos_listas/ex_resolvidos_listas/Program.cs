using ex_resolvidos_listas;
using System.Globalization;
using System.Collections.Generic;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 0; i < n; i++) {
    Console.WriteLine("Employee #" + (i+1) + ":");
    Console.Write("Id: ");
    int id;
    Employee employee;

    // Solicita e verifica o ID até encontrar um ID único
    do {
        Console.Write("Id: ");
        id = int.Parse(Console.ReadLine());

        // Verifica se o ID já existe na lista
        employee = employees.Find(x => x.Id == id);

        if (employee != null) {
            Console.WriteLine("This ID already exists. Please enter a unique ID.");
        }
    } while (employee != null);



    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    
    Console.WriteLine();
    employees.Add(new Employee(id, name, salary));
}

Console.Write("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());


Employee emp = employees.Find(x => x.Id == searchId);
if (emp != null) {
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(percentage);
}
else {
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");

foreach (Employee obj in employees) {
    Console.WriteLine(obj);
}
