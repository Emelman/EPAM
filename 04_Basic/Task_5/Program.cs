using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clean line from tags:");
            Console.ReadKey();
            MatchTheLine();
        }

        private static void MatchTheLine()
        {
            string htmlTest = @"<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            string pattern = @"<[^>]+>";

            htmlTest = Regex.Replace(htmlTest, pattern, "_");
            Console.WriteLine("Result:" + htmlTest);
            Console.ReadKey();
        }
    }
}
