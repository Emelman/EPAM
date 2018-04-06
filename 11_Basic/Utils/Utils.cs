using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Utils
    {
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static double Power(double num, double exp)
        {
            return Math.Pow(num, exp);
        }
    }
}
