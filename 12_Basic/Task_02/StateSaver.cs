using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class StateSaver
    {
        private DirectoryInfo saveFolder;
        public StateSaver()
        {
            var path = Path.Combine(@"C:\Users\Emelman\source\repos\EPAM\12_Basic\Task_02\saved_states", "");
            saveFolder = new DirectoryInfo(path);
            if (!saveFolder.Exists)
            {
                saveFolder.Create();
            }

            Console.WriteLine(saveFolder.FullName);
        }

        public void CreateSaveState(string sourceDir)
        {
            try
            {
                DateTime cur = DateTime.Now; 
                string date = cur.ToString("yyyyMMddHHmmss"); 
                string extension;
                DirectoryInfo subFolder = new DirectoryInfo(Path.Combine(saveFolder.FullName, date));
                subFolder.Create();

                foreach (var file in Directory.GetFiles(sourceDir))
                {
                    extension = Path.GetExtension(file);
                    if (extension == ".txt")
                    {
                        File.Copy(file, Path.Combine(subFolder.FullName, Path.GetFileName(file)));
                    }
                }

                foreach (var directory in Directory.GetDirectories(sourceDir))
                {
                    File.Copy(directory, Path.Combine(subFolder.FullName, Path.GetFileName(directory)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops! Something went wrong! Error - {0}", e.ToString());
                return;
            }
            Console.WriteLine("Save sucessed!");
        }

        public void LoadSpecificDate(string sourceDir)
        {
            string toLoad = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(toLoad, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please try again. Pattern is yyyyMMddHHmmss");
                toLoad = Console.ReadLine();
            }

            try
            {
                foreach (var directory in Directory.GetDirectories(saveFolder.FullName, toLoad))
                {
                    DeleteAllFiles();
                    File.Copy(directory, Path.Combine(sourceDir, Path.GetFileName(directory)));
                    break;
                }
            }
            catch
            {

            }

            
        }

        private void DeleteAllFiles()
        {
            DirectoryInfo di = new DirectoryInfo("YourPath");

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
