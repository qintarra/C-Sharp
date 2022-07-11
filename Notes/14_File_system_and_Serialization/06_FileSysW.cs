using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileSystemWatcher_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Demo");
            watcher.NotifyFilter = (NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                NotifyFilters.FileName | NotifyFilters.DirectoryName);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Error += new ErrorEventHandler(OnError);
            watcher.EnableRaisingEvents = true;

            Console.ReadLine();

        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            WatcherChangeTypes changeType = e.ChangeType;
            Console.WriteLine("The file {0} {1}", e.FullPath, changeType.ToString());
        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            WatcherChangeTypes changeType = e.ChangeType;
            Console.WriteLine("The file {0} {2} to {1}", e.OldFullPath, e.FullPath, changeType.ToString());
        }
        private static void OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("An error has occured");
        }
    }
}