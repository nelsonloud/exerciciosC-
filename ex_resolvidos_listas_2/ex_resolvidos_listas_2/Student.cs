using System.Globalization;

namespace ex_resolvidos_listas_2 {
    internal class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; private set; }

        public Student(int id, string name, double grade) {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public void gradeUpade(double newGrade) {
            Grade = newGrade;
        }


        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Grade.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
