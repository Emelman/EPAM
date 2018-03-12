using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Triangle
    {
        public Triangle(double v1, double v2, double v3)
        {
            ThrowIfInvalid(v1, v2, v3);
            SideA = v1;
            SideB = v2;
            SideC = v3;
        }

        public double SideA
        {
            get;
            private set;
        }

        public double SideB
        {
            get;
            private set;
        }

        public double SideC
        {
            get;
            private set;
        }

        public override string ToString()
        {
            //return string.Format("a is {0}, b is {1}, c is {2}", SideA, SideB, SideC);
            return $"a is {SideA}, b is {SideB}, c is {SideC}";
        }

        static void ThrowIfInvalid(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Sides of the triangle can` t be negative");
            }
            else if (a + b < c || a + c < b || b + c < a)
            {
                throw new Exception("This is not a triangle");
            }
        }

        public double Perimetr
        {
            get
            {
                return SideA + SideB + SideC;
            }
        }

        public double Area
        {
            get
            {
                return Math.Sqrt(Perimetr / 2 * ( - SideA) * (Perimetr / 2 - SideB) * (Perimetr / 2 - SideC));
            }
        }
    }
}
