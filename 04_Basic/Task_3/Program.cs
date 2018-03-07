using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ruCulture = new CultureInfo("ru-RU", false);
            CultureInfo enCulture = new CultureInfo("en-US", false);
            CultureInfo invCulture = CultureInfo.InvariantCulture;
            CompareCulture(ruCulture, enCulture);
            CompareCulture(enCulture, invCulture);
            CompareCulture(ruCulture, invCulture);
        }

        private static void CompareCulture(CultureInfo culture1, CultureInfo culture2)
        {
            Console.WriteLine("Compare cultures {0} and {1}:\n", culture1.DisplayName, culture2.DisplayName);
            DateTime dt = new DateTime(2018, 3, 6, 19, 13, 32, 252);
            double num = 123213.132;
            Console.WriteLine("\t" + dt.ToString(culture1) + "\t\n");
            Console.WriteLine("\t" + dt.ToString(culture2) + "\t\n");
            Console.WriteLine("\t" + String.Format(culture1, "{0:C}", num) + "\t\n");
            Console.WriteLine("\t" + String.Format(culture2, "{0:0,0.000}", num) + "\t\n");
            Console.ReadKey();
        }
    }
}
