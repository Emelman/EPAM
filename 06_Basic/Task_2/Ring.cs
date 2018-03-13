using System;

namespace Task_2
{
    internal class Ring : Round
    {
        int innerRad;
        Point innerPoint;

        public Ring(Point _outP, Point _innerP, int _outerR, int _innerR) : base(_outP, _outerR)
        {
            InnerRad = _innerR;
            InnerPoint = _innerP;
        }

        public int InnerRad
        {
            get
            {
                return innerRad;
            }
            private set
            {
                if (value > 0 && value < Rad)
                {
                    innerRad = value;
                }
                else
                {
                    throw new ArgumentException("Wrong Radius");
                }
            }
        }

        public Point InnerPoint
        {
            get
            {
                return innerPoint;
            }
            private set
            {
                double difX = Center.X - value.X;
                double difY = Center.Y - value.Y;
                double hipot = Math.Abs(Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2)));
                if (InnerRad > hipot)
                {
                    throw new ArgumentException("Inner ring circle goes out from the outer circle!");
                }
                else
                {
                    innerPoint = value;
                }
            }
        }

        public double InnerCircumference
        {
            get
            {
                return 2 * Math.PI * InnerRad;
            }
        }

        public double SumCircumference
        {
            get
            {
                return Circumference + InnerCircumference;
            }
        }

        public double RingArea
        {
            get
            {
                return Area - (Math.PI * Math.Pow(InnerRad, 2));
            }
        }
    }
}