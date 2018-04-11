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
        private List<int> numbers;
        private DirectoryInfo nDir;
        private IEnumerable<FileInfo> info;
        public Loader()
        {

        }

        public void LoadFile(string dir = "default")
        {
            if (dir == "default")
            {
                nDir = new DirectoryInfo(Environment.CurrentDirectory);
            }
            else
            {
                nDir = new DirectoryInfo(dir);
            }
            numbers = new List<int>();
            info = nDir.EnumerateFiles("disp*.txt", SearchOption.TopDirectoryOnly);
            using (var file = new StreamReader(new FileStream(info.Last().FullName,
                FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    int result = 0;
                    if (int.TryParse(line, out result))
                    {
                        numbers.Add(result);
                    }
                }
                Console.WriteLine(String.Join(" \n\t", numbers.ToArray()));
            }
            MakeSquare();
        }

        private void MakeSquare()
        {
            for (var m = 0; m < numbers.Count; m++)
            {
                numbers[m] = numbers[m] * numbers[m];
            }
        }

        public void ModifyTxtFile()
        {
            try
            {
                File.WriteAllLines(info.Last().FullName, numbers.Select(n => n.ToString()));
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.ToString()}");
            }



            using (StreamWriter writeFile = new StreamWriter(new FileStream(info.Last().FullName,
                FileMode.Open, FileAccess.Write, FileShare.Read)))
            {
                for (var i = 0; i < numbers.Count; i++)
                {
                    writeFile.WriteLine(numbers[i]);
                }
            }
        }
    }
}
