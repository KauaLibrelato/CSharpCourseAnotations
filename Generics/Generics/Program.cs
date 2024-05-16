using System.Globalization;
using Generics.Entities;
using Generics.Services;

namespace Generics
{
    class Program {
        static void Main(string[] args) {
            /*
           PrintService<string> printService = new PrintService<string>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Enter value: ");
                string value = Console.ReadLine();
                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            */

            /*
            List<Product> list = new List<Product>();

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Enter value: ");
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
            */

            Client a = new Client("Maria", "maria@gmail.com");
            Client b = new Client("Alex", "maria@gmail.com");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}