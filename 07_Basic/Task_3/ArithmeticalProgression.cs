using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ArithmeticalProgression : ISeries, IIndexable
    {
        double start, step;
        int currentIndex;
        double IIndexable.this[int index]
        {
            get
            {
                return start + step * index;
            }
        }

        public ArithmeticalProgression(double _start, double _step)
        {
            start = _start;
            step = _step;
            currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
