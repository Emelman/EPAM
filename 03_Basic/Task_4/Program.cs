using MyPersonalHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_4
{
    class Program
    {
        static Random randomNum = new Random();
        static int[,] numArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two dimensional array length:");
            numArray = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            numArray = GeneratorRnd.TwoDimentional(numArray);
            Console.WriteLine("Count sum of all array elements:");
            var amount = CountPositiveIndexSum(numArray);
            Console.WriteLine(amount);
            Console.ReadKey();
        }

        private static object CountPositiveIndexSum(int[,] numArray)
        {
            int temp = 0; // sum of all indexes

            for(var i = 0; i < numArray.GetLength(0); i++)
            {
                for(var j = 0; j < numArray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        temp++;
                    }
                }
            }
            return temp;
        }
    }
}
