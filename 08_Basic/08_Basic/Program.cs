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
                toAdd[i] = new Point(1,3);
                mics.Add(new Point(1,2));
            }
            mics.AddRange(toAdd);
            mics.Remove(3);
            mics.Incert(new Point(15,24), 4);
            mics.Incert(new Point(12, 24), 2);
            mics.Incert(new Point(35, 34), 3);
            mics.Incert(new Point(90, 14), 3);
            mics.Incert(new Point(16, 35), 3);
            mics.Incert(new Point(123, 56), 5);
            mics.Incert(new Point(23, 24), 1);


            Console.WriteLine("Item X: " + mics[7].X.ToString() + "  Item Y : " + mics[7].Y.ToString());
            Console.WriteLine("length: " + mics.Length.ToString() + " capasity: " + mics.Capasity.ToString());
            Console.ReadKey();
        }
    }
}
