using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            DynamicArray<Point> mics = new DynamicArray<Point>();
            Point[] toAdd = new Point[5];
            for (var i = 0; i < 5; i++)
            {
                toAdd[i] = new Point();
                //mics.Add(new Point());
            }
            mics.AddRange(toAdd);
            mics.Remove(3);
            mics.Incert(new Point(15,24), 4);
            mics.Incert(new Point(12, 24), 3);
            mics.Incert(new Point(13, 24), 3);
            mics.Incert(new Point(123, 24), 3);
            mics.Incert(new Point(23, 24), 3);

            Console.WriteLine("length: " + mics.Length.ToString() + " capasity: " + mics.Capasity.ToString());
            Console.ReadKey();
        }
    }
}
