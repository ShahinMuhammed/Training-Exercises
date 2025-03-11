using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Shahin";
            string copy = "new text ";
            string backup = "backup.txt";
            File.WriteAllText("filename.txt",name);

            string read = File.ReadAllText("filename.txt");
            Console.WriteLine(read);

            bool exist=File.Exists("filename.txt");
            Console.WriteLine(exist);

            File.Copy("filename.txt",copy);

            File.Replace(name, copy,backup);

            File.Delete("filename.txt");

        }
    }
}
