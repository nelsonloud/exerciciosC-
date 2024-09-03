using ex_fixacao_vetor_01;
using System.Collections.Concurrent;

namespace ex_fixacao_vect { 
    internal class Program {
        static void Main(string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int roomsRented = int.Parse(Console.ReadLine());

            for (int i = 0; i < roomsRented; i++) {
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[room] = new Estudante { Name = name, Email = email };
            
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < vect.Length; i++) {

                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i].Name + ", " + vect[i].Email);
                }

            }
        }
    }
}
