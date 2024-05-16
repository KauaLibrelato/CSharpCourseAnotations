using System;
using System.Globalization;
using System.Collections.Generic;

namespace TerceiroProjeto {
    class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("Entre a quantidade de produtos a ser cadastrado:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Produto #{i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = nome, Price = preco };

            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }
            double avg = sum / n;

            Console.WriteLine();
            Console.WriteLine($"Preço médio = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            Student[] vect = new Student[10];

            Console.WriteLine("Quantos quartos a serão alugados:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Aluguel #{i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                vect[quarto] = new Student(nome, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            */

            /*
            int result = Calculator.Sum( 10, 1, 2, -1 );
            Console.WriteLine(result);
            */

            /*
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
            */

            /*
             List<string> list = new List<string>();
             list.Add("Maria");
             list.Add("Alex");
             list.Add("Bob");
             list.Add("Anna");
             list.Insert(2, "Marco");

             foreach (string obj in list) {
                 Console.WriteLine(obj);
             }

             Console.WriteLine("List count: " + list.Count);

             string s1 = list.Find(x => x[0] == 'A');
             Console.WriteLine("First 'A': " + s1);

             string s2 = list.FindLast(x => x[0] == 'A');
             Console.WriteLine("Last 'A': " + s2);

             int pos1 = list.FindIndex(x => x[0] == 'A');
             Console.WriteLine("First position 'A': " + pos1);

             int pos2 = list.FindLastIndex(x => x[0] == 'A');
             Console.WriteLine("Last position 'A': " + pos2);

             List<string> list2 = list.FindAll(x => x.Length == 5);
             Console.WriteLine("---------------------");
             foreach (string obj in list2) {
                 Console.WriteLine(obj);
             }

             list.Remove("Alex");
             list.RemoveAt(3);
             list.RemoveRange(2, 2);
             Console.WriteLine("---------------------");
             foreach (string obj in list) {
                 Console.WriteLine(obj);
             }

             list.RemoveAll(x => x[0] == 'M');
             Console.WriteLine("---------------------");
             foreach (string obj in list) {
                 Console.WriteLine(obj);
             }
             */

            /*
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
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
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
            */

            /*
            Console.WriteLine("Digite como será a ordem da sua matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
            */

            Console.WriteLine("Digite como será sua matriz");
            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int[,] matriz = new int[m, n];
            Console.WriteLine();
            Console.WriteLine("Digite os valores da matriz");

            for (int i = 0; i < m; i++) {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(line[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite o número que deseja encontrar: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if (matriz[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if(j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if(i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if(j < n - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if(i < m - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }



        }
    }
}
