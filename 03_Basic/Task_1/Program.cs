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
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length:");
            int[] numArray = NumGenerator((int.Parse(Console.ReadLine())));


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
