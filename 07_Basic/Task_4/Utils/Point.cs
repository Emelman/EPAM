using System;

namespace Task_4
{
    internal class Point
    {
        double x;
        double y;

        public Point(double v1, double v2)
        {
            X = v1;
            Y = v2;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}