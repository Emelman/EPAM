using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class List<T> : ISeries<T>, IIndexable<T>
    {
        private T[] series;
        private int currentIndex;

        public List(T[] _series)
        {
            series = _series;
            currentIndex = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= series.Length)
                {
                    throw new IndexOutOfRangeException("is out of range");
                }
                return series[index];
            }
        }

        public T GetCurrent()
        {
            if (currentIndex >= series.Length) Reset();
            if (currentIndex < 0) return series[0];
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= series.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

    }
}
