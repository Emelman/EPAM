﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_03
{
    public delegate void JobWellDone(string sort);
    public delegate void WakeUp(string sort, int time);

    class ObjectToSort
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

        //private delegate string[] Parcer(string[] arg);
        //private delegate void Handler(string[] arg);
        private static string[] anotheBook;
        public event JobWellDone Done;
        public event WakeUp OverSleep;
        public string myThreadName;

        public ObjectToSort()
        {
            Console.WriteLine("Create to sort string array!");
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

            anotheBook = book.ToArray();
        }

        public void StartSort()
        {
            anotheBook = SortStringArray(anotheBook, new MyComparer());
            SortDone();
        }

        public void PrintJobDone(string arg)
        {
            Console.WriteLine("Thread {0} complete its work!",arg);
        }

        public void PrintSleepOver(string arg, int time)
        {
            Console.WriteLine("Thread {0}, sleep over after {1} miliseconds.", arg, time);
        }

        private void SortDone()
        {
            //Done?.Invoke(myThreadName);

            if (Done != null)
            {
                Done(myThreadName);
            }
        }

        public void SleepDone(int time)
        {
            if (OverSleep != null)
            {
                OverSleep(myThreadName, time);
            }
        }

        class MyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return CompareTwoStrings(x, y);
            }
        }

        private static string[] SortStringArray(string[] _book, MyComparer comparer)
        {
            Array.Sort(_book, comparer);
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

    }
}
