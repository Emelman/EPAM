using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GeometricProgression : ISeries
    {
        double start;
        double step;
        int currentIndex;

        public GeometricProgression(double _start, double _step)
        {
            start = _start;
            step = _step;
            currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(step, currentIndex - 1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
