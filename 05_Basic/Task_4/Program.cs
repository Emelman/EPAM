﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "some words on my library";
            string badWord = " add something";
            string b = word;
            MyString line = new MyString(word);
            MyString line2 = new MyString(badWord);

            MyString goodLine = line + line2;

            Console.WriteLine("Substruct line - {0}", goodLine.ToString());
            Console.ReadKey();


        }
    }
}
