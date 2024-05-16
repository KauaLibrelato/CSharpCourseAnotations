using LinqExercises.Entities;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace LinqExercises {
    class Program {
        static void Main(string[] args) {

            /*
            Console.Write("Enter the path to the file: ");
            string path = Console.ReadLine();
            List<Product> products = new List<Product>();

            try {
                using (StreamReader sr = File.OpenText(path)) {

                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                       
                    }
                }

                Console.WriteLine();
                var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach (string name in names) {
                    Console.WriteLine(name);
                }


            }
            catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Employee> employees = new List<Employee>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
        
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter salary: ");
                double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine("Email of people whose salary is more than: " + salaryLimit.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();


                var emails = employees.Where(e => e.Salary > salaryLimit).OrderBy(e => e.Email).Select(e => e.Email);
                foreach (string email in emails) {
                    Console.WriteLine(email);
                }
                Console.WriteLine();
                var sumSalary = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}