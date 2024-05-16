using SetimoProjeto.Entities;
using SetimoProjeto.Entities.Enums;
using System.Globalization;

namespace SetimoProjeto {
    class Program {
        static void Main(string[] args) {
            /*
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list) {
                Console.WriteLine("Updated balance for account " + acc.Number + ": " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}