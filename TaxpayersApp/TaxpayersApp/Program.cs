using TaxpayersApp.Entities;
using System.Globalization;

namespace TaxpayersApp {
    class Program {
        static void Main(string[] args) {
            
            List<Person> persons = new List<Person>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (type == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    persons.Add(new PhysicalPerson(name, anualIncome, healthExpenditures));
                }
                else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    persons.Add(new LegalPerson(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach (Person person in persons) {
                Console.WriteLine(person.Name + ": $ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += person.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}