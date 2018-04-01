using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        private static string pattern = @"[^\W\d][\w'-]*(?<=[a-zA-Z])"; // get words
        private static string keyLine = @"Anyone who's ever seen my work knows I'm a sucker for all things nerdy. 
            My home is, quite literally, a shrine to all of my favorite movies, TV shows, even games. 
            Over the years, I've recreated hundreds of props for friends to use in their cosplay at 
            the local Comicon, which can be extremely satisfying when you see how these props can pull a costume together.
            By far, though, my favorite time waster is making display props from hit movies that didn't 
            indulge in merchandising for various reasons, or that whatever merchandise they did create 
            is so rare and obscure as to make it unattainable to the average person. One big stipulation, 
            that I have, is that the props I make need to have form and function. Meaning that, it either 
            has to operate in the same way as it does in the franchise, or it must serve some other practical 
            function besides being a simple display item. In my top ten list of movies is the film 'The Fifth 
            Element'. Beyond being an amazing film, props and merchandise are extremely difficult to find, 
            and often if you do find something its either an expensive film prop that is profoundly expensive, 
            or a low quality(and equally expensive) representation that can only be bought from specialty sites.";

        private delegate string[] Parcer(string[] arg);
        private delegate void Handler(string[] arg);

        static void Main(string[] args)
        {
            Console.WriteLine("Sort string array!");
            CreateStringArray();
        }

        private static void CreateStringArray()
        {
            List<string> book = new List<string>();
            Dictionary<string, int> library = new Dictionary<string, int>();

            foreach (Match m in Regex.Matches(keyLine, pattern))
            {
                book.Add(m.Value);
                if (!library.ContainsKey(m.Value))
                {
                    library.Add(m.Value, 0);
                }
            }

            string[] anotheBook = book.ToArray();
            Parcer parce = SortStringArray;
            Handler handle = WordsInLinePrinter;
            handle(parce(anotheBook));
        }

        private static string[] SortStringArray(string[] _book)
        {
            Array.Sort(_book, (x, y) => (x.Length == y.Length) ? x.CompareTo(y) : x.Length.CompareTo(y.Length));
            //Array.Sort(_book, CompareTwoStrings);
            return _book;
        }

        static int CompareTwoStrings(string x, string y)
        {
            if (x.Length == y.Length)
            {
                return x.CompareTo(y);
            }
            return x.Length.CompareTo(y.Length);
        }

        private static void WordsInLinePrinter(string[] _book)
        {
            int wordLen = 1;
            string toPrint = "";
            foreach (var m in _book)
            {
                if(m.Length > wordLen)
                {
                    Console.WriteLine("words with length {0}: {1}",wordLen, toPrint);
                    Console.WriteLine();
                    wordLen = m.Length;
                    toPrint = m;
                }
                else
                {
                    toPrint = toPrint + " " + m;
                }
                
            }
            Console.ReadKey();
        }

        private static void SimplePrinter(string[] _book)
        {
            foreach (var m in _book)
            {
                Console.WriteLine("word: {0}", m);
            }
            Console.ReadKey();
        }
    }
}
