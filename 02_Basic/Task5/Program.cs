using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of triangles:");
            string data = Console.ReadLine();
            int countTr = int.Parse(data);
            Console.WriteLine("Cristmas Tree height - " + countTr);
            var currentTriangleHeight = 1;
            var maxTriangleBorder = countTr - 1;
            do
            {
                //Console.WriteLine("start" + num);    // show triangle height
                for (var i = 0; i < currentTriangleHeight * 2; i += 2)
                {
                    string pad = new string('*', i + 1);
                    string prePad = new string(' ', (maxTriangleBorder * 2 - i + 1) / 2);
                    Console.WriteLine(prePad + pad);
                }
                currentTriangleHeight++;
                countTr--;
            }
            while (countTr > 0);
            Console.ReadKey();
        }
    }
}
