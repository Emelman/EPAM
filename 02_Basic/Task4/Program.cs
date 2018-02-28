using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("put the number of lines");
            string lines = Console.ReadLine();
            int num = int.Parse(lines);
            Console.WriteLine(args);

            for(var i = 0; i < num*2; i+=2)
            {
                string pad = new string('*', i + 1);
                string prePad = new string(' ', (num - i+1)/2);

                Console.WriteLine(prePad+pad);
            }


            Console.ReadLine();

        }
    }
}
