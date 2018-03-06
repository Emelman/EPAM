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
            var text = Console.ReadLine();
            if (text == "default")
            {
                text = "Написать программу, которая определяет среднюю длину слова во введенной текстовой строке. " +
                    "Учесть, что символы пунктуации на длину слов влиять не должны. Используйте стандартные методы " +
                    "класса String.";
            }
            string[] words = SeparateOnWords(text);
            int wordLength = CountWordlength(words);
            DisplayAll(words, wordLength);
        }

        private static void DisplayAll(string[] words, int wordLength)
        {
            Console.WriteLine("Result:");
            Console.WriteLine(wordLength);
            Console.WriteLine(string.Join(",", words));
            Console.ReadKey();
        }

        private static int CountWordlength(string[] words)
        {
            int countWords = 0;
            for (var i = 0; i < words.Length; i++)
            {
                countWords += words[i].Length;
            }
            countWords = countWords / words.Length;
            return countWords;
        }

        private static string[] SeparateOnWords(string text)
        {
            List<char> separatorArray = new List<char>();
            for(var i = 0; i < text.Length; i++)
            {
                if(!Char.IsLetter(text[i]))
                {
                    separatorArray.Add(text[i]);
                }
            }
            string[] words = text.Split(separatorArray.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            return words;
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
