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
            string pattern = @"\b([0-1]?\d\:[0-5]\d)?(2[0-3]\:[0-5]\d)?\b";
            string textLine = "В7777 7:55, hj я встал и позавтракал.";
            string newTxt = @"В 17:55 я встал, позавтракал 11:69 sadas 12:39 13:39  7:55  10:55 1:55 21:55 03:55 04:01 29:44\:";
            Console.ReadKey();
            Console.WriteLine("Result:");
            foreach (Match m in Regex.Matches(newTxt, pattern))
            {
                if(m.Value != string.Empty) Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            Console.ReadKey();
        }
    }
}
