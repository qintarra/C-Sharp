using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DriveInfo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivesOnComputer = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivesOnComputer)
            {
                Console.WriteLine("Drive {0}", drive.Name);
                Console.WriteLine(" File type {0}", drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine(" Volume label {0}", drive.VolumeLabel);
                    Console.WriteLine(" File system {0}", drive.DriveFormat);
                    Console.WriteLine(" Total size of drive: {0} bytes", drive.TotalSize);
                    Console.WriteLine("Total avaliable space {0} bytes", drive.TotalFreeSpace); ;
                }
                else
                {
                    Console.WriteLine("No media avaliable");
                }
                Console.WriteLine();
            }
        }
    }
}