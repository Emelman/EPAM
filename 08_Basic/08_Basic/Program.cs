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
            DisplayArray(mics);

            mics.AddRange(toAdd);
            DisplayArray(mics);

            mics.Remove(0);
            mics.Remove(3);
            mics.Remove(mics.Length);
            DisplayArray(mics);

            mics.Incert(new Point(15,24), 0);
            mics.Incert(new Point(123, 56), 5);
            mics.Incert(new Point(23, 24), mics.Length);
            DisplayArray(mics);


            mics.Sort();
            Console.WriteLine("AFTER SORT!");
            DisplayArray(mics);

            Console.WriteLine("Item X: " + mics[7].X.ToString() + "  Item Y : " + mics[7].Y.ToString());
            Console.WriteLine("length: " + mics.Length.ToString() + " capasity: " + mics.Capasity.ToString());
            Console.ReadKey();


            
        }

        private static void DisplayArray(DynamicArray<Point> mics)
        {
            for (var i = 0; i < mics.Length; i++)
            {
                Console.WriteLine("Item X: {0} , Y: {1}", mics[i].X, mics[i].Y);
            }

            Console.WriteLine();
        }
    }
}
