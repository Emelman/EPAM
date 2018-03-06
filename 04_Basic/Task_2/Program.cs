using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        private static string toModify;
        private static string keyLine;

        static void Main(string[] args)
        {
            ChooseOptions();
            keyLine = CreateUniqueKey(keyLine);
            Console.WriteLine("Prepared keyline:");
            Console.WriteLine(keyLine);
            string result = ModifyLine(toModify, keyLine);
            Console.WriteLine("Modified line:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void ChooseOptions()
        {
            Console.WriteLine("Use defaults - print Y:");
            string button = Console.ReadLine();
            if (button[0] == 'y')
            {
                toModify = "написать программу, которая";
                keyLine = ",,..описание изделия из картона";
            }
            else
            {
                Console.WriteLine("Please, enter the line to edit:");
                toModify = Console.ReadLine();
                Console.WriteLine("Please, enter the comparison line:");
                keyLine = Console.ReadLine();
            }
        }

        private static string CreateUniqueKey(string keyLine)
        {
            List<char> unicKeysArray = new List<char>();
            Boolean addValue = false;
            for (var i = 0; i < keyLine.Length; i++)
            {
                addValue = true;
                for (var j = 0; j < unicKeysArray.Count; j++)
                {
                    if (keyLine[i] == unicKeysArray[j])
                    {
                        addValue = false;
                        break;
                    }
                }
                if (addValue && Char.IsLetter(keyLine[i]))
                {
                    unicKeysArray.Add(keyLine[i]);
                }
            }
            return String.Join("", unicKeysArray.ToArray());
        }

        private static string ModifyLine(string toModify, string keyLine)
        {
            List<char> tempArray = new List<char>();
            for (var i = 0; i < toModify.Length; i++)
            {
                for (var j = 0; j < keyLine.Length; j++)
                {
                    if (Char.IsLetter(toModify[i]) && toModify[i] == keyLine[j])
                    {
                        tempArray.Add(toModify[i]);
                    }
                }
                tempArray.Add(toModify[i]);
            }
            return String.Join("", tempArray.ToArray());
        }
    }
}
