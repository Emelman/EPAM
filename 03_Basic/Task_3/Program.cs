using MyPersonalHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static Random randomNum = new Random();
        static int[] numArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length:");
            var length = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter max and min int value:");
            var minVal = int.Parse(Console.ReadLine());
            var maxVal = int.Parse(Console.ReadLine());
            numArray = GeneratorRnd.OneDimensional(length, minVal, maxVal);
            int? amount = CountAllPoisitiveNum(numArray);
            Console.WriteLine("Show amount:"+amount.ToString());
            Console.ReadKey();
        }

        private static int? CountAllPoisitiveNum(int[] numArray)
        {
            int[] test = new int[numArray.Length];
            int number = 0;
            for(var i = 0; i < numArray.Length; i++)
            {
                if(numArray[i] > 0)
                {
                    number += numArray[i];
                    test[i] = numArray[i];
                }
            }
            Console.WriteLine(string.Join("+", test)); // display all positive numbers
            Console.ReadKey();
            return number;
        }
    }
}
