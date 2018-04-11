using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    internal class StateSaveLoad
    {
        private DirectoryInfo saveFolder;
        public StateSaveLoad()
        {
            var path = Path.Combine(@"C:\Users\Emelman\source\repos\EPAM\12_Basic\Task_02\saved_states", "");
            saveFolder = new DirectoryInfo(path);
            if (!saveFolder.Exists)
            {
                saveFolder.Create();
            }
        }

        public void CreateSaveState(string sourceDir)
        {
            try
            {
                DateTime cur = DateTime.Now;
                string date = cur.ToString("yyyyMMddHHmmss");
                DirectoryInfo subFolder = new DirectoryInfo(Path.Combine(saveFolder.FullName, date));
                subFolder.Create();

                foreach (var file in Directory.GetFiles(sourceDir, "*.txt", SearchOption.TopDirectoryOnly))
                {
                    var destFile = Path.Combine(subFolder.FullName, Path.GetFileName(file));
                    File.Copy(file, destFile);
                }
                foreach (var directory in Directory.GetDirectories(sourceDir, "*", SearchOption.TopDirectoryOnly))
                {
                    Directory.CreateDirectory(Path.Combine(subFolder.FullName, Path.GetFileName(directory)));
                    CopyFilesToDir(directory, Path.Combine(subFolder.FullName, Path.GetFileName(directory)));
                }
            }
            catch (Exception e)
            {
                ConsoleCaller.WriteSimpleLine($"Oops! Something went wrong! Error - {e.ToString()}");
                return;
            }
            ConsoleCaller.WriteSimpleLine("Save sucessed!");
            ConsoleCaller.WriteSimpleLine("");
        }

        public void LoadSpecificDate(string sourceDir, string toLoad)
        {
            if (!Directory.Exists(Path.Combine(saveFolder.FullName, toLoad)))
            {
                ConsoleCaller.WriteSimpleLine("There is no folder with such name!");
                return;
            }
            try
            {
                DeleteAllFiles(sourceDir);
                var destination = Path.Combine(saveFolder.FullName, toLoad);
                var dirr = Directory.GetFiles(destination, "*.txt", SearchOption.TopDirectoryOnly);
                foreach (var file in dirr)  /// , @"**\*.txt"
                {
                    File.Copy(file, Path.Combine(sourceDir, Path.GetFileName(file)));
                }
                foreach (var directory in Directory.GetDirectories(destination, "*", SearchOption.TopDirectoryOnly))
                {
                    Directory.CreateDirectory(Path.Combine(sourceDir, Path.GetFileName(directory)));
                    CopyFilesToDir(directory, Path.Combine(sourceDir, Path.GetFileName(directory)));
                }
            }
            catch (Exception e)
            {
                ConsoleCaller.WriteSimpleLine($"Oops! Something went wrong! Error - {e.ToString()}");
                return;
            }
            ConsoleCaller.WriteSimpleLine("Load sucessed!");
            ConsoleCaller.WriteSimpleLine("");
        }

        private void CopyFilesToDir(string sourceDir, string destination)
        {
            foreach (var file in Directory.GetFiles(sourceDir, "*.txt", SearchOption.TopDirectoryOnly))
            {
                var destFile = Path.Combine(destination, Path.GetFileName(file));
                File.Copy(file, destFile);
            }
            foreach (var directory in Directory.GetDirectories(sourceDir, "*", SearchOption.TopDirectoryOnly))
            {
                Directory.CreateDirectory(Path.Combine(destination, Path.GetFileName(directory)));
                CopyFilesToDir(directory, Path.Combine(destination, Path.GetFileName(directory)));
            }
        }

        private void DeleteAllFiles(string _path)
        {
            DirectoryInfo di = new DirectoryInfo(_path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
