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
            Console.WriteLine("Create Round object, print radius:");
            Round circle = new Round();
            circle.Center = new Point(30, 40);
            circle.Rad = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Result - circle data:");
            Console.WriteLine("circle x position {0}, circle y position {1}", circle.Center.X, circle.Center.Y);
            Console.WriteLine("Circle Circumference - {0}", circle.Circumference);
            Console.WriteLine("Circle area - {0}", circle.Area);
            Console.ReadKey();
        }
    }
}
