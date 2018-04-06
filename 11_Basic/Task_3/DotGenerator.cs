using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class DotGenerator
    {
        List<int> dots = new List<int>();
        public void CreateFactorialPoints()
        {
            Point pt;
            for (var i = 10000; i < 20000; i++)
            {
                for(var j = 10000; j < 15000; j++)
                {
                    pt = new Point(i, j);
                    dots.Add(pt.GetHashCode());
                }
            }

            var unique = dots.Distinct().ToList();

            Console.WriteLine($"all: {dots.Count}; unique: {unique.Count}");
            var diff = dots.Count - unique.Count;
            Console.WriteLine($"garbage: {diff}");
            var percent = (double)diff * 100 / dots.Count;
            Console.WriteLine($"percent: {percent}%");
            Console.ReadKey();
        }
    }
}
