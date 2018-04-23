using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public static class ConsoleCaller 
    {
        public static void WriteSimpleLine(string line)
        {
            Console.WriteLine(line);
        }

        public static string ReadSimpleLine()
        {
            return Console.ReadLine();
        }

        public static ConsoleKeyInfo ReadSimpleKey()
        {
            return Console.ReadKey();
        }
    }
}
