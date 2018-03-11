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
        double area;
        double circumference;

        public Point Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
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
                    Circumference = rad;
                    Area = rad;
                }
                else
                {
                    throw (Error.InnerException);
                }
            }
        }

        public double Circumference
        {
            get
            {
                return circumference;
            }
            private set
            {
                circumference = 2*Math.PI*value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
            private set
            {
                area = Math.PI * Math.Pow(value, 2);
            }
        }

        public Exception Error { get; private set; }
    }
}
