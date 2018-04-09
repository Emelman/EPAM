using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class BigBrother
    {
        private StateSaver save;
        private DirectoryInfo dir;
        private FileSystemWatcher watcher;
        private DateTime lastRead = DateTime.MinValue;

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public BigBrother(string _path)
        {
            save = new StateSaver();
            dir = new DirectoryInfo(_path);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }

        public void CreateObserver()
        {
            string[] args = System.Environment.GetCommandLineArgs();
            Console.WriteLine("Start to Observe");

            watcher = new FileSystemWatcher();
            watcher.Path = dir.FullName;
            watcher.NotifyFilter = NotifyFilters.LastAccess| NotifyFilters.FileName 
                | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        public void LoadSavedState() 
        {
            Console.WriteLine("Please, print date you seek. Format - yyyyMMddHHmmss - year month day hour minutes seconds");
            save.LoadSpecificDate(dir.FullName);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Root file name changed!");
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead)
            {
                lastRead = lastWriteTime;
                if (e.ChangeType == WatcherChangeTypes.Created)
                {
                    Console.WriteLine("New File cretaed!");
                    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
                }
                else if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    Console.WriteLine("Some thing changed!");
                    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
                }
                else if (e.ChangeType == WatcherChangeTypes.Deleted)
                {
                    Console.WriteLine("File deleted!");
                }
                save.CreateSaveState(dir.FullName);
            }
        }

        private void ChangeCheck(object sender, FileSystemEventArgs e)
        {
            if (Directory.Exists(e.FullPath))
            {
                foreach (string file in Directory.GetFiles(e.FullPath))
                {
                    var info = new FileInfo(e.FullPath);
                    if (!File.Exists(Path.GetFileName(file)) || (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        var eventArgs = new FileSystemEventArgs(WatcherChangeTypes.Changed,
                        Path.GetDirectoryName(file), Path.GetFileName(file));
                        OnChanged(sender, eventArgs);
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Some thing changed!");
                Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            }
        }
    }
}
