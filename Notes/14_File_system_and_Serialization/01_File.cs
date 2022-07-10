using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace File_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:Demo\MyFile.txt"))
                File.Delete(@"C:Demo\MyFile.txt");

            File.AppendAllText(@"C:Demo\MyFile.txt", "Here we are, born to be kings. ");
            File.AppendAllText(@"C:Demo\MyFile.txt", "We're the princes of the universe.");

            //Copies an existing file into a new file
            File.Copy(@"C:Demo\MyFile.txt", @"C:Demo\CopyFile.txt");

            string s = File.ReadAllText(@"C:Demo\CopyFile.txt");
            Console.WriteLine(s);
        }
    }
}