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
            Console.WriteLine("Create new Ring - enter outer radius:");
            string outer = Console.ReadLine();
            Console.WriteLine("Enter inner radius:");
            string inner = Console.ReadLine();
            Ring defaultRing = new Ring(new Point(23, 45), new Point(25, 50), int.Parse(outer), int.Parse(inner));
            Console.WriteLine("Get default ring data");
            Console.WriteLine("Circumfences outer and inner {0}", defaultRing.SumCircumference);
            Console.WriteLine("Ring area {0}", defaultRing.RingArea);
            Console.ReadKey();
        }
    }
}
