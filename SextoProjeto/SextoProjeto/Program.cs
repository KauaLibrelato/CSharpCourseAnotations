using SextoProjeto.Entities;
using System;
using System.Globalization;

namespace SextoProjeto {
    internal class Program {
        static void Main(string[] args) {
            /*
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount bAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bAccount;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // Error
            BusinessAccount aac5 = acc3 as BusinessAccount;

            if (acc3 is BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            /*
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees) {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}