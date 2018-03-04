using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three dimensions length (default 5):");
            int dimention1 = int.Parse(Console.ReadLine());
            int dimention2 = int.Parse(Console.ReadLine());
            int dimention3 = int.Parse(Console.ReadLine());
            int[,,] multidimArray = MyPersonalHelper.GeneratorRnd.TreeDimentional(dimention1, dimention2, dimention3);
            multidimArray = TakeOfAllPositiveNum(multidimArray);
            Printer(multidimArray);
        }

        private static int[,,] TakeOfAllPositiveNum(int[,,] sortedArray)
        {
            for (int i = 0; i < sortedArray.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArray.GetLength(1); j++)
                {
                    for(int k = 0; k < sortedArray.GetLength(2); k++)
                    {
                        if (sortedArray[i, j, k] > 0)
                        {
                            sortedArray[i, j, k] = 0;
                        }
                    }
                }
            }
            return sortedArray;
        }

        private static void Printer(int[,,] toPrintArray)
        {
            Console.WriteLine("Get result on screen:");

            for (int i = 0; i < toPrintArray.GetLength(0); i++)
            {
                for (int j = 0; j < toPrintArray.GetLength(1); j++)
                {
                    for (int k = 0; k < toPrintArray.GetLength(2); k++)
                    {
                        Console.Write(string.Format("{0} ", toPrintArray[i, j, k]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
