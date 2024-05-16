using System;
using System.IO;
namespace Dictionary {
    class Program {
        static void Main(string[] args) {
            /*
             Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            }
            else {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            foreach(var item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            */

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream) {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);
                        
                        if(dictionary.ContainsKey(candidate)) {
                            dictionary[candidate] += votes;
                        }
                        else {
                            dictionary[candidate] = votes;
                        }

                        foreach(var item in dictionary) {
                            Console.WriteLine(item.Key + ": " + item.Value);
                        }
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }



        }
    }
}