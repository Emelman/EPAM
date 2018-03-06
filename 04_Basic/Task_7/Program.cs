using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get time from line:");
            string pattern = "\b[a-z]";
            string textLine = "В 7:55 я встал и позавтракал.";
            Console.WriteLine(Regex.Replace(textLine, pattern, String.Empty));
            Console.ReadKey();


            //Regex regex = new System.Text.RegularExpressions.Regex(@"туп(\w*)", RegexOptions.IgnoreCase);

        }
    }
}
