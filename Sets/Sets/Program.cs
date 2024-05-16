using System;
using System.Collections.Generic;
using Sets.Entities;
using System.IO;
namespace Sets {
    class Program {
        static void Main(string[] args) {
            /*
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV"));

            foreach (string p in set) {
                Console.WriteLine(p);
            }
            */

            /*
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };

            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            Console.WriteLine();

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            Console.WriteLine();

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            */

            /*
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Alex"));
            */

            /*
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
            */

            /*
             HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(username, instant));
                    }
                }
            }catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Total users: " + set.Count);
            */

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many studentes for Course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                courseA.Add(x);
            }

            Console.Write("How many studentes for Course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                courseB.Add(x);
            }

            Console.Write("How many studentes for Course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                courseC.Add(x);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);


        }

        /*
         static void PrintCollection<T>(IEnumerable<T> collection) {
             foreach (T obj in collection) {
                 Console.WriteLine(obj);
             }
         }
        */

    }
}