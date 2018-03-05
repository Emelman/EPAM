using MyPersonalHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int[] numArray;

        static void Main(string[] args)
        {
            GetParameters();

            SortArray(numArray);
        }

        private static void GetParameters()
        {
            Console.WriteLine("Enter array length:");
            var length = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter max and min int value:");
            var minVal = int.Parse(Console.ReadLine());
            var maxVal = int.Parse(Console.ReadLine());
            numArray = GeneratorRnd.OneDimensional(length, minVal, maxVal);
            Console.WriteLine(string.Join(",",SortArray(numArray))); //get the bubble sort result on screen
            Console.ReadKey();
        }

        private static int[] SortArray(int [] sortedArray)
        {
            int temp = 0;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int sort = 0; sort < sortedArray.Length - 1; sort++)
                {
                    if (sortedArray[sort] > sortedArray[sort + 1])
                    {
                        temp = sortedArray[sort + 1];
                        sortedArray[sort + 1] = sortedArray[sort];
                        sortedArray[sort] = temp;
                    }
                }
            }
            return sortedArray;
        }    
    }
}
