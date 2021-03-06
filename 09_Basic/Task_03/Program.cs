﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_Basic
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

        static void Main(string[] args)
        {
            Console.WriteLine("Create word list from text:");
            List<string> book = new List<string>();
            Dictionary<string, int> library = new Dictionary<string, int>();

            foreach (Match m in Regex.Matches(keyLine, pattern))
            {
                book.Add(m.Value);
                if (!library.ContainsKey(m.Value))
                {
                    library.Add(m.Value, 0);
                }
                //else
                //{
                //    library[m.Value]++;
                //}
            }

            string[] anotheBook = book.ToArray();
            GetAllWordRepetitions(book);
            GetWordsRepetitionsDict(library, book);
        }

        private static void GetWordsRepetitionsDict(Dictionary<string, int> library, List<string> book)
        {
            var len = book.Count;
            for (var i = 0; i < len; i++)
            {
                library[book[i]]++;
            }

            foreach (var m in library)
            {
                Console.WriteLine("Word {0} repetitions - {1}", m.Key, m.Value);
            }
            Console.ReadKey();
        }

        static void GetAllWordRepetitions(List<string> _book)
        {
            for (var i = 0; i < _book.Count; i++)
            {
                int count = 0;
                for (var j = i + 1; j < _book.Count; j++)
                {
                    if (String.Equals(_book[i], _book[j], StringComparison.OrdinalIgnoreCase))
                    {
                        _book.RemoveAt(j);
                        count++;
                    }
                }
                Console.WriteLine("Word {0} repetitions - {1}", _book[i], count);
            }
            Console.ReadKey();
        }
    }
}
