using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Round
    {
        Point center;
        double rad;

        public Round(Point _point, int v)
        {
            Center = _point;
            Rad = v;
        }

        public Point Center
        {
            get
            {
                return center;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Enter valid parameters");
                }
                else
                {
                    center = value;
                }
            }
        }

        public double Rad
        {
            get
            {
                return rad;
            }
            set
            {
                if(value > 0)
                {
                    rad = value;
                }
                else
                {
                    throw new ArgumentException("Wrong Radius");
                }
            }
        }

        public double Circumference
        {
            get
            {
                return 2 * Math.PI*Rad;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Rad, 2);
            }
        }
    }
}
