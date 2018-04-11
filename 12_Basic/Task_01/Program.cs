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
            Console.WriteLine("Start programm!");

            Loader mc = new Loader();
            mc.LoadFile();

            Console.ReadKey();
        }
    }
}
