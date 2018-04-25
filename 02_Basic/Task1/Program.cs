using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter width:");
            //string widthString = Console.ReadLine();

            //Console.WriteLine("Enter height:");
            //string heightString = Console.ReadLine();

            //int width = int.Parse(widthString);
            //int height = int.Parse(heightString);
            //int area = width * height;

            //if (width > 0 && height > 0)
            //{
            //    Console.WriteLine("Rect area:");
            //    Console.WriteLine(area);
            //}
            //else
            //{
            //    Console.WriteLine("data input ERrror");
            //}

            string s = "Hello world!";
            s = s.Replace(' ', '_');
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
