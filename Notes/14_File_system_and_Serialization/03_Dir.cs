using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Directory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentFolder = Directory.GetCurrentDirectory();
            Console.WriteLine("Current folder {0}", currentFolder);

            var dirName = Directory.GetDirectories(@"C:\Windows\");
            Console.WriteLine("List of folders in the Windows folder");
            foreach (var item in dirName)
            {
                Console.WriteLine(item);
            }

            var fileName = Directory.GetDirectories(@"C:\Windows\");
            Console.WriteLine("List of files in the Windows folder");
            foreach (var item in fileName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List of files and folders in the Windows folder");
            string[] ff = Directory.GetFileSystemEntries(@"C:\Windows\");
            foreach (string entry in ff)
            {
                Console.WriteLine(entry);
            }
        }
    }
}