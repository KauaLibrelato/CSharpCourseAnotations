using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using NonoProjeto.Entities;

namespace NonoProjeto {
    class Program {
        static void Main(string[] args) {

            /*
            string sourcePath = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file1.txt";
            string targetPath = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string path = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file1.txt";

            //FileStream fs = null;
            StreamReader sr = null;

            try {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);

                while(!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally{
                if (sr != null) sr.Close();
               // if (fs != null) fs.Close();
            }
            */

            /*
            string path = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file1.txt";

            try {
                //comment
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                //comment         
                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string sourcePath = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file1.txt";
            string targetPath = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string path = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto";

            try {
                var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string s in folder) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");
                foreach (string s in folder) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string path = @"C:\Users\kaua.librelato\Documents\Pessoais\C#\Códigos\NonoProjeto\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("DirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("FileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("FullPath: " + Path.GetFullPath(path));
            Console.WriteLine("TempPath: " + Path.GetTempPath());
            */

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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