using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Triangle
    {
        private Boolean initialised = false;
        private int sideA;
        private int sideB;
        private int sideC;
        private int area;
        private int perimetr;


        public Triangle(int v1, int v2, int v3)
        {
            IsValid(v1, v2, v3);
            SideA = v1;
            SideB = v2;
            SideC = v3;
            initialised = true;
        }

        public int SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (initialised)
                {
                    IsValid();
                }
                sideA = value;
            }
        }

        public int SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (initialised)
                {
                    IsValid();
                }
                sideB = value;
            }
        }

        public int SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (initialised)
                {
                    IsValid();
                }
                sideC = value;
            }
        }

        internal void PrintSides()
        {
            Console.WriteLine("a is {0}, b is {1}, c is {2}", sideA, sideB, sideC);
            Console.ReadKey();
        }

        static void IsValid(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Sides of the triangle can` t be negative");
            }
            else if (a + b > c || a + c > b || b + c > a)
            {
                throw new Exception("This is not a triangle");
            }
        }

        private void IsValid()
        {
            if ((sideA <= 0 || sideB <= 0 || sideC <= 0) && isTriangle) 
            {
                throw new Exception("Sides of the triangle can` t be negative");
            }
        }

        private bool isTriangle
        {
            get
            {
                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    return true;
                }
                return false;
            }
        }

        public int Perimetr()
        {
            return sideA + sideB + sideC;
        }

        public double Area()
        {
            return Math.Sqrt(HalfPer() * (HalfPer() - sideA) * (HalfPer() - sideB) * (HalfPer() - sideC));
        }

        public double HalfPer()
        {
            return Perimetr() / 2;
        }
    }
}
