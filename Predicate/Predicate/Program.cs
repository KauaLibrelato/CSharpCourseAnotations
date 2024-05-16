using System;
using PredicateAndActionAndFunc.Entities;
using System.Collections.Generic;
using System.Linq;
namespace PredicateAndActionAndFunc {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(ProductTest);

            //Action<Product> act = UpdatePrice;

            //list.ForEach((p) => p.Price += p.Price * 0.1);

            //list.ForEach(UpdatePrice);

            //list.ForEach(act);

            /*
             foreach (Product p in list) {
                Console.WriteLine(p);
            }
            */

            //List<string> result = list.Select(NameUpper).ToList

            //Func<Product, string> func = NameUpper;
            //Func<Product, string> func = p => p.Name.ToUpper();

            //List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result) {
                Console.WriteLine(s);
            }

        }
        /*
          static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
        */

        /*
         static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
        */

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}