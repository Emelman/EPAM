using System;

namespace Task_3
{
    internal class Point
    {
        int x;
        int y;
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

        public override int GetHashCode()
        {
            return X * 17 + Y * 13579;
        }

        public bool Equals(Point that)
        {
            if (that == null)
            {
                return false;
            }
            return this.X == that.X && this.Y == that.Y;
        }
    }
}