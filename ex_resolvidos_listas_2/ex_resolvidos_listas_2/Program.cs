using System.Globalization;
using System.Collections.Generic;
using ex_resolvidos_listas_2;

Console.Write("How many students will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Student> listStudent = new List<Student>();

int id;
Student student;

for (int i = 1; i <= n; i++) {
    Console.WriteLine("Student #" + i + ":");

    do {
        Console.Write("Id: ");
        id = int.Parse(Console.ReadLine());


        //variavel do tipo student, recebe um null/nao null, da comparacao
        //do id da listStudent com id inserido pelo user
        student = listStudent.Find(x  => x.Id == id);

        if (student != null) {
            Console.Write("This ID already exists. Please enter a unique ID: ");
        }

    } while (student != null);

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Grade: ");
    double grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listStudent.Add(new Student(id, name, grade));

    Console.WriteLine();
}

Console.Write("Enter the student id that will have grade update: ");
id = int.Parse(Console.ReadLine());
student = listStudent.Find(x => x.Id == id);

if (student != null) {
    Console.Write("Enter the new grade: ");
    double newGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    student.gradeUpade(newGrade);
} else {
    Console.WriteLine("Invalid ID");
}

Console.WriteLine();

foreach(Student obj in listStudent) {
    Console.WriteLine(obj);
}


