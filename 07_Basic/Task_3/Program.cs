using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic progression and list:");

            ArithmeticalProgression newAp = new ArithmeticalProgression(14,3);
            double[] newCollect = GenerateDouble(10);
            List newList = new List(newCollect);
            while(newList.MoveNext())
            {
                Console.WriteLine(newList.GetCurrent());
            }

            PrintSeries(newList);

            Console.ReadKey();
        }

        static double[] GenerateDouble(int Leng)
        {
            double[] ar = new double[Leng];
            for (var i = 0; i < 10; i++)
            {
                ar[i] = 123123;
            }
            return ar;
        }

        static void PrintSeries(ISeries series)
        {
            //series.Reset();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
