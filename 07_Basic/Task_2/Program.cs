using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic progression:");
            GeometricProgression progr = new GeometricProgression(12, 2);
            for (var i = 0; i < 10; i++)
            {
                progr.MoveNext();
            }
            Console.WriteLine(progr.GetCurrent().ToString());

            PrintSeries(progr);
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
