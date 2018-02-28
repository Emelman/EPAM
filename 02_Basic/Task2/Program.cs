using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put the number");
            var nHeigth = Console.ReadLine();
            int i;
            int length = int.Parse(nHeigth);


            for(i = 0; i < length; i++)
            {
                string pad = new string('*', i+1);
                Console.WriteLine(pad);

            }


            Console.ReadKey();
        }
    }
}
