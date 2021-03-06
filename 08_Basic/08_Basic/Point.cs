﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Basic 
{
    class Point : IComparable<Point>
    {
        int x;
        int y;

        public Point()
        {

        }

        public Point(int _x,int _y)
        {
            X = _x;
            Y = _y;
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

        public int CompareTo(Point other)
        {
            int sum1 = this.X + this.Y;
            int sum2 = other.X + other.Y;

            if (sum1 > sum2)
            {
                return 1;
            }

            if (sum1 == sum2)
            {
                return 0;
            }

            return -1;
        }
    }
}
