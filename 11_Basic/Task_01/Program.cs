using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trace factorial!");
            int incr = 5;
            int num = Utils.Utils.Factorial(incr);
            Console.WriteLine("My factorial {0} is {1}", incr, num);
            Console.WriteLine("My exponet result {0}", Utils.Utils.Power(10,13));
        }

        
    }
}
