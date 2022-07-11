using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DirectoryInfo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo backupFolder = new DirectoryInfo(@"C:Demo\Backup\");
            if (!backupFolder.Exists)
            {
                backupFolder.Create();
            }
            string currentFolderName = Directory.GetCurrentDirectory();
            DirectoryInfo currentFolder = new DirectoryInfo(currentFolderName);
            foreach (FileInfo file in currentFolder.GetFiles())
            {
                file.CopyTo(backupFolder.FullName + @"\" + file.Name);
            }
        }
    }
}