using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_Basic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Create word list from text:");
            List<int> book = new List<int>() { 1, 2, 3, 4, 5,6};
            LinkedList<int> specialBook = new LinkedList<int>();

            var len = book.Count;
            for (var i = 0; i < len; i++)
            {
                specialBook.AddLast(book[len - (i + 1)]);
            }
            Console.WriteLine("list collection = {0}", CircleRemover(book).ElementAt(0));
            Console.WriteLine("list collection = {0}", CircleRemover(specialBook).ElementAt(0));
            CircleRemover(specialBook);
            Console.ReadKey();
        }
        private static ICollection<int> CircleRemover(ICollection<int> array)
        {
            bool delete = false;
            do
            {
                int toDellLength = 0;
                List<int> toDell = new List<int>();
                foreach (var m in array)
                {
                    if (delete)
                    {
                        toDellLength++;
                        toDell.Add(m);
                        delete = false;
                    }
                    else
                    {
                        delete = true;
                    }
                }

                for (var i = 0; i < toDellLength; i++)
                {
                    array.Remove(toDell[i]);
                }
            }
            while (array.Count > 1);
            return array;
        }
    }
}
