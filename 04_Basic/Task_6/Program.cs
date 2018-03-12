using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static string pattern = @"[-]?\d+(?:\.\d+(?:e-\d+)?)?";
        static string sciencePattern = @"[-]?\d\.\d+e-{0,1}\d+";
        static string fractionPattern = @"[-]?\d+\.\d+";
        static string numPattern = @"[-]?\d+";
        private static string toModify;
        private static string keyLine;

        static void Main(string[] args)
        {
            OptionsToChoose();
            MatchTheLine();
        }

        private static void MatchTheLine()
        {
            Console.WriteLine("Please, choose pattern type, print 1,2,3or4 uiversal,science,fraction,uint:");
            string key = Console.ReadLine();
            string choosedPattern;
            switch (key[0])
            {
                case '1':
                    choosedPattern = pattern;
                    break;
                case '2':
                    choosedPattern = sciencePattern;
                    break;
                case '3':
                    choosedPattern = fractionPattern;
                    break;
                case '4':
                    choosedPattern = numPattern;
                    break;
                default:
                    Console.WriteLine("Error no such pattern type!");
                    return;
            }

            Console.WriteLine("Result:");
            foreach (Match m in Regex.Matches(keyLine, choosedPattern))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            Console.ReadKey();
        }

        private static void OptionsToChoose()
        {
            Console.WriteLine("Get the number from string(to Use defaults - print Y):");
            string button = Console.ReadLine();
            if (button[0] == 'y')
            {
                keyLine = "например, 127 = 1.27*102  = 1.27e2, -0.0055 = -5.5*10-3 = -5.5e-3).";
            }
            else
            {
                Console.WriteLine("Please, enter the comparison line:");
                keyLine = Console.ReadLine();
            }
        }
    }
}
