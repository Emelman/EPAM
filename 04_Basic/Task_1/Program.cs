using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text to parce or use default:");
            //var text = Console.ReadLine();
            string text = "Написать программу, котораяuuuuu определяетuuuuu среднююuuuu длинуuuuuuu ";


            //dump();
            int wordLength = ParceText(text);

        }

        private static int ParceText(string text)
        {
            int totalLength = 0;
            int countWords = 0;
            List<char> separatorArray = new List<char>();
            for(var i = 0; i < text.Length; i++)
            {
                if(!Char.IsLetter(text[i]))
                {
                    separatorArray.Add(text[i]);
                }
            }

            string[] words = text.Split(separatorArray.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            for(var i = 0; i < words.Length; i++)
            {
                countWords += words[i].Length;
            }
            countWords = countWords / words.Length;
            Console.WriteLine("REsult:");
            Console.WriteLine(countWords);
            Console.WriteLine(words);
            Console.ReadKey();
            return totalLength;
        }




        public static void Dump()
        {
            char[] charsToTrim = { '*', '\'' };
            string banner = "***..... Much Ado About Nothing...... ***";
            string result = banner.Trim('*', '\'', '.');
            Console.WriteLine("Trimmmed\n   {0}\nto\n   '{1}'", banner, result);
            Console.ReadKey();
        }

    }
}
