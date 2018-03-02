using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {

        static Random randomNum = new Random();
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
            numArray = NumGenerator(length, minVal, maxVal);


            Console.ReadKey();
        }


        private static void SortArray(int [] someArray)
        {
            numArray = Array.Sort(numArray, 1);
            someArray[2] = 10;



        }





        private static int[] NumGenerator(int length = 0, int min = -10, int max = 10)
        {
            int[] tempArray = new int[length];
            for(var i = 0; i < length; i++)
            {
                tempArray[i] = randomNum.Next(min, max);
            }
            return tempArray;
        }

    }
}
