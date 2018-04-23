using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    internal class BigBrother
    {
        private StateSaveLoad save;
        private DirectoryInfo dir;
        private FileSystemWatcher watcher;
        private DateTime lastRead = DateTime.MinValue;


        public BigBrother(string _path)
        {
            save = new StateSaveLoad();
            dir = new DirectoryInfo(_path);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }

        public void CreateObserver()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = dir.FullName;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.FileName
                | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
            watcher.Filter = "*.txt";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        public void LoadSavedState(string dirToLoad)
        {
            save.LoadSpecificDate(dir.FullName, dirToLoad);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            ConsoleCaller.WriteSimpleLine("Root file name changed!");
            ConsoleCaller.WriteSimpleLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            save.CreateSaveState(dir.FullName);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead)
            {
                lastRead = lastWriteTime;
                if (e.ChangeType == WatcherChangeTypes.Created)
                {
                    ConsoleCaller.WriteSimpleLine("New File cretaed!");
                }
                else if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    ConsoleCaller.WriteSimpleLine("Some thing changed!");
                }
                else if (e.ChangeType == WatcherChangeTypes.Deleted)
                {
                    ConsoleCaller.WriteSimpleLine("File deleted!");
                }
                ConsoleCaller.WriteSimpleLine("File: " + e.FullPath + " " + e.ChangeType);
                save.CreateSaveState(dir.FullName);
            }
        }
    }
}