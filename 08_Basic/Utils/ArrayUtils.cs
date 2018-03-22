using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ArrayUtils
    {
        public static T[] DoubleCapasity<T>(T[] _ar)
        {
            T[] temp = new T[_ar.Length * 2];
            _ar.CopyTo(temp, 0);
            return temp;
        }

        public static T[] ExpandToArrayLengthSum<T>(T[] _arX, T[] _arY)
        {
            T[] toRetun = new T[_arX.Length + _arY.Length];
            _arX.CopyTo(toRetun, 0);
            _arY.CopyTo(toRetun, _arX.Length);
            return toRetun;
        }

        public static int GetLastIndex<T>(T[] _ar, int last = 0)
        {
            for (var i = last; i < _ar.Length; i++)
            {
                if (_ar[i] is T)
                {
                    last++;
                    continue;
                }
                else return i;
            }
            return last;
        }

        public static int GetArrayLength<T>(T[] _ar)
        {
            int count = 0;
            for (var i = 0; i < _ar.Length; i++)
            {
                if (_ar[i] is T)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
