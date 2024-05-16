using System;
using WorkerApp.Entities;
using WorkerApp.Entities.Enums;

namespace WorkerApp {
    class Program {
        static void Main(string[] args) {

            /*
            // WorkerApp
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Departament dept = new Departament(deptName);
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(workerName, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"));
            */

            //PostsApp
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            p1.AddComment(new Comment("Have a nice trip"));
            p1.AddComment(new Comment("Wow that's awesome!"));

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            p2.AddComment(new Comment("May the Force be with you"));
            p2.AddComment(new Comment("Good night"));

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}