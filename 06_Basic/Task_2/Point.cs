using System;

namespace Task_2
{
    internal class Point
    {
        int x;
        int y;
        private int v1;
        private int v2;

        public Point(int v1, int v2)
        {
            X = v1;
            Y = v2;
        }

        public int X
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

        public int Y
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