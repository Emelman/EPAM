using Interfaces;
using System;
using System.Collections.Generic;
using Utils;

namespace _08_Basic
{
    internal class DynamicArray<T> : IIndexable<T>, ISeries<T> where T : new()
    {
        int length;
        T[] arrayHolder;
        private int currentIndex;

        public DynamicArray()
        {
            Capasity = 8;
            Length = 0;
        }

        public DynamicArray(int _len)
        {
            Capasity = _len;
            Length = 0;
        }

        public DynamicArray(T[] _array)
        {
            Capasity = _array.Length;
            Length = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= arrayHolder.Length)
                {
                    throw new IndexOutOfRangeException("is out of range");
                }
                return arrayHolder[index];
            }
        }

        public T GetCurrent()
        {
            if (currentIndex >= arrayHolder.Length) Reset();
            if (currentIndex < 0) return arrayHolder[0];
            return arrayHolder[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= arrayHolder.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public int Length
        {
            get
            {
                return ArrayUtils.GetArrayLength(arrayHolder);
            }
            private set
            {
                if(value >= 0)
                {
                    length = value; 
                }
            }
        }

        public int Capasity
        {
            get
            {
                return arrayHolder.Length;
            }
            private set
            {
                if(value > 0)
                {
                    arrayHolder = new T[value];
                }
                else
                {
                    throw new ArgumentException("Wrong Array Capasity!");
                }
            }
        }

        public void Add(T item)
        {
            int index = ArrayUtils.GetLastIndex(arrayHolder);
            if(index >= Capasity)
            {
                arrayHolder = ArrayUtils.DoubleCapasity(arrayHolder);
            }
            arrayHolder[index] = item;
            Length = length + 1;
        }

        public void AddRange(T[] items)
        {
            int index = ArrayUtils.GetLastIndex(arrayHolder);
            if(Length + items.Length >= Capasity)     // one position reserved
            {
                arrayHolder = ArrayUtils.ExpandToArrayLengthSum(arrayHolder, items);
            }
            else
            {
                for(var i = index; i < index+items.Length; i++)
                {
                    arrayHolder[i] = items[i - index];
                }
            }
            Length = length + items.Length;
        }

        public void Incert(T item, int index)
        {
            T[] part2 = new T[Capasity - index];
            Array.Copy(arrayHolder, index, part2, 0, part2.Length);
            T[] part1 = new T[index + 1];
            Array.Copy(arrayHolder, part1, index);
            part1[index] = item;
            arrayHolder = ArrayUtils.ExpandToArrayLengthSum(part1, part2);
            Length = part1.Length + part2.Length;
        }

        public void ReplaceAndMoveForward(T item, int index)
        {
            T toMove = arrayHolder[index];
            int last = ArrayUtils.GetLastIndex(arrayHolder, index + 1);
            if (last == Capasity)
            {
                arrayHolder = ArrayUtils.DoubleCapasity(arrayHolder);
            }
            arrayHolder[index] = item;
            arrayHolder[last] = toMove;
            Length = length + 1;
        }

        public bool Remove(uint index)
        {
            if(index > Capasity)
            {
                return false;
            }
            arrayHolder[index] = default(T);
            Length = length - 1;
            return true;
            //T toDell = this[index]; // ask why it doesnt work?
            //toDell = default(T);    // ask why it doesnt work?
        }
    }
}