using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create word list from text:");

            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DynamicArray<int> end = new DynamicArray<int>( ar );

            foreach(var m in end)
            {
                Console.WriteLine("test {0}", m);
            }

            Console.ReadKey();
        }
    }
}
