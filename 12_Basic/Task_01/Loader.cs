using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Loader
    {
        public Loader()
        {

        }

        public void LoadSpecificFile()
        {
            List<int> numbers = new List<int>();
            DirectoryInfo nDir = new DirectoryInfo(Environment.CurrentDirectory);
            IEnumerable<FileInfo> temp = nDir.EnumerateFiles("disp*.txt", SearchOption.TopDirectoryOnly);

            var fs = new FileStream(temp.Last().FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            using (StreamReader file = new StreamReader(fs)) //File.OpenText(last.FullName))
            {
                int result = 0;
                int counter = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    int.TryParse(line, out result);
                    numbers.Add(result * result);
                }
                Console.WriteLine(String.Join(" \n\t", numbers.ToArray()));
            }

            var fsToWrite = new FileStream(temp.Last().FullName, FileMode.Open, FileAccess.Write, FileShare.Read);
            using (StreamWriter writeFile = new StreamWriter(fsToWrite))
            {
                for (var i = 0; i < numbers.Count; i++)
                {
                    writeFile.WriteLine(numbers[i]);
                }
            }
        }
    }
}
