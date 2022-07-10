using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace File_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo data = new FileInfo(@"C:Demo\MyFile.txt");
            data.CopyTo(@"C:Demo\CopyFile1.txt");
            FileInfo copyFile = new FileInfo(@"C:Demo\CopyFile1.txt");
            Console.WriteLine(copyFile.OpenText().ReadToEnd());

            copyFile.Attributes = FileAttributes.ReadOnly;
            //copyFile.Attributes = FileAttributes.Hidden;
            if (copyFile.Attributes == FileAttributes.ReadOnly)
            Console.WriteLine("YES");

            data.Delete();
        }
    }
}
