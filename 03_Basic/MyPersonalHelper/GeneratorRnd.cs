using System;

namespace MyPersonalHelper
{
    public class GeneratorRnd
    {
        static Random randomNum = new Random();

        public static int[] OneDimensional(int length = 0, int min = -10, int max = 10)
        {
            int[] tempArray = new int[length];
            for (var i = 0; i < length; i++)
            {
                tempArray[i] = randomNum.Next(min, max);
            }
            //Console.WriteLine(string.Join(",",tempArray)); // check random generator 
            //Console.ReadKey();
            return tempArray;
        }

        public static int[,] TwoDimentional(int[,] rndArray)
        {
            int minBorder = -100;
            int maxBorder = 100;
            for (var i = 0; i < rndArray.GetLength(0); i++)
            {
                for (var j = 0; j < rndArray.GetLength(1); j++)
                {
                    rndArray[i, j] = randomNum.Next(minBorder, maxBorder);
                }
            }
            return rndArray;
        }

        public static int[,,] TreeDimentional(int dimention1 = 5, int dimention2 = 5, int dimention3 = 5)
        {
            int[,,] rndArray = new int[dimention1, dimention2, dimention3];
            int minBorder = -100;
            int maxBorder = 100;
            for (var i = 0; i < dimention1; i++)
            {
                for (var j = 0; j < dimention2; j++)
                {
                    for (var k = 0; k < dimention3; k++)
                    {
                        rndArray[i, j, k] = randomNum.Next(minBorder, maxBorder);
                    }
                }
            }
            return rndArray;
        }
    }
}
